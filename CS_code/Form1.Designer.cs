namespace PIC24mechatronicsCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CANBUSmaskRFX1textBox = new System.Windows.Forms.TextBox();
            this.CANBUSfilterRXF1_4textBox = new System.Windows.Forms.TextBox();
            this.CANBUSfilterRXF1_3textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.RFX1checkBox = new System.Windows.Forms.CheckBox();
            this.CANBUSfilterRXF1_2textBox = new System.Windows.Forms.TextBox();
            this.CANBUSfilterRXF1_1textBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.CANBUSfilterRXF0_2textBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RFX0checkBox = new System.Windows.Forms.CheckBox();
            this.CANBUSfilterRXF0_1textBox = new System.Windows.Forms.TextBox();
            this.CANBUSmaskRFX0textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.setCanbus = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button500 = new System.Windows.Forms.RadioButton();
            this.button250 = new System.Windows.Forms.RadioButton();
            this.button125 = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.RTRcheckBox = new System.Windows.Forms.CheckBox();
            this.extended29bitIDcheckBox = new System.Windows.Forms.CheckBox();
            this.transmitButton = new System.Windows.Forms.Button();
            this.canbusMessageTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.canbusIDtextBox = new System.Windows.Forms.TextBox();
            this.canbusReceivedMessageTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.terminalTextBox = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 842);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1624, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(494, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Arduino UNO  Canbus Monitor V1.2";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Location = new System.Drawing.Point(16, 73);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(545, 628);
            this.panel5.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(187, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 29);
            this.label12.TabIndex = 9;
            this.label12.Text = "CANBUS";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.setCanbus);
            this.panel8.Location = new System.Drawing.Point(15, 119);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(449, 363);
            this.panel8.TabIndex = 8;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.CANBUSmaskRFX1textBox);
            this.panel10.Controls.Add(this.CANBUSfilterRXF1_4textBox);
            this.panel10.Controls.Add(this.CANBUSfilterRXF1_3textBox);
            this.panel10.Controls.Add(this.label21);
            this.panel10.Controls.Add(this.label20);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.RFX1checkBox);
            this.panel10.Controls.Add(this.CANBUSfilterRXF1_2textBox);
            this.panel10.Controls.Add(this.CANBUSfilterRXF1_1textBox);
            this.panel10.Controls.Add(this.label18);
            this.panel10.Controls.Add(this.label19);
            this.panel10.Location = new System.Drawing.Point(89, 155);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(341, 204);
            this.panel10.TabIndex = 8;
            // 
            // CANBUSmaskRFX1textBox
            // 
            this.CANBUSmaskRFX1textBox.Location = new System.Drawing.Point(172, 31);
            this.CANBUSmaskRFX1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSmaskRFX1textBox.Name = "CANBUSmaskRFX1textBox";
            this.CANBUSmaskRFX1textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSmaskRFX1textBox.TabIndex = 13;
            this.CANBUSmaskRFX1textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // CANBUSfilterRXF1_4textBox
            // 
            this.CANBUSfilterRXF1_4textBox.Location = new System.Drawing.Point(171, 154);
            this.CANBUSfilterRXF1_4textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF1_4textBox.Name = "CANBUSfilterRXF1_4textBox";
            this.CANBUSfilterRXF1_4textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF1_4textBox.TabIndex = 12;
            this.CANBUSfilterRXF1_4textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // CANBUSfilterRXF1_3textBox
            // 
            this.CANBUSfilterRXF1_3textBox.Location = new System.Drawing.Point(171, 122);
            this.CANBUSfilterRXF1_3textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF1_3textBox.Name = "CANBUSfilterRXF1_3textBox";
            this.CANBUSfilterRXF1_3textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF1_3textBox.TabIndex = 11;
            this.CANBUSfilterRXF1_3textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 158);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 16);
            this.label21.TabIndex = 10;
            this.label21.Text = "receiver 1 filter 4 (hex)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 126);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "receiver 1 filter 3 (hex)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 94);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(135, 16);
            this.label17.TabIndex = 7;
            this.label17.Text = "receiver 1 filter 2 (hex)";
            // 
            // RFX1checkBox
            // 
            this.RFX1checkBox.AutoSize = true;
            this.RFX1checkBox.Checked = true;
            this.RFX1checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RFX1checkBox.Location = new System.Drawing.Point(27, 10);
            this.RFX1checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.RFX1checkBox.Name = "RFX1checkBox";
            this.RFX1checkBox.Size = new System.Drawing.Size(280, 20);
            this.RFX1checkBox.TabIndex = 0;
            this.RFX1checkBox.Text = "extended 29-bit ID (else standard 11-bit ID)\r\n";
            this.RFX1checkBox.UseVisualStyleBackColor = true;
            this.RFX1checkBox.CheckedChanged += new System.EventHandler(this.RFX1checkBox_CheckedChanged);
            // 
            // CANBUSfilterRXF1_2textBox
            // 
            this.CANBUSfilterRXF1_2textBox.Location = new System.Drawing.Point(171, 90);
            this.CANBUSfilterRXF1_2textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF1_2textBox.Name = "CANBUSfilterRXF1_2textBox";
            this.CANBUSfilterRXF1_2textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF1_2textBox.TabIndex = 5;
            this.CANBUSfilterRXF1_2textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // CANBUSfilterRXF1_1textBox
            // 
            this.CANBUSfilterRXF1_1textBox.Location = new System.Drawing.Point(171, 60);
            this.CANBUSfilterRXF1_1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF1_1textBox.Name = "CANBUSfilterRXF1_1textBox";
            this.CANBUSfilterRXF1_1textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF1_1textBox.TabIndex = 6;
            this.CANBUSfilterRXF1_1textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 64);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 16);
            this.label18.TabIndex = 3;
            this.label18.Text = "receiver 1 filter 1 (hex)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 34);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(134, 16);
            this.label19.TabIndex = 4;
            this.label19.Text = "receiver 1 mask (hex)";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.CANBUSfilterRXF0_2textBox);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Controls.Add(this.RFX0checkBox);
            this.panel9.Controls.Add(this.CANBUSfilterRXF0_1textBox);
            this.panel9.Controls.Add(this.CANBUSmaskRFX0textBox);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Location = new System.Drawing.Point(89, 14);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(341, 123);
            this.panel9.TabIndex = 7;
            // 
            // CANBUSfilterRXF0_2textBox
            // 
            this.CANBUSfilterRXF0_2textBox.Location = new System.Drawing.Point(171, 90);
            this.CANBUSfilterRXF0_2textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF0_2textBox.Name = "CANBUSfilterRXF0_2textBox";
            this.CANBUSfilterRXF0_2textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF0_2textBox.TabIndex = 8;
            this.CANBUSfilterRXF0_2textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(4, 94);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "receiver 0 filter 2 (hex)";
            // 
            // RFX0checkBox
            // 
            this.RFX0checkBox.AutoSize = true;
            this.RFX0checkBox.Location = new System.Drawing.Point(27, 10);
            this.RFX0checkBox.Margin = new System.Windows.Forms.Padding(4);
            this.RFX0checkBox.Name = "RFX0checkBox";
            this.RFX0checkBox.Size = new System.Drawing.Size(280, 20);
            this.RFX0checkBox.TabIndex = 0;
            this.RFX0checkBox.Text = "extended 29-bit ID (else standard 11-bit ID)\r\n";
            this.RFX0checkBox.UseVisualStyleBackColor = true;
            this.RFX0checkBox.CheckedChanged += new System.EventHandler(this.RFX0checkBox_CheckedChanged);
            // 
            // CANBUSfilterRXF0_1textBox
            // 
            this.CANBUSfilterRXF0_1textBox.Location = new System.Drawing.Point(171, 60);
            this.CANBUSfilterRXF0_1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSfilterRXF0_1textBox.Name = "CANBUSfilterRXF0_1textBox";
            this.CANBUSfilterRXF0_1textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSfilterRXF0_1textBox.TabIndex = 5;
            this.CANBUSfilterRXF0_1textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // CANBUSmaskRFX0textBox
            // 
            this.CANBUSmaskRFX0textBox.Location = new System.Drawing.Point(171, 31);
            this.CANBUSmaskRFX0textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CANBUSmaskRFX0textBox.Name = "CANBUSmaskRFX0textBox";
            this.CANBUSmaskRFX0textBox.Size = new System.Drawing.Size(151, 22);
            this.CANBUSmaskRFX0textBox.TabIndex = 6;
            this.CANBUSmaskRFX0textBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 64);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "receiver 0 filter 1 (hex)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "receiver 0 mask (hex)";
            // 
            // setCanbus
            // 
            this.setCanbus.Location = new System.Drawing.Point(4, 94);
            this.setCanbus.Margin = new System.Windows.Forms.Padding(4);
            this.setCanbus.Name = "setCanbus";
            this.setCanbus.Size = new System.Drawing.Size(73, 197);
            this.setCanbus.TabIndex = 2;
            this.setCanbus.Text = "set ";
            this.setCanbus.UseVisualStyleBackColor = true;
            this.setCanbus.Click += new System.EventHandler(this.setCanbus_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Location = new System.Drawing.Point(71, 48);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(358, 56);
            this.panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button500);
            this.groupBox1.Controls.Add(this.button250);
            this.groupBox1.Controls.Add(this.button125);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(340, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // button500
            // 
            this.button500.AutoSize = true;
            this.button500.Location = new System.Drawing.Point(247, 16);
            this.button500.Margin = new System.Windows.Forms.Padding(4);
            this.button500.Name = "button500";
            this.button500.Size = new System.Drawing.Size(71, 20);
            this.button500.TabIndex = 3;
            this.button500.Text = "500kbs";
            this.button500.UseVisualStyleBackColor = true;
            this.button500.CheckedChanged += new System.EventHandler(this.setCanbus_Click);
            // 
            // button250
            // 
            this.button250.AutoSize = true;
            this.button250.Checked = true;
            this.button250.Location = new System.Drawing.Point(159, 17);
            this.button250.Margin = new System.Windows.Forms.Padding(4);
            this.button250.Name = "button250";
            this.button250.Size = new System.Drawing.Size(71, 20);
            this.button250.TabIndex = 2;
            this.button250.TabStop = true;
            this.button250.Text = "250kbs";
            this.button250.UseVisualStyleBackColor = true;
            this.button250.CheckedChanged += new System.EventHandler(this.setCanbus_Click);
            // 
            // button125
            // 
            this.button125.AutoSize = true;
            this.button125.Location = new System.Drawing.Point(71, 16);
            this.button125.Margin = new System.Windows.Forms.Padding(4);
            this.button125.Name = "button125";
            this.button125.Size = new System.Drawing.Size(71, 20);
            this.button125.TabIndex = 1;
            this.button125.Text = "125kbs";
            this.button125.UseVisualStyleBackColor = true;
            this.button125.CheckedChanged += new System.EventHandler(this.setCanbus_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 17);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "speed";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.RTRcheckBox);
            this.panel7.Controls.Add(this.extended29bitIDcheckBox);
            this.panel7.Controls.Add(this.transmitButton);
            this.panel7.Controls.Add(this.canbusMessageTextBox);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.canbusIDtextBox);
            this.panel7.Location = new System.Drawing.Point(37, 502);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(449, 105);
            this.panel7.TabIndex = 7;
            // 
            // RTRcheckBox
            // 
            this.RTRcheckBox.AutoSize = true;
            this.RTRcheckBox.Location = new System.Drawing.Point(297, 9);
            this.RTRcheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.RTRcheckBox.Name = "RTRcheckBox";
            this.RTRcheckBox.Size = new System.Drawing.Size(58, 20);
            this.RTRcheckBox.TabIndex = 8;
            this.RTRcheckBox.Text = "RTR";
            this.RTRcheckBox.UseVisualStyleBackColor = true;
            this.RTRcheckBox.CheckedChanged += new System.EventHandler(this.RTRcheckBox_CheckedChanged);
            // 
            // extended29bitIDcheckBox
            // 
            this.extended29bitIDcheckBox.AutoSize = true;
            this.extended29bitIDcheckBox.Location = new System.Drawing.Point(105, 10);
            this.extended29bitIDcheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.extended29bitIDcheckBox.Name = "extended29bitIDcheckBox";
            this.extended29bitIDcheckBox.Size = new System.Drawing.Size(136, 20);
            this.extended29bitIDcheckBox.TabIndex = 7;
            this.extended29bitIDcheckBox.Text = "Extended 29 bit ID";
            this.extended29bitIDcheckBox.UseVisualStyleBackColor = true;
            // 
            // transmitButton
            // 
            this.transmitButton.Location = new System.Drawing.Point(11, 50);
            this.transmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.transmitButton.Name = "transmitButton";
            this.transmitButton.Size = new System.Drawing.Size(133, 28);
            this.transmitButton.TabIndex = 1;
            this.transmitButton.Text = "transmit message";
            this.transmitButton.UseVisualStyleBackColor = true;
            this.transmitButton.Click += new System.EventHandler(this.transmitButton_Click);
            // 
            // canbusMessageTextBox
            // 
            this.canbusMessageTextBox.Location = new System.Drawing.Point(276, 69);
            this.canbusMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.canbusMessageTextBox.Name = "canbusMessageTextBox";
            this.canbusMessageTextBox.Size = new System.Drawing.Size(148, 22);
            this.canbusMessageTextBox.TabIndex = 6;
            this.canbusMessageTextBox.TextChanged += new System.EventHandler(this.canbisMessageTextBox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "message ID (hex)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 73);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "message (hex)";
            // 
            // canbusIDtextBox
            // 
            this.canbusIDtextBox.Location = new System.Drawing.Point(276, 37);
            this.canbusIDtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.canbusIDtextBox.Name = "canbusIDtextBox";
            this.canbusIDtextBox.Size = new System.Drawing.Size(148, 22);
            this.canbusIDtextBox.TabIndex = 5;
            this.canbusIDtextBox.TextChanged += new System.EventHandler(this.canbusTextBox_TextChanged);
            // 
            // canbusReceivedMessageTextBox
            // 
            this.canbusReceivedMessageTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canbusReceivedMessageTextBox.Location = new System.Drawing.Point(612, 92);
            this.canbusReceivedMessageTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.canbusReceivedMessageTextBox.Multiline = true;
            this.canbusReceivedMessageTextBox.Name = "canbusReceivedMessageTextBox";
            this.canbusReceivedMessageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.canbusReceivedMessageTextBox.Size = new System.Drawing.Size(481, 608);
            this.canbusReceivedMessageTextBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(715, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "received and transmitted  messages";
            // 
            // terminalTextBox
            // 
            this.terminalTextBox.Location = new System.Drawing.Point(1131, 94);
            this.terminalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.terminalTextBox.Multiline = true;
            this.terminalTextBox.Name = "terminalTextBox";
            this.terminalTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.terminalTextBox.Size = new System.Drawing.Size(457, 587);
            this.terminalTextBox.TabIndex = 18;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM19";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1251, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "serial data received";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1624, 868);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.terminalTextBox);
            this.Controls.Add(this.canbusReceivedMessageTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "UNO Canbus monitor V1.2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button setCanbus;
        private System.Windows.Forms.Button transmitButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox canbusMessageTextBox;
        private System.Windows.Forms.TextBox canbusIDtextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox canbusReceivedMessageTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox CANBUSfilterRXF0_1textBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CANBUSmaskRFX0textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton button500;
        private System.Windows.Forms.RadioButton button250;
        private System.Windows.Forms.RadioButton button125;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox RTRcheckBox;
        private System.Windows.Forms.CheckBox extended29bitIDcheckBox;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox RFX0checkBox;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox RFX1checkBox;
        private System.Windows.Forms.TextBox CANBUSfilterRXF1_2textBox;
        private System.Windows.Forms.TextBox CANBUSfilterRXF1_1textBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox CANBUSfilterRXF0_2textBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CANBUSfilterRXF1_3textBox;
        private System.Windows.Forms.TextBox CANBUSfilterRXF1_4textBox;
        private System.Windows.Forms.TextBox CANBUSmaskRFX1textBox;
        private System.Windows.Forms.TextBox terminalTextBox;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
    }
}

