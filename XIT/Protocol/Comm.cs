using System;
using System.IO.Ports;
using System.Windows.Forms;
using Robot.Comm;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Config;
using SuperSocket.SocketBase.Protocol;
using SuperSocketTest;

namespace SocketServer.Protocol
{
    public class Comm
    {
        #region  SocketServer配置
        MySocketServer mySocketServer = new MySocketServer();
        ServerConfig serverConfig     = new ServerConfig();

        #region 启动通信配置
        public bool StartServer()
        {
            serverConfig.Ip   = "";
            serverConfig.Port = 7000;

            if (mySocketServer.Setup(serverConfig))
            {

            }
            else
            {
                return false; ;
            }

            if (mySocketServer.Start())
            {
                LogHelper.WriteLog("Server  OK!");
            }
            else
            {
                return false;
            }

            mySocketServer.NewSessionConnected += new SessionHandler<MySession>(MyServer_NewSessionConnected);
            mySocketServer.NewRequestReceived  += new RequestHandler<MySession, StringRequestInfo>(MyServer_NewRequestReceived);
            return true;
        }

        void MyServer_NewSessionConnected(MySession session)
        {
            if (session.Connected)
            {
                session.Send("Welcome Sweet Robot");

                LogHelper.WriteLog(session.RemoteEndPoint.ToString());
            }
        }

        //帧头*,帧尾#
        void MyServer_NewRequestReceived(MySession session, StringRequestInfo requestInfo)
        {
            SerialPort_DataSend("hello");
            LogHelper.WriteLog(requestInfo.Body);
        }
        #endregion
        #endregion


        #region UART配置

                private System.IO.Ports.SerialPort spSerialPort=new SerialPort();
              
                private Int32 Baund = 9600;
                private bool bClosing = false;
                private bool bListening = false;

                public void PortOpen()
                {
                    spSerialPort.PortName ="COM1";
                    spSerialPort.BaudRate = Baund;
                    spSerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
                    spSerialPort.Open();
                }
    
                private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
                {

                }

                private sbyte SerialPort_DataSend(string str)
                {
                    if (spSerialPort.IsOpen == false)
                    {
                        return -1;
                    }
                    try
                    {
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
    }
}