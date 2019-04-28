using SuperSocket.SocketBase.Config;

namespace XIT
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.解锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上锁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GPRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZigbeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BluetoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.样本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图片生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.坐标生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RTK数据采集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.辅助选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MPUStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CameraStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备2关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设备3关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.错误代码过站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.联系方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort4 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMotor = new System.Windows.Forms.Button();
            this.btnVoltage = new System.Windows.Forms.Button();
            this.btnCoder = new System.Windows.Forms.Button();
            this.btnRpmUp = new System.Windows.Forms.Button();
            this.btnRpmDown = new System.Windows.Forms.Button();
            this.button_Back2 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonRight = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sendTextBox = new System.Windows.Forms.RichTextBox();
            this.receiveTextBox = new System.Windows.Forms.RichTextBox();
            this.timerMPU = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.样本ToolStripMenuItem,
            this.辅助选项ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登陆ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.解锁ToolStripMenuItem,
            this.上锁ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关闭ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.文件ToolStripMenuItem.Text = "文  件";
            // 
            // 登陆ToolStripMenuItem
            // 
            this.登陆ToolStripMenuItem.Name = "登陆ToolStripMenuItem";
            this.登陆ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Visible = false;
            // 
            // 解锁ToolStripMenuItem
            // 
            this.解锁ToolStripMenuItem.Name = "解锁ToolStripMenuItem";
            this.解锁ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.解锁ToolStripMenuItem.Text = "解锁";
            this.解锁ToolStripMenuItem.Click += new System.EventHandler(this.解锁ToolStripMenuItem_Click);
            // 
            // 上锁ToolStripMenuItem
            // 
            this.上锁ToolStripMenuItem.Name = "上锁ToolStripMenuItem";
            this.上锁ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.上锁ToolStripMenuItem.Text = "上锁";
            this.上锁ToolStripMenuItem.Click += new System.EventHandler(this.上锁ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem2.Text = "—";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IOToolStripMenuItem,
            this.DAToolStripMenuItem,
            this.MPUToolStripMenuItem,
            this.GPRSToolStripMenuItem,
            this.ZigbeeToolStripMenuItem,
            this.BluetoothToolStripMenuItem,
            this.ServoToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.设置ToolStripMenuItem.Text = "模块单元";
            // 
            // IOToolStripMenuItem
            // 
            this.IOToolStripMenuItem.Name = "IOToolStripMenuItem";
            this.IOToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.IOToolStripMenuItem.Text = "IO";
            this.IOToolStripMenuItem.Click += new System.EventHandler(this.IOToolStripMenuItem_Click);
            // 
            // DAToolStripMenuItem
            // 
            this.DAToolStripMenuItem.Name = "DAToolStripMenuItem";
            this.DAToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.DAToolStripMenuItem.Text = "DA";
            this.DAToolStripMenuItem.Click += new System.EventHandler(this.DAToolStripMenuItem_Click);
            // 
            // MPUToolStripMenuItem
            // 
            this.MPUToolStripMenuItem.Name = "MPUToolStripMenuItem";
            this.MPUToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.MPUToolStripMenuItem.Text = "MPU";
            this.MPUToolStripMenuItem.Click += new System.EventHandler(this.MPUToolStripMenuItem_Click);
            // 
            // GPRSToolStripMenuItem
            // 
            this.GPRSToolStripMenuItem.Name = "GPRSToolStripMenuItem";
            this.GPRSToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.GPRSToolStripMenuItem.Text = "GPRS";
            this.GPRSToolStripMenuItem.Click += new System.EventHandler(this.GPRSToolStripMenuItem_Click);
            // 
            // ZigbeeToolStripMenuItem
            // 
            this.ZigbeeToolStripMenuItem.Name = "ZigbeeToolStripMenuItem";
            this.ZigbeeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ZigbeeToolStripMenuItem.Text = "Zigbee";
            this.ZigbeeToolStripMenuItem.Click += new System.EventHandler(this.ZigbeeToolStripMenuItem_Click);
            // 
            // BluetoothToolStripMenuItem
            // 
            this.BluetoothToolStripMenuItem.Name = "BluetoothToolStripMenuItem";
            this.BluetoothToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.BluetoothToolStripMenuItem.Text = "Bluetooth";
            this.BluetoothToolStripMenuItem.Click += new System.EventHandler(this.BluetoothToolStripMenuItem_Click);
            // 
            // ServoToolStripMenuItem
            // 
            this.ServoToolStripMenuItem.Name = "ServoToolStripMenuItem";
            this.ServoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.ServoToolStripMenuItem.Text = "Servo";
            this.ServoToolStripMenuItem.Click += new System.EventHandler(this.ServoToolStripMenuItem_Click);
            // 
            // 样本ToolStripMenuItem
            // 
            this.样本ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图片生成ToolStripMenuItem,
            this.坐标生成ToolStripMenuItem,
            this.RTK数据采集ToolStripMenuItem});
            this.样本ToolStripMenuItem.Name = "样本ToolStripMenuItem";
            this.样本ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.样本ToolStripMenuItem.Text = "样  本";
            // 
            // 图片生成ToolStripMenuItem
            // 
            this.图片生成ToolStripMenuItem.Name = "图片生成ToolStripMenuItem";
            this.图片生成ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.图片生成ToolStripMenuItem.Tag = "";
            this.图片生成ToolStripMenuItem.Text = "图片采集";
            this.图片生成ToolStripMenuItem.Click += new System.EventHandler(this.图片生成ToolStripMenuItem_Click);
            // 
            // 坐标生成ToolStripMenuItem
            // 
            this.坐标生成ToolStripMenuItem.Name = "坐标生成ToolStripMenuItem";
            this.坐标生成ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.坐标生成ToolStripMenuItem.Text = "坐标采集";
            this.坐标生成ToolStripMenuItem.Click += new System.EventHandler(this.坐标生成ToolStripMenuItem_Click);
            // 
            // RTK数据采集ToolStripMenuItem
            // 
            this.RTK数据采集ToolStripMenuItem.Name = "RTK数据采集ToolStripMenuItem";
            this.RTK数据采集ToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.RTK数据采集ToolStripMenuItem.Text = "RTK数据采集";
            this.RTK数据采集ToolStripMenuItem.Click += new System.EventHandler(this.RTK数据采集ToolStripMenuItem_Click);
            // 
            // 辅助选项ToolStripMenuItem
            // 
            this.辅助选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MPUStartToolStripMenuItem,
            this.CameraStartToolStripMenuItem,
            this.设备2关机ToolStripMenuItem,
            this.设备3关机ToolStripMenuItem,
            this.错误代码过站ToolStripMenuItem});
            this.辅助选项ToolStripMenuItem.Name = "辅助选项ToolStripMenuItem";
            this.辅助选项ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.辅助选项ToolStripMenuItem.Text = "辅助选项";
            // 
            // MPUStartToolStripMenuItem
            // 
            this.MPUStartToolStripMenuItem.Name = "MPUStartToolStripMenuItem";
            this.MPUStartToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.MPUStartToolStripMenuItem.Text = "MPUStart";
            this.MPUStartToolStripMenuItem.Click += new System.EventHandler(this.MPUStartToolStripMenuItem_Click_1);
            // 
            // CameraStartToolStripMenuItem
            // 
            this.CameraStartToolStripMenuItem.Name = "CameraStartToolStripMenuItem";
            this.CameraStartToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.CameraStartToolStripMenuItem.Text = "CameraStart";
            this.CameraStartToolStripMenuItem.Click += new System.EventHandler(this.CameraStartToolStripMenuItem_Click_1);
            // 
            // 设备2关机ToolStripMenuItem
            // 
            this.设备2关机ToolStripMenuItem.Name = "设备2关机ToolStripMenuItem";
            this.设备2关机ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设备2关机ToolStripMenuItem.Text = "设备2关机";
            this.设备2关机ToolStripMenuItem.Click += new System.EventHandler(this.设备2关机ToolStripMenuItem_Click);
            // 
            // 设备3关机ToolStripMenuItem
            // 
            this.设备3关机ToolStripMenuItem.Name = "设备3关机ToolStripMenuItem";
            this.设备3关机ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.设备3关机ToolStripMenuItem.Text = "设备3关机";
            this.设备3关机ToolStripMenuItem.Click += new System.EventHandler(this.设备3关机ToolStripMenuItem_Click);
            // 
            // 错误代码过站ToolStripMenuItem
            // 
            this.错误代码过站ToolStripMenuItem.Name = "错误代码过站ToolStripMenuItem";
            this.错误代码过站ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.错误代码过站ToolStripMenuItem.Text = "错误代码过站";
            this.错误代码过站ToolStripMenuItem.Click += new System.EventHandler(this.错误代码过站ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.使用说明ToolStripMenuItem,
            this.联系方式ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.帮助ToolStripMenuItem.Text = "帮  助";
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 联系方式ToolStripMenuItem
            // 
            this.联系方式ToolStripMenuItem.Name = "联系方式ToolStripMenuItem";
            this.联系方式ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.联系方式ToolStripMenuItem.Text = "联系方式";
            this.联系方式ToolStripMenuItem.Click += new System.EventHandler(this.联系方式ToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // serialPort2
            // 
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived);
            // 
            // serialPort3
            // 
            this.serialPort3.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort3_DataReceived);
            // 
            // serialPort4
            // 
            this.serialPort4.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort4_DataReceived);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Ivory;
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.HideSelection = false;
            this.richTextBox1.Location = new System.Drawing.Point(274, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(260, 307);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 151);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ready";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(540, 198);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(120, 70);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "开始";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStop.Location = new System.Drawing.Point(667, 199);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(120, 70);
            this.buttonStop.TabIndex = 6;
            this.buttonStop.TabStop = false;
            this.buttonStop.Text = "停止";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(52, 21);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(230, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(52, 21);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(412, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(52, 21);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(594, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(52, 21);
            this.textBox4.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 17;
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(0, 0);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(75, 23);
            this.button_Left.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "测试数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "FAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "PASS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "良率";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_Left);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(80, 661);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 44);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Ivory;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Receive";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Ivory;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Send";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Ivory;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(540, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(247, 295);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.TabStop = false;
            // 
            // btnMotor
            // 
            this.btnMotor.Enabled = false;
            this.btnMotor.Font = new System.Drawing.Font("宋体", 15F);
            this.btnMotor.Location = new System.Drawing.Point(6, 98);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(69, 37);
            this.btnMotor.TabIndex = 23;
            this.btnMotor.TabStop = false;
            this.btnMotor.Text = "Motor";
            this.btnMotor.UseVisualStyleBackColor = true;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // btnVoltage
            // 
            this.btnVoltage.Enabled = false;
            this.btnVoltage.Font = new System.Drawing.Font("宋体", 15F);
            this.btnVoltage.Location = new System.Drawing.Point(6, 13);
            this.btnVoltage.Name = "btnVoltage";
            this.btnVoltage.Size = new System.Drawing.Size(69, 37);
            this.btnVoltage.TabIndex = 23;
            this.btnVoltage.TabStop = false;
            this.btnVoltage.Text = "Volta";
            this.btnVoltage.UseVisualStyleBackColor = true;
            this.btnVoltage.Click += new System.EventHandler(this.btnVoltage_Click);
            // 
            // btnCoder
            // 
            this.btnCoder.Enabled = false;
            this.btnCoder.Font = new System.Drawing.Font("宋体", 15F);
            this.btnCoder.Location = new System.Drawing.Point(6, 56);
            this.btnCoder.Name = "btnCoder";
            this.btnCoder.Size = new System.Drawing.Size(69, 37);
            this.btnCoder.TabIndex = 23;
            this.btnCoder.TabStop = false;
            this.btnCoder.Text = "Coder";
            this.btnCoder.UseVisualStyleBackColor = true;
            this.btnCoder.Click += new System.EventHandler(this.btnCoder_Click);
            // 
            // btnRpmUp
            // 
            this.btnRpmUp.Enabled = false;
            this.btnRpmUp.Font = new System.Drawing.Font("宋体", 15F);
            this.btnRpmUp.Location = new System.Drawing.Point(6, 182);
            this.btnRpmUp.Name = "btnRpmUp";
            this.btnRpmUp.Size = new System.Drawing.Size(69, 37);
            this.btnRpmUp.TabIndex = 23;
            this.btnRpmUp.TabStop = false;
            this.btnRpmUp.Text = "Rpm-";
            this.btnRpmUp.UseVisualStyleBackColor = true;
            this.btnRpmUp.Click += new System.EventHandler(this.btnRpmUp_Click);
            // 
            // btnRpmDown
            // 
            this.btnRpmDown.Enabled = false;
            this.btnRpmDown.Font = new System.Drawing.Font("宋体", 15F);
            this.btnRpmDown.Location = new System.Drawing.Point(6, 140);
            this.btnRpmDown.Name = "btnRpmDown";
            this.btnRpmDown.Size = new System.Drawing.Size(69, 37);
            this.btnRpmDown.TabIndex = 23;
            this.btnRpmDown.TabStop = false;
            this.btnRpmDown.Text = "Rpm+";
            this.btnRpmDown.UseVisualStyleBackColor = true;
            this.btnRpmDown.Click += new System.EventHandler(this.btnRpmDown_Click);
            // 
            // button_Back2
            // 
            this.button_Back2.Enabled = false;
            this.button_Back2.Font = new System.Drawing.Font("宋体", 15F);
            this.button_Back2.Location = new System.Drawing.Point(22, 224);
            this.button_Back2.Name = "button_Back2";
            this.button_Back2.Size = new System.Drawing.Size(37, 37);
            this.button_Back2.TabIndex = 23;
            this.button_Back2.TabStop = false;
            this.button_Back2.Text = "P";
            this.button_Back2.UseVisualStyleBackColor = true;
            this.button_Back2.Click += new System.EventHandler(this.button_Back2_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Ivory;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(11, 37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(173, 307);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseUp);
            // 
            // buttonRight
            // 
            this.buttonRight.Enabled = false;
            this.buttonRight.Font = new System.Drawing.Font("宋体", 15F);
            this.buttonRight.Location = new System.Drawing.Point(22, 266);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(37, 37);
            this.buttonRight.TabIndex = 24;
            this.buttonRight.Text = "R";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonRight);
            this.groupBox2.Controls.Add(this.button_Back2);
            this.groupBox2.Controls.Add(this.btnRpmDown);
            this.groupBox2.Controls.Add(this.btnRpmUp);
            this.groupBox2.Controls.Add(this.btnCoder);
            this.groupBox2.Controls.Add(this.btnVoltage);
            this.groupBox2.Controls.Add(this.btnMotor);
            this.groupBox2.Location = new System.Drawing.Point(188, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(81, 315);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // sendTextBox
            // 
            this.sendTextBox.BackColor = System.Drawing.Color.Ivory;
            this.sendTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTextBox.HideSelection = false;
            this.sendTextBox.Location = new System.Drawing.Point(9, 489);
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.ReadOnly = true;
            this.sendTextBox.Size = new System.Drawing.Size(525, 88);
            this.sendTextBox.TabIndex = 27;
            this.sendTextBox.TabStop = false;
            this.sendTextBox.Text = "";
            // 
            // receiveTextBox
            // 
            this.receiveTextBox.BackColor = System.Drawing.Color.Ivory;
            this.receiveTextBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receiveTextBox.HideSelection = false;
            this.receiveTextBox.Location = new System.Drawing.Point(9, 378);
            this.receiveTextBox.Name = "receiveTextBox";
            this.receiveTextBox.ReadOnly = true;
            this.receiveTextBox.Size = new System.Drawing.Size(525, 88);
            this.receiveTextBox.TabIndex = 28;
            this.receiveTextBox.TabStop = false;
            this.receiveTextBox.Text = "";
            // 
            // timerMPU
            // 
            this.timerMPU.Interval = 200;
            this.timerMPU.Tick += new System.EventHandler(this.MPUNavigation);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(798, 602);
            this.Controls.Add(this.receiveTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SweetRobot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region 定义串口对象
        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.IO.Ports.SerialPort serialPort4;
        #endregion



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        //private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        //private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.Button btnVoltage;
        private System.Windows.Forms.Button btnCoder;
        private System.Windows.Forms.Button btnRpmUp;
        private System.Windows.Forms.Button btnRpmDown;
        private System.Windows.Forms.Button button_Back2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 解锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上锁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 样本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图片生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 坐标生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RTK数据采集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 辅助选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MPUStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CameraStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备2关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设备3关机ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 错误代码过站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 联系方式ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox sendTextBox;
        private System.Windows.Forms.RichTextBox receiveTextBox;
        private System.Windows.Forms.ToolStripMenuItem GPRSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZigbeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BluetoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServoToolStripMenuItem;
        private System.Windows.Forms.Timer timerMPU;
    }
}

