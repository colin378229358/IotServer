using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using XIT.IOMessage;

namespace XIT
{
    public partial class Form5 : Form
    {
        #region  窗口初始化与关闭
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            RefreshComPort(null, null);
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PortClose(null, null);
            }
            catch
            {
                
            }
        }
        #endregion

        #region 串口设置  
        private Int32 Baund = 9600;
        private bool bClosing = false;
        private bool bListening = false;
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
        private void RefreshComPort(object sender, EventArgs e)
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
        #endregion

        #region 串口数据接收
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            var recMsg = spSerialPort.ReadExisting();
            WriteToIORecText(recMsg);
        }
        #endregion

        #region  串口数据发送
        public sbyte SendMessage(string str)
        {
            if (spSerialPort.IsOpen == false)
            {
                return -1;
            }
            try
            {
                //spSerialPort.Write(byteSend, 0, byteSend.Length);
                spSerialPort.Write(str);
                return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }
        #endregion

        #region 按键控制指令
        private void buttonAhead_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Ahead);
            WriteToIOSendText(CtrlMsg.GetInstance().Ahead);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Back);
            WriteToIOSendText(CtrlMsg.GetInstance().Back);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Left);
            WriteToIOSendText(CtrlMsg.GetInstance().Left);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Right);
            WriteToIOSendText(CtrlMsg.GetInstance().Right);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Stop);
            WriteToIOSendText(CtrlMsg.GetInstance().Stop);
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Up);
            WriteToIOSendText(CtrlMsg.GetInstance().Up);
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Down);
            WriteToIOSendText(CtrlMsg.GetInstance().Down);
        }

        private void buttonStay_Click(object sender, EventArgs e)
        {
            SendMessage(CtrlMsg.GetInstance().Stay);
            WriteToIOSendText(CtrlMsg.GetInstance().Stay);
        }
        #endregion

        #region 继电器控制指令
        private void checkBoxOut1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut1.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out1On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out1On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out1Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out1Off);
            }
        }

        private void checkBoxOut2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut2.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out2On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out2On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out2Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out2Off);
            }
        }

        private void checkBoxOut3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut3.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out3On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out3On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out3Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out3Off);
            }
        }

        private void checkBoxOut4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut4.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out4On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out4On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out4Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out4Off);
            }
        }

        private void checkBoxOut5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut5.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out5On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out5On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out5Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out5Off);
            }
        }

        private void checkBoxOut6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut6.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out6On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out6On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out6Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out6Off);
            }
        }

        private void checkBoxOut7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut7.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out7On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out7On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out7Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out7Off);
            }
        }

        private void checkBoxOut8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut8.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out8On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out8On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out8Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out8Off);
            }
        }

        private void checkBoxOut9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut9.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out9On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out9On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out9Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out9Off);
            }
        }

        private void checkBoxOut10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut10.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out10On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out10On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out10Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out10Off);
            }
        }

        private void checkBoxOut11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut11.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out11On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out11On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out11Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out11Off);
            }
        }

        private void checkBoxOut12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut12.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out12On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out12On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out12Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out12Off);
            }
        }

        private void checkBoxOut13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut13.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out13On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out13On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out13Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out13Off);
            }
        }

        private void checkBoxOut14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut14.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out14On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out14On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out14Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out14Off);
            }
        }

        private void checkBoxOut15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOut15.Checked)
            {
                SendMessage(CtrlMsg.GetInstance().Out15On);
                WriteToIOSendText(CtrlMsg.GetInstance().Out15On);
            }
            else
            {
                SendMessage(CtrlMsg.GetInstance().Out15Off);
                WriteToIOSendText(CtrlMsg.GetInstance().Out15Off);
            }
        }
        #endregion

        #region 定义委文本框函数
        private delegate void TextDelegate(string str);     //用于文本框代理
        private void IOSendDel(string str)
        {
            textBoxIOSend.AppendText(str);
            textBoxIOSend.AppendText("\r\n");
            this.Refresh();
        }

        private void WriteToIOSendText(string str)
        {
            TextDelegate d1 = IOSendDel;
            textBoxIOSend.Invoke(d1, str);
        }

        private void IORecDel(string str)
        {
            textBoxIORec.AppendText(str);
            textBoxIORec.AppendText("\r\n");
            this.Refresh();
        }

        private void WriteToIORecText(string str)
        {
            TextDelegate d2 = IORecDel;
            textBoxIORec.Invoke(d2,str);
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxIOSend.Clear();
            textBoxIORec.Clear();
        }
        #endregion
    }
}












