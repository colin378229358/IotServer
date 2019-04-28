using System;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using XIT.BWT61PCL;

namespace XIT
{
    public partial class Form2 : Form//初始化
    {
        #region  窗口初始化与关闭
        public Form2()
        {
            InitializeComponent();
            timer3.Start();            //数据显示刷新定时器
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RefreshComPort(null, null);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                PortClose(null, null);
            }
            catch { }

        }
        #endregion

        private Int32 Baund        = 115200;
        private bool bClosing      = false;
        private bool bListening    = false;
        private DateTime TimeStart = DateTime.Now;
        private double[] LastTime = new double[10];


        #region 串口设置  
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
               // timer3.Start();
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
                timer3.Stop();
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
        
        #region 显示数据刷新
        private void DisplayRefresh(object sender, EventArgs e)
        {
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;
            label34.Text = DateTime.Now.ToLongTimeString() + "\r\n"
                            + JY901.GetInstance().ChipTime[0].ToString() + "-" + JY901.GetInstance().ChipTime[1].ToString() + "-" + JY901.GetInstance().ChipTime[2].ToString() + "\r\n" + JY901.GetInstance().ChipTime[3].ToString() + ":" + JY901.GetInstance().ChipTime[4].ToString() + ":" + JY901.GetInstance().ChipTime[5].ToString() + "." + JY901.GetInstance().ChipTime[6].ToString() + "\r\n"
                            + TimeElapse.ToString("f3") + "\r\n\r\n"
                            + JY901.GetInstance().Acceleration[0].ToString("f2") + " g\r\n"
                            + JY901.GetInstance().Acceleration[1].ToString("f2") + " g\r\n"
                            + JY901.GetInstance().Acceleration[2].ToString("f2") + " g\r\n\r\n"
                            + JY901.GetInstance().Palstance[0].ToString("f2") + " °/s\r\n"
                            + JY901.GetInstance().Palstance[1].ToString("f2") + " °/s\r\n"
                            + JY901.GetInstance().Palstance[2].ToString("f2") + " °/s\r\n\r\n"
                            + JY901.GetInstance().Angle[0].ToString("f2") + " °\r\n"
                            + JY901.GetInstance().Angle[1].ToString("f2") + " °\r\n"
                            + JY901.GetInstance().Angle[2].ToString("f2") + " °\r\n\r\n"
                            + JY901.GetInstance().Magnetic[0].ToString("f0") + " mG\r\n"
                            + JY901.GetInstance().Magnetic[1].ToString("f0") + " mG\r\n"
                            + JY901.GetInstance().Magnetic[2].ToString("f0") + " mG\r\n\r\n"
                            + JY901.GetInstance().Temperature.ToString("f2") + " ℃\r\n"
                            + JY901.GetInstance().Pressure.ToString("f0") + " Pa\r\n"
                            + JY901.GetInstance().Altitude.ToString("f2") + " m\r\n\r\n"
                            + (JY901.GetInstance().Longitude / 10000000).ToString("f0") + "°" + ((double)(JY901.GetInstance().Longitude % 10000000) / 1e5).ToString("f5") + "'\r\n"
                            + (JY901.GetInstance().Latitude / 10000000).ToString("f0") + "°" + ((double)(JY901.GetInstance().Latitude % 10000000) / 1e5).ToString("f5") + "'\r\n"
                            + JY901.GetInstance().GPSHeight.ToString("f1") + " m\r\n"
                            + JY901.GetInstance().GPSYaw.ToString("f1") + " °\r\n"
                            + JY901.GetInstance().GroundVelocity.ToString("f3") + " km/h";
        }
        #endregion

        #region 数据解析
        private void DecodeData(byte[] byteTemp)
        {
            double[] Data = new double[4];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds/1000;

            Data[0] = BitConverter.ToInt16(byteTemp, 2);
            Data[1] = BitConverter.ToInt16(byteTemp, 4);
            Data[2] = BitConverter.ToInt16(byteTemp, 6);
            Data[3] = BitConverter.ToInt16(byteTemp, 8);
            switch (byteTemp[1])
            {
                case 0x50:                                          //时间输出
                    JY901.GetInstance().ChipTime[0] = (short) (2000 + byteTemp[2]);     //YY：年，20YY 年
                    JY901.GetInstance().ChipTime[1] = byteTemp[3];                      //MM：月
                    JY901.GetInstance().ChipTime[2] = byteTemp[4];                      //DD：日
                    JY901.GetInstance().ChipTime[3] = byteTemp[5];                      //HH：时
                    JY901.GetInstance().ChipTime[4] = byteTemp[6];                      //MM：分
                    JY901.GetInstance().ChipTime[5] = byteTemp[7];                      //SS：秒
                    JY901.GetInstance().ChipTime[6] = BitConverter.ToInt16(byteTemp, 8);//MS：毫秒
                    break;
                case 0x51:                                          //加速度输出
                    JY901.GetInstance().Temperature = Data[3]/100.0;                   
                    Data[0] = Data[0]/32768.0*16;
                    Data[1] = Data[1]/32768.0*16;
                    Data[2] = Data[2]/32768.0*16;
                    JY901.GetInstance().Acceleration[0] = Data[0];
                    JY901.GetInstance().Acceleration[1] = Data[1];
                    JY901.GetInstance().Acceleration[2] = Data[2];
                    JY901.GetInstance().Acceleration[3] = Data[3];
                    if ((TimeElapse - LastTime[1]) < 0.1) return;
                    LastTime[1] = TimeElapse;
                    break;
                case 0x52:                                          //角速度输出
                    JY901.GetInstance().Temperature = Data[3]/100.0;
                    Data[0] = Data[0]/32768.0*2000;
                    Data[1] = Data[1]/32768.0*2000;
                    Data[2] = Data[2]/32768.0*2000;
                    JY901.GetInstance().Palstance[0] = Data[0];
                    JY901.GetInstance().Palstance[1] = Data[1];
                    JY901.GetInstance().Palstance[2] = Data[2];
                    JY901.GetInstance().Palstance[3] = Data[3];
                    if ((TimeElapse - LastTime[2]) < 0.1) return;
                    LastTime[2] = TimeElapse;
                    break;
                case 0x53:                                          //角度输出
                    JY901.GetInstance().Temperature = Data[3]/100.0;
                    Data[0] = Data[0]/32768.0*180;
                    Data[1] = Data[1]/32768.0*180;
                    Data[2] = Data[2]/32768.0*180;
                    JY901.GetInstance().Angle[0] = Data[0];
                    JY901.GetInstance().Angle[1] = Data[1];
                    JY901.GetInstance().Angle[2] = Data[2];
                    JY901.GetInstance().Angle[3] = Data[3];
                    if ((TimeElapse - LastTime[3]) < 0.1) return;
                    LastTime[3] = TimeElapse;
                    break;
                case 0x54:                                          //磁场输出
                    JY901.GetInstance().Temperature = Data[3]/100.0;
                    JY901.GetInstance().Magnetic[0] = Data[0];
                    JY901.GetInstance().Magnetic[1] = Data[1];
                    JY901.GetInstance().Magnetic[2] = Data[2];
                    JY901.GetInstance().Magnetic[3] = Data[3];
                    if ((TimeElapse - LastTime[4]) < 0.1) return;
                    LastTime[4] = TimeElapse;
                    break;
                case 0x55:                                          //端口状态数据输出
                    JY901.GetInstance().Port[0] = Data[0];
                    JY901.GetInstance().Port[1] = Data[1];
                    JY901.GetInstance().Port[2] = Data[2];
                    JY901.GetInstance().Port[3] = Data[3];
                    break;
                case 0x56:                                          //气压、高度输出
                    JY901.GetInstance().Pressure = BitConverter.ToInt32(byteTemp, 2);
                    JY901.GetInstance().Altitude = (double) BitConverter.ToInt32(byteTemp, 6)/100.0;
                    break;
                case 0x57:                                          //经纬度输出
                    JY901.GetInstance().Longitude = BitConverter.ToInt32(byteTemp, 2);
                    JY901.GetInstance().Latitude = BitConverter.ToInt32(byteTemp, 6);
                    break;
                case 0x58:                                          //地速输出
                    JY901.GetInstance().GPSHeight = (double) BitConverter.ToInt16(byteTemp, 2)/10.0;
                    JY901.GetInstance().GPSYaw = (double) BitConverter.ToInt16(byteTemp, 4)/10.0;
                    JY901.GetInstance().GroundVelocity = BitConverter.ToInt16(byteTemp, 6)/1e3;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region 串口数据接收
        byte byteLastNo = 0;
        delegate void UpdateData(byte[] byteData);//声明一个委托
        byte[] RxBuffer = new byte[1000];
        UInt16 usRxLength = 0;

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
                byte[] byteTemp = new byte[1000];

                if (bClosing) return;
                try
                {
                    bListening = true;
                    UInt16 usLength = 0;
                    try
                    {
                        usLength = (UInt16)spSerialPort.Read(RxBuffer, usRxLength, 700);
                    }
                    catch (Exception err)
                    {
                        //MessageBox.Show(err.Message);
                        //return;
                    }
                    usRxLength += usLength;
                    while (usRxLength >= 11)
                    {
                        UpdateData Update = new UpdateData(DecodeData);
                        RxBuffer.CopyTo(byteTemp, 0);
                        if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50) == 0x50)))
                        {
                            for (int i = 1; i < usRxLength; i++) RxBuffer[i - 1] = RxBuffer[i];
                            usRxLength--;
                            continue;
                        }
                        if (((byteTemp[0] + byteTemp[1] + byteTemp[2] + byteTemp[3] + byteTemp[4] + byteTemp[5] + byteTemp[6] + byteTemp[7] + byteTemp[8] + byteTemp[9]) & 0xff) == byteTemp[10])
                            this.Invoke(Update, byteTemp);
                        for (int i = 11; i < usRxLength; i++) RxBuffer[i - 11] = RxBuffer[i];
                        usRxLength -= 11;
                    }

                    Thread.Sleep(10);
                }
                finally
                {
                    bListening = false;//我用完了，ui可以关闭串口了。   
                }
        }
        #endregion

        #region  串口数据发送
        public sbyte SendMessage(Byte[] byteSend)
        {
            if (spSerialPort.IsOpen == false)
            {
                //  MessageBox.Show(rm.GetString("PortNotOpen"), "Error!");
                Status.Text = "Port Not Open!";
                return -1;
            }
            try
            {
                spSerialPort.Write(byteSend, 0, byteSend.Length);
                return 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return -1;
            }
        }
        #endregion
    }
}
