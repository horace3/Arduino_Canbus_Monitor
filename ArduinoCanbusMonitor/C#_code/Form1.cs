// C# test program for Bytronic PIC24F board using a background worker
//
// this is not thread safe 
// - the background worker communicates directly with the GUI components
//   it should use a delegate
//   e.g. try running using debugger - it will trow an exception!
// use the version using a timer instead

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using USB_PIC24_MECHATRONICS_DATA_DLL;
using System.IO.Ports;

namespace PIC24mechatronicsCsharp
{
    public partial class Form1 : Form
    {
        // delegate to transfer received data to TextBox
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        private bool running;
         private bool transmitCANBUSmessage = false, setCANBUSparameters = false;
        private UInt16 Rx0extended=0,  Rx1extended=0;
        private UInt32 Rx0mask=0, Rx1mask=0;
        private UInt32[] Rx0filter={0, 0},  Rx1filter={0, 0, 0, 0};
        private UInt32 canbusTranmitID = 0;
        private int extendedID = 0, RTR = 0;
        private UInt64 canbusMessage;
        private UInt16 CANBUSspeed = 250;
        private string serialData;
        private bool canbusMonitorFound=false;

        public Form1()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            backgroundWorker1.RunWorkerAsync();
 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // thread handling communication with the mechatronics board
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
              Console.WriteLine("background worker ");
            running = true;
            setCANBUSparameters = true;
            // Get a list of serial port names.
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

           // terminalTextBox.AppendText("The following serial ports were found:" + Environment.NewLine);
             terminalTextBox.Invoke(this.myDelegate, new Object[] { "The following serial ports were found:" });

            // Display each port name to the console. and send > to prompt for response
            foreach (string port in ports)
            {
                try
                {
                    terminalTextBox.Invoke(this.myDelegate, "attempting to open " + port + Environment.NewLine);
                    //terminalTextBox.Invoke(this.myDelegate, new Object[] { "  " + port });
                    serialPort1.PortName = port;
                    serialPort1.Open();
                }
                catch (Exception e1)
                {
                }
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(">");
                    Thread.Sleep(1000);
                    if (canbusMonitorFound) break;
                    serialPort1.Close();
                }
                terminalTextBox.Invoke(this.myDelegate, "communication failed " + Environment.NewLine);
                Thread.Sleep(1000);
            }
            if (serialPort1.IsOpen) terminalTextBox.Invoke(this.myDelegate, "serial port open OK" + Environment.NewLine);
            else
            {
                terminalTextBox.Invoke(this.myDelegate, "Communication to Arduino failed! is it connected?" + Environment.NewLine);
                canbusReceivedMessageTextBox.Invoke(this.myDelegate, ">Communication to Arduino failed! " + Environment.NewLine
                                                              + "   is it connected?" + Environment.NewLine);
            }
            while (running)
            {
                 {
                    Text = "Canbus monitor";      // display connected message
                    if (setCANBUSparameters)  CANBUStransmitSetup() ;           // transmit CANBUS data to board?                                                                            //Console.WriteLine("status {0}", status);
                    toolStripStatusLabel1.Text = "Canbus monitor";
                   //Console.WriteLine("transmitCANBUSmessage {0}", transmitCANBUSmessage);
                    if (transmitCANBUSmessage) CANBUStransmitMessageNow();
                 }
            //    Invalidate();                               // force redraw of graphics to display any drawing etc
              //  Update();
             //   Thread.Sleep(100);
            }
            // running has been set to false, send RESET to board and then close the Form
            Console.WriteLine("background worker exit ");
            Close();
        }

        // Form is closing, if background working is running stop it and call close again
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (running) { running = false; e.Cancel = true; }
            serialPort1.Close();

        }

        private void serialPort1_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //textBox1.AppendText(serialPort1.ReadExisting());  // not thread safe
            serialData = serialPort1.ReadLine();// Existing();
            terminalTextBox.Invoke(this.myDelegate, new Object[] { serialData });
            if (serialData.Contains("Canbus monitor")) canbusMonitorFound = true;
        }

        // display seral data on textbox
        public void AddDataMethod(String myString)
        {
            terminalTextBox.AppendText(myString + Environment.NewLine);
            var chars = myString.ToCharArray();
            if (chars[0] == '>') canbusReceivedMessageTextBox.AppendText(myString.Substring(1)+Environment.NewLine);
        }

 
        // Form has been invalidated - repaint it
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
		    Graphics g = e.Graphics;								        // get graphics context
		    g.Clear(Color.White);									        // clear the background to White
        }

 
        private void transmitButton_Click(object sender, EventArgs e)
        {
            transmitCANBUSmessage = true;
        }

        private void canbisMessageTextBox_TextChanged(object sender, EventArgs e)
        {
            read64bitHexNumber(canbusMessageTextBox, ref canbusMessage);
        }

        // read a 29bit hex number (canbus ID) from TextBox, if not hex reject it, write number back to text box
        private UInt32 read29bitHexNumber(TextBox textbox, ref UInt32 number)
        {
            if (textbox.Text == "")                      // if TextBox is empty value is 0
                number = 0;
            else                                         // else convert string to hex
                try
                {
                    UInt32 ID = Convert.ToUInt32(textbox.Text, 16);
                    //Console.WriteLine(ID)
                    if (ID <= 0x1FFFFFFF) number = ID;  // if > 29bit reject it
                }
                catch (Exception) { }
            //Console.WriteLine("number {0:X}", number);
            textbox.Text = String.Format("{0:X}", number);    // write number back out to TextBox
            textbox.Select(100, 100);
            return number;
        }

        // read a 11bit or 29bit hex number (canbus ID) from TextBox, if not hex reject it, write number back to text box
        private UInt32 read11or29bitHexNumber(TextBox textbox, ref UInt32 number, bool extended)
        {
            if (textbox.Text == "")                      // if TextBox is empty value is 0
                number = 0;
            else                                         // else convert string to hex
                try
                {
                    UInt32 ID = Convert.ToUInt32(textbox.Text, 16);
                    //Console.WriteLine(ID)
                    if (extended)
                    { if (ID <= 0x1FFFFFFF) number = ID; } // if > 29bit reject it
                    else
                        if (ID <= 0x7ffUL) number = ID;   // if > 11bit reject it
                }
                catch (Exception) { }
            //Console.WriteLine("number {0:X}", number);
            textbox.Text = String.Format("{0:X}", number);    // write number back out to TextBox
            textbox.Select(100, 100);
            return number;
        }

        // read a 64bit hex number (canbus ID) from TextBox, if not hex reject it, write number back to text box
        private UInt64 read64bitHexNumber(TextBox textbox, ref UInt64 number)
        {
            if (textbox.Text == "")                      // if TextBox is empty value is 0
                number = 0;
            else                                         // else convert string to hex
                try
                {
                    UInt64 ID = Convert.ToUInt64(textbox.Text, 16);
                    //Console.WriteLine(ID)
                    number = ID;  
                }
                catch (Exception) { }
            //Console.WriteLine("number {0:X}", number);
            textbox.Text = String.Format("{0:X}", number);    // write number back out to TextBox
            textbox.Select(100, 100);
            return number;
        }

    // transmit an 8 byte canbus message from TextBox canbusMessageTextBox canbus ID is in transmitIDtextBox
    private void CANBUStransmitMessageNow()
    {
        transmitCANBUSmessage = false;
            Console.WriteLine("CANBUStransmitMessageNow()");
        // right justify hex digits filling with 0's from right
        StringBuilder s = new StringBuilder("0000000000000000", 25);
        for(int ii = 0; ii <=  canbusMessageTextBox.Text.Length - 1; ii++)
            s[ii] = canbusMessageTextBox.Text[ii];                   // copy hex digits to s
        String save = s.ToString();
        canbusMessage = Convert.ToUInt64(save, 16);                  // convert s to 64 bit unsigned number
        int[] message = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        int i  = 7;
        while (i >= 0 )         // convert 64bit number into 8 byte values
        {
            UInt64 x = 0xFF;
            try
            { message[i] = Convert.ToInt16(canbusMessage & x); }      // get rightmost byte
            catch (Exception) { }
            canbusMessage = canbusMessage >> 8 ;                        // shift right one byte
            i = i - 1 ;                                                 // get next byte
        }
        read29bitHexNumber(canbusIDtextBox, ref canbusTranmitID);       // get the can ID
        if (RTRcheckBox.Checked) RTR = 1; else RTR = 0;
        if (extended29bitIDcheckBox.Checked) extendedID = 1; else extendedID = 0;
        PIC24_mechatronics.CANBUStransmit(serialPort1, extendedID, canbusTranmitID, RTR, message);                // transmit message
    }

 
    private void setCanbus_Click(object sender, EventArgs e)
    {
        setCANBUSparameters = true;
    }

    private void CANBUStransmitSetup()
     {
        setCANBUSparameters = false;
        if (button125.Checked)   CANBUSspeed = 125;          // setup canbus speed 
        else
            if (button250.Checked)  CANBUSspeed = 250; else CANBUSspeed = 500;
        if (RFX0checkBox.Checked) Rx0extended = 1; else Rx0extended = 0;
        if (RFX1checkBox.Checked) Rx1extended = 1; else Rx1extended = 0;
        //Console.WriteLine("CANBUStransmitSetup filter {0:X} mask {1:X} speed {2}", canbusMask, canbusFilter, CANBUSspeed);
        PIC24_mechatronics.CANBUSsetup(serialPort1, Rx0extended, Rx0mask, Rx0filter, Rx1extended, Rx1mask, Rx1filter, CANBUSspeed);
            //canbusMask, canbusFilter, CANBUSspeed);
     }

 
      private void canbusTextBox_TextChanged(object sender, EventArgs e)
      {
          read11or29bitHexNumber(canbusIDtextBox, ref canbusTranmitID, extended29bitIDcheckBox.Checked);
          read11or29bitHexNumber(CANBUSmaskRFX0textBox, ref Rx0mask, RFX0checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF0_1textBox, ref Rx0filter[0], RFX0checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF0_2textBox, ref Rx0filter[1], RFX0checkBox.Checked);
          read11or29bitHexNumber(CANBUSmaskRFX1textBox, ref Rx1mask, RFX1checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF1_1textBox, ref Rx1filter[0], RFX1checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF1_2textBox, ref Rx1filter[1], RFX1checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF1_3textBox, ref Rx1filter[2], RFX1checkBox.Checked);
          read11or29bitHexNumber(CANBUSfilterRXF1_4textBox, ref Rx1filter[3], RFX1checkBox.Checked);

      }

      private void RTRcheckBox_CheckedChanged(object sender, EventArgs e)
      {
          if (RTRcheckBox.Checked) canbusMessageTextBox.Enabled = false; else canbusMessageTextBox.Enabled = true;

      }

      private void RFX1checkBox_CheckedChanged(object sender, EventArgs e)
      {
          if (RFX1checkBox.Checked) CANBUSmaskRFX1textBox.Text = "1fffffff";
          else CANBUSmaskRFX1textBox.Text = "7ff";
          CANBUSfilterRXF1_1textBox.Text = "0"; CANBUSfilterRXF1_2textBox.Text = "0";
          CANBUSfilterRXF1_3textBox.Text = "0"; CANBUSfilterRXF1_4textBox.Text = "0"; 

      }

      private void RFX0checkBox_CheckedChanged(object sender, EventArgs e)
      {
          if (RFX0checkBox.Checked) CANBUSmaskRFX0textBox.Text = "1fffffff";
          else CANBUSmaskRFX0textBox.Text = "7ff";
          CANBUSfilterRXF0_1textBox.Text = "0"; CANBUSfilterRXF0_2textBox.Text = "0"; 

      }
    }
}
