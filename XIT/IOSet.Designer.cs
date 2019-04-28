namespace XIT
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.checkBoxOut5 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut9 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut6 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut10 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut15 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut7 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut12 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut2 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut13 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut4 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut14 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOut11 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut8 = new System.Windows.Forms.CheckBox();
            this.checkBoxOut3 = new System.Windows.Forms.CheckBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonAhead = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComSet = new System.Windows.Forms.ToolStripDropDownButton();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonStay = new System.Windows.Forms.Button();
            this.textBoxIORec = new System.Windows.Forms.TextBox();
            this.labelIORec = new System.Windows.Forms.Label();
            this.labelIOSend = new System.Windows.Forms.Label();
            this.textBoxIOSend = new System.Windows.Forms.TextBox();
            this.buttonClean = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSerialPort
            // 
            this.spSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // checkBoxOut5
            // 
            this.checkBoxOut5.AutoSize = true;
            this.checkBoxOut5.Location = new System.Drawing.Point(18, 185);
            this.checkBoxOut5.Name = "checkBoxOut5";
            this.checkBoxOut5.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut5.TabIndex = 2;
            this.checkBoxOut5.TabStop = false;
            this.checkBoxOut5.Text = "OUT5";
            this.checkBoxOut5.UseVisualStyleBackColor = true;
            this.checkBoxOut5.CheckedChanged += new System.EventHandler(this.checkBoxOut5_CheckedChanged);
            // 
            // checkBoxOut9
            // 
            this.checkBoxOut9.AutoSize = true;
            this.checkBoxOut9.Location = new System.Drawing.Point(111, 146);
            this.checkBoxOut9.Name = "checkBoxOut9";
            this.checkBoxOut9.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut9.TabIndex = 3;
            this.checkBoxOut9.TabStop = false;
            this.checkBoxOut9.Text = "OUT9";
            this.checkBoxOut9.UseVisualStyleBackColor = true;
            this.checkBoxOut9.CheckedChanged += new System.EventHandler(this.checkBoxOut9_CheckedChanged);
            // 
            // checkBoxOut6
            // 
            this.checkBoxOut6.AutoSize = true;
            this.checkBoxOut6.Location = new System.Drawing.Point(111, 29);
            this.checkBoxOut6.Name = "checkBoxOut6";
            this.checkBoxOut6.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut6.TabIndex = 6;
            this.checkBoxOut6.TabStop = false;
            this.checkBoxOut6.Text = "OUT6";
            this.checkBoxOut6.UseVisualStyleBackColor = true;
            this.checkBoxOut6.CheckedChanged += new System.EventHandler(this.checkBoxOut6_CheckedChanged);
            // 
            // checkBoxOut10
            // 
            this.checkBoxOut10.AutoSize = true;
            this.checkBoxOut10.Location = new System.Drawing.Point(111, 185);
            this.checkBoxOut10.Name = "checkBoxOut10";
            this.checkBoxOut10.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut10.TabIndex = 7;
            this.checkBoxOut10.TabStop = false;
            this.checkBoxOut10.Text = "OUT10";
            this.checkBoxOut10.UseVisualStyleBackColor = true;
            this.checkBoxOut10.CheckedChanged += new System.EventHandler(this.checkBoxOut10_CheckedChanged);
            // 
            // checkBoxOut15
            // 
            this.checkBoxOut15.AutoSize = true;
            this.checkBoxOut15.Location = new System.Drawing.Point(204, 185);
            this.checkBoxOut15.Name = "checkBoxOut15";
            this.checkBoxOut15.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut15.TabIndex = 8;
            this.checkBoxOut15.TabStop = false;
            this.checkBoxOut15.Text = "OUT15";
            this.checkBoxOut15.UseVisualStyleBackColor = true;
            this.checkBoxOut15.CheckedChanged += new System.EventHandler(this.checkBoxOut15_CheckedChanged);
            // 
            // checkBoxOut7
            // 
            this.checkBoxOut7.AutoSize = true;
            this.checkBoxOut7.Location = new System.Drawing.Point(111, 68);
            this.checkBoxOut7.Name = "checkBoxOut7";
            this.checkBoxOut7.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut7.TabIndex = 10;
            this.checkBoxOut7.TabStop = false;
            this.checkBoxOut7.Text = "OUT7";
            this.checkBoxOut7.UseVisualStyleBackColor = true;
            this.checkBoxOut7.CheckedChanged += new System.EventHandler(this.checkBoxOut7_CheckedChanged);
            // 
            // checkBoxOut12
            // 
            this.checkBoxOut12.AutoSize = true;
            this.checkBoxOut12.Location = new System.Drawing.Point(204, 68);
            this.checkBoxOut12.Name = "checkBoxOut12";
            this.checkBoxOut12.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut12.TabIndex = 12;
            this.checkBoxOut12.TabStop = false;
            this.checkBoxOut12.Text = "OUT12";
            this.checkBoxOut12.UseVisualStyleBackColor = true;
            this.checkBoxOut12.CheckedChanged += new System.EventHandler(this.checkBoxOut12_CheckedChanged);
            // 
            // checkBoxOut1
            // 
            this.checkBoxOut1.AutoSize = true;
            this.checkBoxOut1.Location = new System.Drawing.Point(18, 29);
            this.checkBoxOut1.Name = "checkBoxOut1";
            this.checkBoxOut1.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut1.TabIndex = 14;
            this.checkBoxOut1.TabStop = false;
            this.checkBoxOut1.Text = "OUT1";
            this.checkBoxOut1.UseVisualStyleBackColor = true;
            this.checkBoxOut1.CheckedChanged += new System.EventHandler(this.checkBoxOut1_CheckedChanged);
            // 
            // checkBoxOut2
            // 
            this.checkBoxOut2.AutoSize = true;
            this.checkBoxOut2.Location = new System.Drawing.Point(18, 68);
            this.checkBoxOut2.Name = "checkBoxOut2";
            this.checkBoxOut2.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut2.TabIndex = 18;
            this.checkBoxOut2.TabStop = false;
            this.checkBoxOut2.Text = "OUT2";
            this.checkBoxOut2.UseVisualStyleBackColor = true;
            this.checkBoxOut2.CheckedChanged += new System.EventHandler(this.checkBoxOut2_CheckedChanged);
            // 
            // checkBoxOut13
            // 
            this.checkBoxOut13.AutoSize = true;
            this.checkBoxOut13.Location = new System.Drawing.Point(204, 107);
            this.checkBoxOut13.Name = "checkBoxOut13";
            this.checkBoxOut13.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut13.TabIndex = 20;
            this.checkBoxOut13.TabStop = false;
            this.checkBoxOut13.Text = "OUT13";
            this.checkBoxOut13.UseVisualStyleBackColor = true;
            this.checkBoxOut13.CheckedChanged += new System.EventHandler(this.checkBoxOut13_CheckedChanged);
            // 
            // checkBoxOut4
            // 
            this.checkBoxOut4.AutoSize = true;
            this.checkBoxOut4.Location = new System.Drawing.Point(18, 146);
            this.checkBoxOut4.Name = "checkBoxOut4";
            this.checkBoxOut4.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut4.TabIndex = 21;
            this.checkBoxOut4.TabStop = false;
            this.checkBoxOut4.Text = "OUT4";
            this.checkBoxOut4.UseVisualStyleBackColor = true;
            this.checkBoxOut4.CheckedChanged += new System.EventHandler(this.checkBoxOut4_CheckedChanged);
            // 
            // checkBoxOut14
            // 
            this.checkBoxOut14.AutoSize = true;
            this.checkBoxOut14.Location = new System.Drawing.Point(204, 146);
            this.checkBoxOut14.Name = "checkBoxOut14";
            this.checkBoxOut14.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut14.TabIndex = 23;
            this.checkBoxOut14.TabStop = false;
            this.checkBoxOut14.Text = "OUT14";
            this.checkBoxOut14.UseVisualStyleBackColor = true;
            this.checkBoxOut14.CheckedChanged += new System.EventHandler(this.checkBoxOut14_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxOut11);
            this.groupBox1.Controls.Add(this.checkBoxOut1);
            this.groupBox1.Controls.Add(this.checkBoxOut8);
            this.groupBox1.Controls.Add(this.checkBoxOut2);
            this.groupBox1.Controls.Add(this.checkBoxOut3);
            this.groupBox1.Controls.Add(this.checkBoxOut4);
            this.groupBox1.Controls.Add(this.checkBoxOut14);
            this.groupBox1.Controls.Add(this.checkBoxOut13);
            this.groupBox1.Controls.Add(this.checkBoxOut12);
            this.groupBox1.Controls.Add(this.checkBoxOut7);
            this.groupBox1.Controls.Add(this.checkBoxOut15);
            this.groupBox1.Controls.Add(this.checkBoxOut10);
            this.groupBox1.Controls.Add(this.checkBoxOut6);
            this.groupBox1.Controls.Add(this.checkBoxOut9);
            this.groupBox1.Controls.Add(this.checkBoxOut5);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(341, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 232);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出控制口";
            // 
            // checkBoxOut11
            // 
            this.checkBoxOut11.AutoSize = true;
            this.checkBoxOut11.Location = new System.Drawing.Point(204, 29);
            this.checkBoxOut11.Name = "checkBoxOut11";
            this.checkBoxOut11.Size = new System.Drawing.Size(73, 24);
            this.checkBoxOut11.TabIndex = 33;
            this.checkBoxOut11.Text = "OUT11";
            this.checkBoxOut11.UseVisualStyleBackColor = true;
            this.checkBoxOut11.CheckedChanged += new System.EventHandler(this.checkBoxOut11_CheckedChanged);
            // 
            // checkBoxOut8
            // 
            this.checkBoxOut8.AutoSize = true;
            this.checkBoxOut8.Location = new System.Drawing.Point(111, 107);
            this.checkBoxOut8.Name = "checkBoxOut8";
            this.checkBoxOut8.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut8.TabIndex = 27;
            this.checkBoxOut8.TabStop = false;
            this.checkBoxOut8.Text = "OUT8";
            this.checkBoxOut8.UseVisualStyleBackColor = true;
            this.checkBoxOut8.CheckedChanged += new System.EventHandler(this.checkBoxOut8_CheckedChanged);
            // 
            // checkBoxOut3
            // 
            this.checkBoxOut3.AutoSize = true;
            this.checkBoxOut3.Location = new System.Drawing.Point(18, 107);
            this.checkBoxOut3.Name = "checkBoxOut3";
            this.checkBoxOut3.Size = new System.Drawing.Size(65, 24);
            this.checkBoxOut3.TabIndex = 26;
            this.checkBoxOut3.TabStop = false;
            this.checkBoxOut3.Text = "OUT3";
            this.checkBoxOut3.UseVisualStyleBackColor = true;
            this.checkBoxOut3.CheckedChanged += new System.EventHandler(this.checkBoxOut3_CheckedChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonBack.Location = new System.Drawing.Point(132, 171);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(78, 26);
            this.buttonBack.TabIndex = 27;
            this.buttonBack.Text = "后退";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRight.Location = new System.Drawing.Point(228, 113);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(78, 26);
            this.buttonRight.TabIndex = 28;
            this.buttonRight.Text = "右转";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStop.Location = new System.Drawing.Point(132, 113);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(78, 26);
            this.buttonStop.TabIndex = 29;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonAhead
            // 
            this.buttonAhead.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonAhead.Location = new System.Drawing.Point(132, 55);
            this.buttonAhead.Name = "buttonAhead";
            this.buttonAhead.Size = new System.Drawing.Size(78, 26);
            this.buttonAhead.TabIndex = 28;
            this.buttonAhead.Text = "前进";
            this.buttonAhead.UseVisualStyleBackColor = true;
            this.buttonAhead.Click += new System.EventHandler(this.buttonAhead_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLeft.Location = new System.Drawing.Point(36, 113);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(78, 26);
            this.buttonLeft.TabIndex = 38;
            this.buttonLeft.Text = "左转";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(280, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 41;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(81, 25);
            this.toolStrip1.TabIndex = 42;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComSet
            // 
            this.toolStripComSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripComSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripComSet.Image")));
            this.toolStripComSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripComSet.Name = "toolStripComSet";
            this.toolStripComSet.Size = new System.Drawing.Size(69, 22);
            this.toolStripComSet.Text = "串口选择";
            this.toolStripComSet.MouseEnter += new System.EventHandler(this.RefreshComPort);
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonUp.Location = new System.Drawing.Point(36, 234);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(78, 26);
            this.buttonUp.TabIndex = 43;
            this.buttonUp.Text = "向上";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDown.Location = new System.Drawing.Point(36, 283);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(78, 26);
            this.buttonDown.TabIndex = 44;
            this.buttonDown.Text = "向下";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonStay
            // 
            this.buttonStay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonStay.Location = new System.Drawing.Point(36, 332);
            this.buttonStay.Name = "buttonStay";
            this.buttonStay.Size = new System.Drawing.Size(78, 26);
            this.buttonStay.TabIndex = 45;
            this.buttonStay.Text = "保持";
            this.buttonStay.UseVisualStyleBackColor = true;
            this.buttonStay.Click += new System.EventHandler(this.buttonStay_Click);
            // 
            // textBoxIORec
            // 
            this.textBoxIORec.AllowDrop = true;
            this.textBoxIORec.BackColor = System.Drawing.Color.Thistle;
            this.textBoxIORec.Location = new System.Drawing.Point(371, 315);
            this.textBoxIORec.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBoxIORec.Multiline = true;
            this.textBoxIORec.Name = "textBoxIORec";
            this.textBoxIORec.Size = new System.Drawing.Size(296, 75);
            this.textBoxIORec.TabIndex = 46;
            this.textBoxIORec.TabStop = false;
            // 
            // labelIORec
            // 
            this.labelIORec.AutoSize = true;
            this.labelIORec.Location = new System.Drawing.Point(336, 318);
            this.labelIORec.Name = "labelIORec";
            this.labelIORec.Size = new System.Drawing.Size(29, 12);
            this.labelIORec.TabIndex = 47;
            this.labelIORec.Text = "接收";
            // 
            // labelIOSend
            // 
            this.labelIOSend.AutoSize = true;
            this.labelIOSend.Location = new System.Drawing.Point(339, 237);
            this.labelIOSend.Name = "labelIOSend";
            this.labelIOSend.Size = new System.Drawing.Size(29, 12);
            this.labelIOSend.TabIndex = 48;
            this.labelIOSend.Text = "发送";
            // 
            // textBoxIOSend
            // 
            this.textBoxIOSend.AllowDrop = true;
            this.textBoxIOSend.BackColor = System.Drawing.Color.Thistle;
            this.textBoxIOSend.Location = new System.Drawing.Point(371, 234);
            this.textBoxIOSend.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.textBoxIOSend.Multiline = true;
            this.textBoxIOSend.Name = "textBoxIOSend";
            this.textBoxIOSend.Size = new System.Drawing.Size(296, 75);
            this.textBoxIOSend.TabIndex = 49;
            this.textBoxIOSend.TabStop = false;
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(371, 396);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(124, 23);
            this.buttonClean.TabIndex = 50;
            this.buttonClean.Text = "清空";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 419);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.labelIOSend);
            this.Controls.Add(this.labelIORec);
            this.Controls.Add(this.textBoxIORec);
            this.Controls.Add(this.buttonStay);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonAhead);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxIOSend);
            this.Name = "Form5";
            this.Text = "IO对话框";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxOut5;
        private System.Windows.Forms.CheckBox checkBoxOut9;
        private System.Windows.Forms.CheckBox checkBoxOut6;
        private System.Windows.Forms.CheckBox checkBoxOut10;
        private System.Windows.Forms.CheckBox checkBoxOut15;
        private System.Windows.Forms.CheckBox checkBoxOut7;
        private System.Windows.Forms.CheckBox checkBoxOut12;
        private System.Windows.Forms.CheckBox checkBoxOut1;
        private System.Windows.Forms.CheckBox checkBoxOut2;
        private System.Windows.Forms.CheckBox checkBoxOut13;
        private System.Windows.Forms.CheckBox checkBoxOut4;
        private System.Windows.Forms.CheckBox checkBoxOut14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.CheckBox checkBoxOut3;
        private System.Windows.Forms.CheckBox checkBoxOut8;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonAhead;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOut11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripComSet;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonStay;
        protected System.Windows.Forms.TextBox textBoxIORec;
        private System.Windows.Forms.Label labelIORec;
        private System.Windows.Forms.Label labelIOSend;
        protected System.Windows.Forms.TextBox textBoxIOSend;
        private System.Windows.Forms.Button buttonClean;
    }
}