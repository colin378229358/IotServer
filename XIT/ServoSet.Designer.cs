namespace XIT
{
    partial class FormServo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServo));
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStrip = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComSelect = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComSet = new System.Windows.Forms.ToolStripDropDownButton();
            this.textBoxServoSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServoRec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClr = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonMotorP = new System.Windows.Forms.Button();
            this.textBoxPlusP = new System.Windows.Forms.TextBox();
            this.buttonMotorN = new System.Windows.Forms.Button();
            this.textBoxPlusN = new System.Windows.Forms.TextBox();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSerialPort
            // 
            this.spSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip,
            this.toolStripComSelect,
            this.toolStripComSet});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(757, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStrip
            // 
            this.toolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip.Image")));
            this.toolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(56, 22);
            this.toolStrip.Text = "串口选择";
            // 
            // toolStripComSelect
            // 
            this.toolStripComSelect.Name = "toolStripComSelect";
            this.toolStripComSelect.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripComSet
            // 
            this.toolStripComSet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripComSet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripComSet.Image")));
            this.toolStripComSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripComSet.Name = "toolStripComSet";
            this.toolStripComSet.Size = new System.Drawing.Size(29, 22);
            this.toolStripComSet.Text = "toolStripDropDownButton1";
            this.toolStripComSet.MouseEnter += new System.EventHandler(this.RefreshCom);
            // 
            // textBoxServoSend
            // 
            this.textBoxServoSend.Location = new System.Drawing.Point(37, 203);
            this.textBoxServoSend.Multiline = true;
            this.textBoxServoSend.Name = "textBoxServoSend";
            this.textBoxServoSend.Size = new System.Drawing.Size(708, 64);
            this.textBoxServoSend.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "发送";
            // 
            // textBoxServoRec
            // 
            this.textBoxServoRec.Location = new System.Drawing.Point(37, 285);
            this.textBoxServoRec.Multiline = true;
            this.textBoxServoRec.Name = "textBoxServoRec";
            this.textBoxServoRec.Size = new System.Drawing.Size(708, 67);
            this.textBoxServoRec.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "接收";
            // 
            // buttonClr
            // 
            this.buttonClr.Location = new System.Drawing.Point(676, 363);
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.Size = new System.Drawing.Size(75, 23);
            this.buttonClr.TabIndex = 6;
            this.buttonClr.Text = "清空";
            this.buttonClr.UseVisualStyleBackColor = true;
            this.buttonClr.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(12, 37);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(75, 23);
            this.buttonEnable.TabIndex = 7;
            this.buttonEnable.Text = "驱动使能";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonMotorP
            // 
            this.buttonMotorP.Location = new System.Drawing.Point(12, 78);
            this.buttonMotorP.Name = "buttonMotorP";
            this.buttonMotorP.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorP.TabIndex = 8;
            this.buttonMotorP.Text = "电机正转";
            this.buttonMotorP.UseVisualStyleBackColor = true;
            this.buttonMotorP.Click += new System.EventHandler(this.buttonMotorP_Click);
            // 
            // textBoxPlusP
            // 
            this.textBoxPlusP.Location = new System.Drawing.Point(103, 78);
            this.textBoxPlusP.Name = "textBoxPlusP";
            this.textBoxPlusP.Size = new System.Drawing.Size(75, 21);
            this.textBoxPlusP.TabIndex = 9;
            this.textBoxPlusP.Text = "1000";
            // 
            // buttonMotorN
            // 
            this.buttonMotorN.Location = new System.Drawing.Point(13, 118);
            this.buttonMotorN.Name = "buttonMotorN";
            this.buttonMotorN.Size = new System.Drawing.Size(75, 23);
            this.buttonMotorN.TabIndex = 10;
            this.buttonMotorN.Text = "电机反转";
            this.buttonMotorN.UseVisualStyleBackColor = true;
            this.buttonMotorN.Click += new System.EventHandler(this.buttonMotorN_Click);
            // 
            // textBoxPlusN
            // 
            this.textBoxPlusN.Location = new System.Drawing.Point(103, 119);
            this.textBoxPlusN.Name = "textBoxPlusN";
            this.textBoxPlusN.Size = new System.Drawing.Size(75, 21);
            this.textBoxPlusN.TabIndex = 11;
            this.textBoxPlusN.Text = "1000";
            // 
            // buttonDisable
            // 
            this.buttonDisable.Location = new System.Drawing.Point(103, 37);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(75, 23);
            this.buttonDisable.TabIndex = 12;
            this.buttonDisable.Text = "使能关闭";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // FormServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 398);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.textBoxPlusN);
            this.Controls.Add(this.buttonMotorN);
            this.Controls.Add(this.textBoxPlusP);
            this.Controls.Add(this.buttonMotorP);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxServoRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxServoSend);
            this.Controls.Add(this.toolStrip2);
            this.Name = "FormServo";
            this.Text = "TYServo";
            this.Load += new System.EventHandler(this.Servo_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripComSelect;
        private System.Windows.Forms.ToolStripLabel toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripComSet;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.TextBox textBoxServoSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServoRec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClr;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonMotorP;
        private System.Windows.Forms.TextBox textBoxPlusP;
        private System.Windows.Forms.Button buttonMotorN;
        private System.Windows.Forms.TextBox textBoxPlusN;
        private System.Windows.Forms.Button buttonDisable;
    }
}