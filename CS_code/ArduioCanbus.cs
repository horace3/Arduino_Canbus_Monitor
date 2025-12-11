// to check for CLS compliance add [assembly: CLSCompliant(true)]to AssemblyInfo.cs


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO.Ports;

using PIC24mechatronicsCsharp;

namespace USB_PIC24_MECHATRONICS_DATA_DLL
{
    internal class PIC24_mechatronics
    { 
         /* CANBUS functions */

        /** read CANBUS setup parameters
            \param canbusMask 29-bit canbus mask
            \param canbusFilter 29-bit canbus receive filter
            \param CANBUSspeed - canbus baud rate 125, 250 or 500kbs
        */
        //  [DllImport("PIC24mechatronics.dll")]
        public static bool CANBUSreadSetup(ref UInt32 canbusMask, ref UInt32 canbusFilter, ref int canbusSpeed)
        {
             return false;
        }

        // convert UInt16 to two bytes for transmission over USB
        static void UInt16_to_Byte(UInt16 i, ref Byte[] d, int index)
        {
            d[index + 1] = Convert.ToByte((i >> 8) & 0xff); d[index] = Convert.ToByte(i & 0xFF);
        }

        // convert UInt32 to four bytes for transmission over USB
        static void UInt32_to_Byte(UInt32 i, ref Byte[] d, int index)
        {
            d[index] = Convert.ToByte(i & 0xFF);
            d[index + 1] = Convert.ToByte((i >> 8) & 0xff);
            d[index + 2] = Convert.ToByte((i >> 16) & 0xff);
            d[index + 3] = Convert.ToByte((i >> 24) & 0xff);
        }

 
        /** setup CANBUS parameters
	    \param Rx0extended if 1 use extended filters and mask else standard for receiver 0
	    \param Rx0mask 11bit or 29-bit canbus mask for receiver 0
	    \param Rx0filter[] 2 of 11-bit or  29-bit canbus receive filters for receiver 0
	    \param Rx1extended if 1 use extended filters and mask else standard for receiver 1
	    \param Rx1mask 11bit or 29-bit canbus mask for receiver 1
	    \param Rx1filter[] 4 of 11-bit or  29-bit canbus receive filters for receiver 1
	    \param CANBUSspeed - canbus baud rate 125, 250 or 500kbs
        */
        // [DllImport("PIC24mechatronics.dll")]
        enum CANcommand : byte
        {
            CANBUSspeed = (byte)'0', CANBUStransmit, Rx0mask, Rx0filter1, Rx0filter2,
            Rx1mask, Rx1filter3, Rx1filter4, Rx1filter5, Rx1filter6
        };
 
        public static void CANBUSsetup(SerialPort serialPort1, UInt16 Rx0extended, UInt32 Rx0mask, UInt32[] Rx0filter,
                  UInt16 Rx1extended, UInt32 Rx1mask, UInt32[] Rx1filter, UInt16 CANBUSspeed)//UInt32 canbusMask, UInt32 canbusFilter, int canbusSpeed);
        {
            Console.WriteLine("CANBUSsetup");
            serialPort1.Write((char)CANcommand.CANBUSspeed + " " + CANBUSspeed.ToString() + Environment.NewLine);
            serialPort1.Write((char)CANcommand.Rx0mask + " " + +Rx0extended + " " + Rx0mask.ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx1mask + " " + +Rx1extended + " " + Rx1mask.ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx0filter1 + " " + +Rx0extended + " " + Rx0filter[0].ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx0filter2 + " " + +Rx0extended + " " + Rx0filter[1].ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx1filter3 + " " + +Rx1extended + " " + Rx1filter[0].ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx1filter4 + " " + +Rx1extended + " " + Rx1filter[1].ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx1filter5 + " " + +Rx1extended + " " + Rx1filter[2].ToString() + "\n");
            serialPort1.Write((char)CANcommand.Rx1filter6 + " " + +Rx1extended + " " + Rx1filter[3].ToString() + "\n");
        }

        /** transmit a CANBUS message
	    \param extendedID - if non 0 using 29-bit ID else 11-bit
	    \param canbusOutputID 11-bit of 29-bit canbus message ID
	    \param RTR if 1 sending RTR else data
	    \param message[] 8 bytes of data to transmit (Not sent wth RTR)
       */
        // [DllImport("PIC24mechatronics.dll")]
        public static void CANBUStransmit(SerialPort serialPort1, int extendedID, UInt32 canbusOutputID, int RTR, int[] message)
        {
            serialPort1.Write((char)CANcommand.CANBUStransmit + " " + canbusOutputID.ToString()
                        + " " + extendedID.ToString() + " " + RTR.ToString()
                        + " " + message[0].ToString() + " " + message[1].ToString() + " " + message[2].ToString() + " " + message[3].ToString()
                        + " " + message[4].ToString() + " " + message[5].ToString() + " " + message[6].ToString() + " " + message[7].ToString() + Environment.NewLine);
        }

        /* check if CANBUS message has been received 
        \param receivedData 0 nothing received, 1 standard frame received, 2 extended frame received
        \param canbusReceivedID 29-bit receive ID if read is sucessful
        \param RTR = 1 if RTR else 0 if data message
        \param canbusReceivedMessage[8] message recived if sucessful (empty if RTR)
        \return  0 if it fails, i.e. if the board has been disconnected
        \return 1 if target board and software version OK
        \return 2 if target board and/or software version error 
        */
        //  [DllImport("PIC24mechatronics.dll")]
        public static bool CANBUSreceived(ref int receivedData, ref UInt32 canbusReceivedID, ref int RTR, ref int[] message)
        {
            return false;
        }
    }
}
