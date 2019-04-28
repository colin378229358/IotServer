using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperSocket.Common;
using XIT.TYMessage;

namespace XIT
{
    public partial class FormServo : Form
    {
        public FormServo()
        {
            InitializeComponent();
        }

        private void Servo_Load(object sender, EventArgs e)
        {
            RefreshCom(null, null);
        }

        #region 串口设置
            private Int32 Baund = 9600;
            private bool bClosing = false;
            private bool bListening = false;
            private void RefreshCom(object sender, EventArgs e)
            {
                toolStripComSet.DropDownItems.Clear();
                foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
                {
                    toolStripComSet.DropDownItems.Add(portName, null, PortSelect);

                    if ((spSerialPort.IsOpen) & (spSerialPort.PortName == portName))
                    {
                        ToolStripMenuItem menu = (ToolStripMenuItem)toolStripComSet.DropDownItems[toolStripComSet.DropDownItems.Count - 1];
                        menu.Checked = true;
                    }
                }
                toolStripComSet.DropDownItems.Add(new ToolStripSeparator());
                toolStripComSet.DropDownItems.Add("Close", null, PortClose);
            }

            private void PortSelect(object sender, EventArgs e)
            {
                ToolStripMenuItem menu = (ToolStripMenuItem)sender;
                try
                {
                    PortClose(null, null);
                    spSerialPort.PortName = menu.Text;
                    spSerialPort.BaudRate = Baund;
                    spSerialPort.Open();
                    menu.Checked = true;
                    bClosing = false;
                }
                catch (Exception ex)
                {
                    menu.Checked = false;
                }
            }

            private void PortClose(object sender, EventArgs e)
            {
                for (int i = 0; i < toolStripComSet.DropDownItems.Count - 2; i++)
                {
                    ToolStripMenuItem tempMenu = (ToolStripMenuItem)toolStripComSet.DropDownItems[i];
                    tempMenu.Checked = false;
                }
                if (spSerialPort.IsOpen)
                {
                    bClosing = true;
                    while (bListening) Application.DoEvents();
                    spSerialPort.Dispose();
                    spSerialPort.Close();
                }
            }
        #endregion
       
        #region 串口数据接收
            private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
            {
                var recMsg = spSerialPort.ReadExisting();
                WriteToServoRecText(recMsg);
            }
        #endregion

        #region  串口数据发送
        private sbyte SendMessage(byte[] byteArray)
        {
            if (spSerialPort.IsOpen == false)
            {
                return -1;
            }
            try
            {
                spSerialPort.Write(byteArray, 0, byteArray.Length);
                return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }
        #endregion

        #region 定义委文本框函数
        private delegate void TextDelegate(string str);     //用于文本框代理

        private void WriteToServoSendText(string str)
        {
            TextDelegate d1 = ServoSendDel;
            textBoxServoSend.Invoke(d1, str);
        }

        private void ServoSendDel(string str)
        {
            textBoxServoSend.AppendText(str);
            textBoxServoSend.AppendText("\r\n");
            this.Refresh();
        }
        private void WriteToServoRecText(string str)
        {
            TextDelegate d2 = ServoRecDel;
            textBoxServoRec.Invoke(d2, str);
        }

        private void ServoRecDel(string str)
        {
            textBoxServoRec.AppendText(str);
            textBoxServoRec.AppendText("\r\n");
            this.Refresh();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxServoSend.Clear();
            textBoxServoRec.Clear();
        }
        #endregion

        #region 电机检测
        //驱动使能
        private void buttonEnable_Click(object sender, EventArgs e)
        {
            var datEnable = new byte[]{0x01, 0x10, 0x46, 0x57, 0x00, 0x01, 0x02, 0x00, 0x01, 0x4d, 0xb3};
            SendMessage(datEnable);
            WriteToServoSendText("驱动使能");
        }
        //使能关闭
        private void buttonDisable_Click(object sender, EventArgs e)
        {
            var datDisable = new byte[] { 0x01, 0x10, 0x46, 0x57, 0x00, 0x01, 0x02, 0x00, 0x00, 0x8c, 0x73 };
            SendMessage(datDisable);
            WriteToServoSendText("使能关闭");
        }
        //电机正转
        private void buttonMotorP_Click(object sender, EventArgs e)
        {
            var servoMP     = new byte[11];
            servoMP[0]      = 0x01;
            servoMP[1]      = 0x10;
            servoMP[2]      = 0x44;
            servoMP[3]      = 0x20;
            servoMP[4]      = 0x00;
            servoMP[5]      = 0x02;
            servoMP[6]      = 0x04;
            var speed       = textBoxPlusP.Text.ToInt32();
            var speedH      = (byte)(speed>>8);
            var speedL      = (byte) speed;
            servoMP[7]      = speedH;        //电机转速(高8位)
            servoMP[8]      = speedL;        //电机转速(低8位)

            servoMP[9]      = 0x00;
            servoMP[10]     = 0x00;
            var crcH        = TYMessage.CRC.CRC16(servoMP)[1];
            var crcL        = TYMessage.CRC.CRC16(servoMP)[0];
            var dat =       new byte[13];
            for (var i=0; i < servoMP.Length; i++)
            {
                dat[i] = servoMP[i];
            }
            dat[11] = crcH;
            dat[12] = crcL;
            SendMessage(dat);
            WriteToServoSendText("电机正转："+ textBoxPlusP.Text.ToString());
        }
        //电机反转
        private void buttonMotorN_Click(object sender, EventArgs e)
        {
            var servoMN = new byte[11];
            servoMN[0] = 0x01;
            servoMN[1] = 0x10;
            servoMN[2] = 0x44;
            servoMN[3] = 0x20;
            servoMN[4] = 0x00;
            servoMN[5] = 0x02;
            servoMN[6] = 0x04;
            var speed = textBoxPlusN.Text.ToInt32();
            var speedH = (byte)(speed >> 8);
            var speedL = (byte)speed;
            servoMN[7] = (byte)(~speedH);        //电机转速(高8位)
            servoMN[8] = (byte)(~speedL);        //电机转速(低8位)
            servoMN[9] = 0x00;
            servoMN[10] = 0x00;
            var crcH = TYMessage.CRC.CRC16(servoMN)[1];
            var crcL = TYMessage.CRC.CRC16(servoMN)[0];
            var dat = new byte[13];
            for (var i = 0; i < servoMN.Length; i++)
            {
                dat[i] = servoMN[i];
            }
            dat[11] = crcH;
            dat[12] = crcL;
            SendMessage(dat);
            WriteToServoSendText("电机反转：" + textBoxPlusN.Text.ToString());
        }
        #endregion


    }
}
