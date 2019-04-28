#region Android手机测试指令
///////////////////////////////////////启动指令/////////////////////////////////////////////
//adb shell  am start -n com.example.fxnfctestapk/.P660NFCTestActivity

//adb shell am start -n com.fx.factoryautotest/.SDcardActivity SD卡
//adb shell am start -n com.fx.factoryautotest/.ReadSnActivity 读SN号
//adb shell am start -n com.fx.factoryautotest/.FlashLightActivity 闪光灯
//adb shell am start -n com.fx.factoryautotest/.LightSensorActivity 光感
//adb shell am start -n com.fx.factoryautotest/.VibrationActivity 马达
//adb shell am start -n com.fx.factoryautotest/.MicTestActivity 听筒
//adb shell am start -n com.fx.factoryautotest/.GSensorActivity 重力感应
//adb shell am start -n com.fx.factoryautotest/.MicTestActivity MIC测试
//adb shell am start -n com.fx.factoryautotest/.WifiActivity WIFI
//adb shell am start -n com.fx.factoryautotest/.ProximitySensorActivity 距离感应
//adb shell am start -n com.fx.factoryautotest/.TpActivity TP测试
//adb shell am start -n com.fx.factoryautotest/.PressureTestActivity 气压计测试
//adb shell am start -n com.fx.factoryautotest/.GyroscopeTestActivity 陀螺仪
//adb shell am start -n com.fx.factoryautotest/.CompassTestActivity 指南针
//adb shell am start -n com.fx.factoryautotest/.HallSensorTestActivity 霍尔开关
//adb shell am start -n com.fx.factoryautotest/.ButtonActivity 按键测试
//adb shell am start -n com.fx.factoryautotest/.BluetoothActivity 蓝牙测试
//adb shell am start -n com.fx.factoryautotest/.ChargerActivity 充电测试
//adb shell am start -n com.fx.factoryautotest/.SpeakerTestActivity MIC测试
//adb shell am start -n com.fx.factoryautotest/.FrontCameraActivity 前摄像头测试
//adb shell am start -n com.fx.factoryautotest/.RearCameraActivity 后摄像头测试
//adb shell am start -n com.fx.factoryautotest/.HeadSetExistActivity 耳机插入测试
//adb shell am start -n com.fx.factoryautotest/.HeadSetReceiverTestActivity 耳机听筒
//adb shell am start -n com.fx.factoryautotest/.HeadSetMicTestActivity 耳机mic
//adb shell am start com.fx.factoryautotest/.BarCodeActivity 显示二维码
//adb shell am start -n com.fx.factoryautotest/.CaptureActivity 聚焦测试
#endregion

#region 主控板端口分配
//ComNum1 IO模块
//ComNum2 调速模块
//ComNum3 陀螺仪
//ComNum4 通信模块(4G)
//ComNum5 通信模块(Zigbee)
//Usb1    蓝牙模块
//Usb2    摄像头模块
//Lan     激光模块
//Wifi    通信模块
#endregion

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using SuperSocket.Common;
using XIT.BSDBMessage;
using XIT.BWT61PCL;
using XIT.Navigation;
using XIT.RTKMessage;
using Robot.Comm;
using SocketServer.Protocol;

namespace XIT
{
    public partial class Form1 : Form
    {
        #region 包涵dll
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        #endregion

        #region 变量声明
        string fileSerial = Application.StartupPath;
        string section;//段值
        string key;    //键值
        StringBuilder temp = new StringBuilder(255);//一个可变的字符序列

        byte[] arrMotor = new byte[10];      //上位机向下位机发送指令数组
        private static int speedMotor = 500;

        public bool VLStationFlag;  //站位选择 true为声光站位 false为平台站位
        #endregion

        #region 定义委托及委托函数
        private delegate void MyDelegate(string str);                       //用于richtextbox代理
        private delegate void MyDelegate2(int stateFlag);                   //用于label代理
        private delegate void PictureDelegate(Bitmap b1, Bitmap b2, int n);
        private delegate void DataGridViewDelegate(string[] str, int flag);
        #endregion        

        #region 文本框代理
        private void TestDelegate(string str) //调试代理
        {
            richTextBox1.AppendText(str);
            richTextBox1.AppendText("\r\n");
            this.Refresh();
        }

        private void writeToRichTextBox(string strWrite)
        {
            MyDelegate d1 = TestDelegate;
            richTextBox1.Invoke(d1, strWrite);
        }

        private void SendDelegate(string str) //发送代理
        {
          sendTextBox.AppendText(str);
          sendTextBox.AppendText("\r\n");
          this.Refresh();
        }

        private void WriteToSendTextBox(string str)
        {
            MyDelegate d1 = SendDelegate;//文本框代理
            sendTextBox.Invoke(d1, str);
        }

        private void RecDelegate(string str) //接收代理
        {
            receiveTextBox.AppendText(str);
            receiveTextBox.AppendText("\r\n");
            this.Refresh();
        }

        private void WriteToRecTextBox(string str)
        {
            MyDelegate d1 = RecDelegate;
            receiveTextBox.Invoke(d1, str);
        }
        #endregion

        #region 窗口初始化
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;


        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        #endregion

        #region 开始按钮
        private void button_Back_Click(object sender, EventArgs e)
        {
            writeToRichTextBox("开始测试");
            writeToRichTextBox("Start Time: " + DateTime.Now.ToString());

            Check_SerialPort();
            Set_SerialPort();
        }
        #endregion

        #region 停止按钮
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerMPU.Stop();
            //accessWrite = false;
            //MyDelegate d1 = TestDelegate;//文本框代理
            //pictureBox5.Image = Image.FromFile(filename + "\\show.png");
            //str = "停止测试线程";
            //richTextBox1.Invoke(d1, str);

            //button_False();
        }
        #endregion
 
        #region 界面控制程序
        //屏幕大小173 307

        #region 读取驱动器实际直流母线电压
        private void btnVoltage_Click(object sender, EventArgs e)       //Voltage
        {
            var msgVol = new BSDB232()
            {
                ID    = 0x01,
                CMD   = 0xA0,
                AddrH = 0x50,
                AddrL = 0x01,
                ErrR  = 0x00,
                Dat1  = 0x00,
                Dat2  = 0x00,
                Dat3  = 0x00,
                Dat4  = 0x00,
                //Check = 0xF2 
            };
            Serial1PcToMcu(msgVol);
        }
        #endregion

        #region 读取电机编码器实际位置
        private void btnCoder_Click(object sender, EventArgs e)         //Coder
        {
            var msgCoder = new BSDB232()
            {
                ID    = 0x01,
                CMD   = 0xA0,
                AddrH = 0x70,
                AddrL = 0x70,
                ErrR  = 0x00,
                Dat1  = 0x00,
                Dat2  = 0x00,
                Dat3  = 0x00,
                Dat4  = 0x00,
                //Check = 0x81
            };
            Serial1PcToMcu(msgCoder);
        }
        #endregion

        #region 写目标速度rpm 500
        private void btnMotor_Click(object sender, EventArgs e)         //Motor
        {
            var msgRmp = new BSDB232()
            {
                ID      = 0x01,
                CMD     = 0x52,
                AddrH   = 0x70,
                AddrL   = 0xB1,
                ErrR    = 0x00,
                Dat1    = GeneralConver.ToIntBytes(speedMotor)[3],  //MSB
                Dat2    = GeneralConver.ToIntBytes(speedMotor)[2],
                Dat3    = GeneralConver.ToIntBytes(speedMotor)[1],
                Dat4    = GeneralConver.ToIntBytes(speedMotor)[0]   //LSB
                //Dat3    = 0x01,
                //Dat4    = 0xF4,
                //Check   = 0x69
            };
            Serial1PcToMcu(msgRmp);
        }
        #endregion

        #region 增加目标转速
        private void btnRpmUp_Click(object sender, EventArgs e)         //RpmUp
        {
            speedMotor += 50;
            if (speedMotor > 2500)
            {
                MessageBox.Show("已超出最大转速！");
                return;
            }
            var msgRmp = new BSDB232()
            {
                ID    = 0x01,
                CMD   = 0x52,
                AddrH = 0x70,
                AddrL = 0xB1,
                ErrR  = 0x00,
                Dat1  = GeneralConver.ToIntBytes(speedMotor)[3],  //MSB
                Dat2  = GeneralConver.ToIntBytes(speedMotor)[2],
                Dat3  = GeneralConver.ToIntBytes(speedMotor)[1],
                Dat4  = GeneralConver.ToIntBytes(speedMotor)[0]   //LSB
            };
           Serial1PcToMcu(msgRmp);
        }
        #endregion

        #region 减少目标转速
        private void btnRpmDown_Click(object sender, EventArgs e)       //RpmDown
        {
            speedMotor -= 50;
            if (speedMotor < 50)
            {
                MessageBox.Show("已超出最小转速！");
                return;
            }
            var msgRmp = new BSDB232()
            {
                ID    = 0x01,
                CMD   = 0x52,
                AddrH = 0x70,
                AddrL = 0xB1,
                ErrR  = 0x00,
                Dat1  = GeneralConver.ToIntBytes(speedMotor)[3],  //MSB
                Dat2  = GeneralConver.ToIntBytes(speedMotor)[2],
                Dat3  = GeneralConver.ToIntBytes(speedMotor)[1],
                Dat4  = GeneralConver.ToIntBytes(speedMotor)[0]   //LSB
            };
            Serial1PcToMcu(msgRmp);
        }
        #endregion

        #region

        private void button_Enable()
        {
            buttonBack.Enabled = false;
            buttonBack.Focus();
            buttonStop.Enabled = true;
            btnVoltage.Enabled = true;
            btnCoder.Enabled = true;
            btnMotor.Enabled = true;
            btnRpmDown.Enabled = true;
            btnRpmUp.Enabled = true;
        }

        private void button_False()
        {
            buttonBack.Enabled = true;
            buttonBack.Focus();
            buttonStop.Enabled = false;
            btnVoltage.Enabled = false;
            btnCoder.Enabled = false;
            btnMotor.Enabled = false;
            btnRpmDown.Enabled = false;
            btnRpmUp.Enabled = false;
        }

        #endregion

        private void button_Back2_Click(object sender, EventArgs e)//POWER
        {

        }
        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {

        }
        private void buttonRight_Click(object sender, EventArgs e)
        {

        }//刷新屏幕
        #endregion

        #region 串口发送函数
        
        #region IO模块发送函数(串口1)
        private void Serial1PcToMcu(BSDB232 msg)
        {
            arrMotor[0] = msg.ID;
            arrMotor[1] = msg.CMD;
            arrMotor[2] = msg.AddrH;
            arrMotor[3] = msg.AddrL;
            arrMotor[4] = msg.ErrR;
            arrMotor[5] = msg.Dat1;
            arrMotor[6] = msg.Dat2;
            arrMotor[7] = msg.Dat3;
            arrMotor[8] = msg.Dat4;
            for (int i=0; i<arrMotor.Length-1;i++)
            {
                msg.Check += arrMotor[i];
            }
            arrMotor[9] = msg.Check; ;         
            serialPort1.Write(arrMotor, 0, 10);
            WriteToSendTextBox(serialPort1.PortName + ":" + GeneralConver.ToHexString(arrMotor));
        }
        #endregion

        #region IO模块发送函数(串口2)
        private void Serial2PcToMotor(string msg)
        {
            serialPort2.Write("");
            WriteToSendTextBox(serialPort2.PortName + ":" +msg);
        }
        #endregion

        #endregion

        #region 串口接收函数

        #region IO模块数据接收与解析
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int len = serialPort1.BytesToRead;
            if (len == 0) return;//没有接收到数据，退出
            byte[] receiveMsg = new byte[len];
            serialPort1.Read(receiveMsg, 0, len);
            //RTKLocation.GetInstance().Latitude = receiveMsg[3];

            WriteToRecTextBox(serialPort1.PortName + ":" + GeneralConver.ToHexString(receiveMsg));
        }
        #endregion

        #region 调速模块数据接收与解析
        private void serialPort2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }
        #endregion

        #region 陀螺仪数据接收与解析
        private DateTime TimeStart = DateTime.Now;
        private double[] LastTime  = new double[10];
        byte[] RxBuffer            = new byte[1000];
        UInt16 usRxLength = 0;
        private void serialPort3_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] byteTemp = new byte[1000];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;

            try
            {
                UInt16 usLength = 0;
                try
                {
                    usLength = (UInt16) serialPort3.Read(RxBuffer, usRxLength, 700);
                }
                catch (Exception err)
                {
                    //MessageBox.Show(err.Message);
                    //return;
                }
                usRxLength += usLength;
                while (usRxLength >= 11)
                {
                    RxBuffer.CopyTo(byteTemp, 0);
                    if (!((byteTemp[0] == 0x55) & ((byteTemp[1] & 0x50) == 0x50)))
                    {
                        for (int i = 1; i < usRxLength; i++) RxBuffer[i - 1] = RxBuffer[i];
                        usRxLength--;
                        continue;
                    }
                    if (((byteTemp[0] + byteTemp[1] + byteTemp[2] + byteTemp[3] + byteTemp[4] + byteTemp[5] +
                          byteTemp[6] + byteTemp[7] + byteTemp[8] + byteTemp[9]) & 0xff) == byteTemp[10])
                        DecodeData(byteTemp);
                    for (int i = 11; i < usRxLength; i++) RxBuffer[i - 11] = RxBuffer[i];
                    usRxLength -= 11;
                }
                Thread.Sleep(1000);
            }
            finally
            {
            }
        }

        private void DecodeData(byte[] byteTemp)
        {
            double[] Data = new double[4];
            double TimeElapse = (DateTime.Now - TimeStart).TotalMilliseconds / 1000;

            Data[0] = BitConverter.ToInt16(byteTemp, 2);
            Data[1] = BitConverter.ToInt16(byteTemp, 4);
            Data[2] = BitConverter.ToInt16(byteTemp, 6);
            Data[3] = BitConverter.ToInt16(byteTemp, 8);
            switch (byteTemp[1])
            {
                case 0x50:                                           //时间输出
                    JY901.GetInstance().ChipTime[0] = (short)(2000 + byteTemp[2]);     //YY：年，20YY 年
                    JY901.GetInstance().ChipTime[1] = byteTemp[3];                      //MM：月
                    JY901.GetInstance().ChipTime[2] = byteTemp[4];                      //DD：日
                    JY901.GetInstance().ChipTime[3] = byteTemp[5];                      //HH：时
                    JY901.GetInstance().ChipTime[4] = byteTemp[6];                      //MM：分
                    JY901.GetInstance().ChipTime[5] = byteTemp[7];                      //SS：秒
                    JY901.GetInstance().ChipTime[6] = BitConverter.ToInt16(byteTemp, 8);//MS：毫秒
                    break;
                case 0x51:                                          //加速度输出
                    JY901.GetInstance().Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 16;
                    Data[1] = Data[1] / 32768.0 * 16;
                    Data[2] = Data[2] / 32768.0 * 16;
                    JY901.GetInstance().Acceleration[0] = Data[0];
                    JY901.GetInstance().Acceleration[1] = Data[1];
                    JY901.GetInstance().Acceleration[2] = Data[2];
                    JY901.GetInstance().Acceleration[3] = Data[3];
                    if ((TimeElapse - LastTime[1]) < 0.1) return;
                    LastTime[1] = TimeElapse;
                    break;
                case 0x52:                                          //角速度输出
                    JY901.GetInstance().Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 2000;
                    Data[1] = Data[1] / 32768.0 * 2000;
                    Data[2] = Data[2] / 32768.0 * 2000;
                    JY901.GetInstance().Palstance[0] = Data[0];
                    JY901.GetInstance().Palstance[1] = Data[1];
                    JY901.GetInstance().Palstance[2] = Data[2];
                    JY901.GetInstance().Palstance[3] = Data[3];
                    if ((TimeElapse - LastTime[2]) < 0.1) return;
                    LastTime[2] = TimeElapse;
                    break;
                case 0x53:                                          //角度输出
                    JY901.GetInstance().Temperature = Data[3] / 100.0;
                    Data[0] = Data[0] / 32768.0 * 180;
                    Data[1] = Data[1] / 32768.0 * 180;
                    Data[2] = Data[2] / 32768.0 * 180;
                    JY901.GetInstance().Angle[0] = Data[0];
                    JY901.GetInstance().Angle[1] = Data[1];
                    JY901.GetInstance().Angle[2] = Data[2];
                    JY901.GetInstance().Angle[3] = Data[3];
                    if ((TimeElapse - LastTime[3]) < 0.1) return;
                    LastTime[3] = TimeElapse;
                    break;
                case 0x54:                                          //磁场输出
                    JY901.GetInstance().Temperature = Data[3] / 100.0;
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
                    JY901.GetInstance().Pressure       = BitConverter.ToInt32(byteTemp, 2);
                    JY901.GetInstance().Altitude       = (double)BitConverter.ToInt32(byteTemp, 6) / 100.0;
                    break;
                case 0x57:                                          //经纬度输出
                    JY901.GetInstance().Longitude      = BitConverter.ToInt32(byteTemp, 2);
                    JY901.GetInstance().Latitude       = BitConverter.ToInt32(byteTemp, 6);
                    break;
                case 0x58:                                          //地速输出
                    JY901.GetInstance().GPSHeight      = (double)BitConverter.ToInt16(byteTemp, 2) / 10.0;
                    JY901.GetInstance().GPSYaw         = (double)BitConverter.ToInt16(byteTemp, 4) / 10.0;
                    JY901.GetInstance().GroundVelocity = BitConverter.ToInt16(byteTemp, 6) / 1e3;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region GPRS/RTK数据接收与解析
        private void serialPort4_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string recMsg = serialPort4.ReadExisting();
            string[] r30MsgArray                   = recMsg.Split(',');
            RTKDataDecode(r30MsgArray);
            LogHelper.WriteLog(recMsg);
        }

        private void RTKDataDecode(string[] dat)
        {
            switch (dat[0])
            {
                case "#HEADINGA":
                    if (dat.Length == 26)
                    {
                        HEADINGA.GetInstance().Yaw = Convert.ToSingle(dat[12]); ;
                    }
                    break;
                case "$GPGGA":
                    if (dat.Length == 15)
                    {
                        GPGGA.GetInstance().LogHeader = dat[0];
                        GPGGA.GetInstance().UTCtime = Convert.ToSingle(dat[1]);
                        GPGGA.GetInstance().Latitude = Convert.ToSingle(dat[2]);
                        GPGGA.GetInstance().LatitudeDir = dat[3];
                        GPGGA.GetInstance().Longitude = Convert.ToSingle(dat[4]);
                        GPGGA.GetInstance().LongitudeDir = dat[5];
                        GPGGA.GetInstance().MsgStatus = (byte)dat[6].ToInt32();
                        GPGGA.GetInstance().PlanetNum = (byte)dat[7].ToInt32();
                        GPGGA.GetInstance().DopLevel = dat[8].ToLong();
                        GPGGA.GetInstance().AntennaPlanetNum = dat[9].ToLong();
                        GPGGA.GetInstance().AntennaUnit = dat[10];
                        GPGGA.GetInstance().SeaPlanetNum = dat[11].ToLong();
                        GPGGA.GetInstance().SeaUnit = dat[12];
                        GPGGA.GetInstance().DiffCorDelay = (byte)dat[13].ToInt32();
                        //GPGGA.GetInstance().ReferenceId        = dat[14];
                        //GPGGA.GetInstance().Crc                = (byte)dat[15].ToInt32();
                    }
                    break;
                case "$GPRMC":
                    break;
                default:
                    break;             
            }
        }
        #endregion
       
        #endregion

        #region 菜单事件
        private void 解锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 上锁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MPU界面
        private void MPUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 mpuForm = new Form2();

            if (mpuForm.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion

        #region  RTK界面
        private void RTK数据采集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Check_SerialPort();
            var rtk = new RTK();
            if (rtk.ShowDialog() == DialogResult.OK)
            {

            }
        }
        #endregion

        #region IO控制界面
        private void IOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ioForm = new Form5();
            if (ioForm.ShowDialog() == DialogResult.OK)
            {
            }     
        }
        #endregion

        #region PWM调速界面
        private void DAToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 4G通信界面
        private void GPRSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Zigbee通信界面
        private void ZigbeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region  Bluetooth通信界面
        private void BluetoothToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region  Servo界面
        private void ServoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServo servoForm=new FormServo();
            if (servoForm.ShowDialog() == DialogResult.OK)
            {

            }

        }
        #endregion

        private void 图片生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 坐标生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check_SerialPort();                      
        }

        #region 确认串口是否可用
        private void Check_SerialPort()  
        {
            //var fileSerial = Application.StartupPath;
            section = "COM";
            //串口号读取
            #region 1号串口读取
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            key = "COMNUM1";
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
            try
            {
                serialPort1.PortName = temp.ToString();                 //
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = System.IO.Ports.Parity.None;       //无校验位                     
                serialPort1.StopBits = System.IO.Ports.StopBits.One;    //一个停止位
                serialPort1.ReadBufferSize = 1024;                      //接收缓冲区大小
                serialPort1.Open();
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();

                writeToRichTextBox(serialPort1.PortName+"打开成功");
                button_Enable();
            }
            catch (Exception)
            {
                //MessageBox.Show(serialPort1.PortName+"串口打开失败");
                //return;
                writeToRichTextBox(serialPort1.PortName + "串口打开失败");
            }
            #endregion

            #region 2号串口读取
            if (serialPort2.IsOpen)
            {
                serialPort2.Close();
            }
            key = "COMNUM2";//
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
            try
            {
                serialPort2.PortName = temp.ToString();//
                serialPort2.BaudRate = 9600;
                serialPort2.Parity = System.IO.Ports.Parity.None;  //无校验位                     
                serialPort2.StopBits = System.IO.Ports.StopBits.One; //一个停止位
                serialPort2.ReadBufferSize = 1024; //接收缓冲区大小
                serialPort2.Open();
                serialPort2.DiscardInBuffer();
                serialPort2.DiscardOutBuffer();

                writeToRichTextBox(serialPort2.PortName + "打开成功");
            }
            catch (Exception)
            {
                //MessageBox.Show(serialPort2.PortName + "串口打开失败");
                //return;
                writeToRichTextBox(serialPort2.PortName + "串口打开失败");
            }
            #endregion

            #region 3号串口读取
            if (serialPort3.IsOpen)
            {
                serialPort3.Close();
            }
            key = "COMNUM3";//
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
            try
            {
                serialPort3.PortName = temp.ToString();               //端口号
                serialPort3.BaudRate = 115200;                        //陀螺仪波特率
                serialPort3.Parity = System.IO.Ports.Parity.None;     //无校验位                     
                serialPort3.StopBits = System.IO.Ports.StopBits.One;  //一个停止位
                serialPort3.ReadBufferSize = 1024;                    //接收缓冲区大小
                serialPort3.Open();
                serialPort3.DiscardInBuffer();
                serialPort3.DiscardOutBuffer();

                writeToRichTextBox(serialPort3.PortName + "打开成功");
            }
            catch (Exception)
            {
                writeToRichTextBox(serialPort3.PortName + "串口打开失败");
            }
            #endregion

            #region 4号串口读取
            if (serialPort4.IsOpen)
            {
                serialPort4.Close();
            }
            key = "COMNUM4";//
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
            try
            {
                serialPort4.PortName = temp.ToString();//
                serialPort4.BaudRate = 9600;
                serialPort4.Parity = System.IO.Ports.Parity.None;  //无校验位                     
                serialPort4.StopBits = System.IO.Ports.StopBits.One; //一个停止位
                serialPort4.ReadBufferSize = 1024; //接收缓冲区大小
                serialPort4.Open();
                serialPort4.DiscardInBuffer();
                serialPort4.DiscardOutBuffer();

                writeToRichTextBox(serialPort4.PortName + "打开成功");
            }
            catch (Exception)
            {
                //MessageBox.Show(serialPort4.PortName + "串口打开失败");
                //return;
                writeToRichTextBox(serialPort4.PortName + "串口打开失败");
            }
            #endregion
        }
        #endregion

        #region 设置串口参数
        private void Set_SerialPort()
        {
            if (serialPort2.IsOpen)
            {
                section = "PWM";
                key = "Freq";
                GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
                Serial2PcToMotor(temp.ToString());   //设置PWM频率
                key = "D1";
                GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
                Serial2PcToMotor(temp.ToString());   //设置通道1占空比
                key = "D2";
                GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
                Serial2PcToMotor(temp.ToString());   //设置通道2占空比
                key = "D3";
                GetPrivateProfileString(section, key, "读取信息失败", temp, 255, fileSerial + "\\Config\\config.ini");
                Serial2PcToMotor(temp.ToString());   //设置通道3占空比
                writeToRichTextBox("PWM参数设置成功");
            }
        }
        #endregion


        #region  辅助选项

        #region 启用MPU辅助导航
        private void MPUStartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            timerMPU.Start();
            MessageBox.Show("MPU成功启用");
        }

        private void MPUNavigation(object sender, EventArgs e)
        {            
            var mpuYaw = JY901.GetInstance().Angle[2];
            LaneDepature laneDepature=new LaneDepature();
            var d1Msg = laneDepature.MpuNavigation(mpuYaw)[0];
            var d2Msg = laneDepature.MpuNavigation(mpuYaw)[1];
            serialPort2.Write(d1Msg);
            WriteToSendTextBox(serialPort2.PortName+ d1Msg + DateTime.Now);
            serialPort2.Write(d2Msg);
            WriteToSendTextBox(serialPort2.PortName + d2Msg + DateTime.Now);
        }
        #endregion

        //实例化Socket
        Comm comm = new Comm();
        private void CameraStartToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            #region 开启Socket服务
            if (comm.StartServer())
            {
                comm.PortOpen();
                CameraStartToolStripMenuItem.Enabled = false;
                MessageBox.Show("Cammera成功启用");
            }
            

            #endregion

        }

        private void 设备2关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("辅助设备1关机成功！");
        }



        private void 设备3关机ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            //m_handler.SendADBCmd("-s " + devices3 + " shell reboot -p");
            //MessageBox.Show("辅助设备2关机成功！");
        }

        private void 错误代码过站ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 联系方式ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

