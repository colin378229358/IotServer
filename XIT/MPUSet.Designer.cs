namespace XIT
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.spSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComSet = new System.Windows.Forms.ToolStripDropDownButton();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spSerialPort
            // 
            this.spSerialPort.BaudRate = 115200;
            this.spSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComSet});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 25);
            this.toolStrip1.TabIndex = 0;
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
            // timer3
            // 
            this.timer3.Interval = 200;
            this.timer3.Tick += new System.EventHandler(this.DisplayRefresh);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(113, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "JY901数据采集显示";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label35.Location = new System.Drawing.Point(26, 55);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 348);
            this.label35.TabIndex = 7;
            this.label35.Text = "系统时间：\r\n片上时间：\r\n\r\n相对时间：\r\n\r\nx轴加速度：\r\ny轴加速度：\r\nz轴加速度：\r\n\r\nx轴角速度：\r\ny轴角速度：\r\nz轴角速度：\r\n\r\nx轴角度" +
    "：\r\ny轴角度：\r\nz轴角度：\r\n\r\nx轴磁场：\r\ny轴磁场：\r\nz轴磁场：\r\n\r\n温度：\r\n气压：\r\n高度：\r\n\r\n经度：\r\n纬度：\r\n地速：\r\n航向：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label34.Location = new System.Drawing.Point(114, 55);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 12);
            this.label34.TabIndex = 8;
            this.label34.Text = "NoData";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 432);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 450);
            this.Name = "Form2";
            this.RightToLeftLayout = true;
            this.Text = "MPU对话框";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripDropDownButton toolStripComSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label35;
        private System.IO.Ports.SerialPort spSerialPort;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label34;
    }
}