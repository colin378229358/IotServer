using System;
using System.Collections.Generic;
using FrameWork.SocketServer;
using Robot.Comm;
using Robot.IService;

namespace Robot.Service
{
    public class RobotsManagerService : IRobotsManagerService
    {
        #region 公共变量
        /// <summary>
        /// Socket服务器对象
        /// </summary>
        TcpSocketServer<RobotSession> _socketServer = null;

        /// <summary>
        /// 配置文件数据
        /// </summary>
        private readonly ServerConfiguration _config = ServerConfiguration.Instance;
        #endregion

        #region 自动处理预约任务
        public void AutoExceTaskOrder()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 根据小车名称启动小车
        public bool CartStartByCartName(string cartName)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 根据小车名称停止小车
        public bool CartStopByCartName(string cartName)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 任务控制指令（暂停，恢复，停止任务)
        public bool CtrlTaskByOrderId(int orderId, string cartName, int ctrlType)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region 获取当前所有设备
        public Dictionary<int, RobotSession> GetSessionTable()
        {
            if (_socketServer != null)
            {
                return _socketServer.SessionTable;
            }
            return null;
        }
        #endregion

        #region 服务器启动
        public bool StartServer()
        {
            try
            {
                //构造服务器
                //_socketServer = new TcpSocketServer<RobotSession>(
                //_config.ServerPort, _config.MaxSessionCount, _config.SessionTimeout,
                //_config.MaxDatagramSize, _config.ReceiveBufferSize, _config.SendBufferSize);
                _socketServer = new TcpSocketServer<RobotSession>(2000,1000,300,10240, 10240, 8192);

                // 注册服务器事件
                AttachServerEvent();
                //启动服务器
                if (_socketServer.Start())
                {
                    //LogHelper.Write(LogType.Info, "启动通信服务成功");
                }
                else
                {
                    //LogHelper.Write(LogType.Info, "启动通信服务失败");
                    this.StopServer();
                }
                return true;
            }
            catch (System.Exception ex)
            {
               // LogHelper.Write(LogType.Error, "服务启动失败！" + ex.Message);
                //this.StopServer();
                return false;
            }
        }
        #endregion

        #region 服务器关闭
        public void StopServer()
        {
            try
            {
                if (_socketServer == null)
                {
                    return;
                }

                //挂起所有会话
                _socketServer.CloseAllSessions();
                //关闭服务
                _socketServer.Stop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region 服务器事件处理
        private void AttachServerEvent()
        {
            _socketServer.ServerStarted                   += this.SocketServer_Started;
            _socketServer.ServerClosed                    += this.SocketServer_Stoped;
            _socketServer.ServerException                 += this.SocketServer_Exception;
            _socketServer.ShowDebugMessage                += this.ShowDebugMessage;             //重要
            _socketServer.SessionRejected                 += this.SocketServer_SessionRejected;
            _socketServer.SessionConnected                += this.SocketServer_SessionConnected;
            _socketServer.SessionDisconnected             += this.SocketServer_SessionDisconnected;
            _socketServer.SessionReceiveException         += this.SocketServer_SessionReceiveException;
            _socketServer.SessionSendException            += this.SocketServer_SessionSendException;
            _socketServer.SessionProcessDatagramException += this.SocketServer_ProcessDatagramException;
            _socketServer.SessionTimeout                  += this.SocketServer_SessionTimeout;
            _socketServer.DatagramDelimiterError          += this.SocketServer_DatagramDelimiterError;
            _socketServer.DatagramOversizeError           += this.SocketServer_DatagramOversizeError;
            _socketServer.DatagramAccepted                += this.SocketServer_DatagramReceived;
            _socketServer.DatagramError                   += this.SocketServer_DatagramrError;
            _socketServer.DatagramHandled                 += this.SocketServer_DatagramHandled;
            _socketServer.DatagramProcessed               += this.SocketServer_DatagramProcessed;
            _socketServer.ClientLogged                    += this.SocketServer_ClientLogged;
        }
        private void SocketServer_Started(object sender, EventArgs e)
        {
            //LogHelper.Write(LogType.Info, "通信服务启动成功！");
        }
        private void SocketServer_Stoped(object sender, EventArgs e)
        {
            //LogHelper.Write(LogType.Info, "通信服务已关闭！");
        }
        private void SocketServer_Exception(object sender, ExceptionEventArgs e)
        {
            string text = "服务器发生异常！" + e.ExceptionMessage;
            //LogHelper.Write(LogType.Info, text);
            StopServer();
        }
        private void ShowDebugMessage(object sender, ExceptionEventArgs e)
        {
            //LogHelper.Write(LogType.Debug, "DBG MSG:{0}", e.ExceptionMessage);
        }
        private void SocketServer_SessionConnected(object sender, SessionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "收到新连接:ID:{0} IP:{1}", s.ID, s.IP);
        }
        private void SocketServer_SessionRejected(object sender, SocketEventArgs e)
        {
            //LogHelper.Write(LogType.Info, "拒绝连接:{0}", e.SocketInfo.RemoteEndPoint);
        }
        private void SocketServer_SessionDisconnected(object sender, SessionEventArgs e)
        {
            #region 会话结束处理
            
            #endregion
        }
        private void SocketServer_SessionReceiveException(object sender, SessionExceptionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "接收数据异常:ID:{0} IP:{1} Time:{2} 状态:{3} User:{4} 异常原因:{5}",
             //   s.ID, s.IP, s.LastSessionTime, s.State, s.UserName, e.ExceptionMessage);
        }
        private void SocketServer_SessionSendException(object sender, SessionExceptionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "数据发送异常:ID:{0} IP:{1} Time:{2} 状态:{3} User:{4} 异常原因:{5}",
                s.ID, s.IP, s.LastSessionTime, s.State, s.UserName, e.ExceptionMessage);
        }
        private void SocketServer_ProcessDatagramException(object sender, SessionExceptionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "报文处理异常:ID:{0} IP:{1} Time:{2} 状态:{3} User:{4} 异常原因:{5}",
                s.ID, s.IP, s.LastSessionTime, s.State, s.UserName, e.ExceptionMessage + e.StackTrace);
        }
        private void SocketServer_SessionTimeout(object sender, SessionEventArgs e)
        {
            #region pending 会话断开处理

            #endregion
        }
        private void SocketServer_DatagramDelimiterError(object sender, SessionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "DatagramDelimiterError:ID:{0} IP:{1}", s.ID, s.IP);
        }
        private void SocketServer_DatagramOversizeError(object sender, SessionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "DatagramOversizeError:ID:{0} IP:{1}", s.ID, s.IP);
        }
        private void SocketServer_DatagramReceived(object sender, SessionEventArgs e)
        {

        }
        private void SocketServer_DatagramrError(object sender, SessionEventArgs e)
        {
            Session s = e.SessionBaseInfo;
            //LogHelper.Write(LogType.Info, "DatagramrError:ID:{0} IP:{1}", s.ID, s.IP);
        }
        private void SocketServer_DatagramHandled(object sender, SessionEventArgs e)
        {
            #region 报文处理完毕--更新状态会话时间
            
            #endregion
        }

        private void SocketServer_DatagramProcessed(object sender, SessionEventArgs e)
        {
            #region 指令成功解析事件

            RobotSession s = (RobotSession) e.SessionBaseInfo;

            #endregion
        }
        private void SocketServer_ClientLogged(object sender, SessionEventArgs e)
        {
            #region 设备登录成功
            try
            {
                RobotSession s = (RobotSession)e.SessionBaseInfo;

                lock (this)
                {

                    //LogHelper.Write(LogType.Info, "设备登录成功:ID:{0} IP:{1} User:{2}", s.ID, s.IP, s.UserName);
                    int oldSessionID = -1; // 与本设备名称相同的会话ID

                }
            }
            catch (System.Exception ex)
            {
                //LogHelper.Write(LogType.Error, "设备登录异常" + ex.Message + ex.StackTrace);
            }
            #endregion
        }
        #endregion

        #region 用户登录
        private void UserLogin(RobotSession s, ref int oldSessionIDr)
        {

        }
        #endregion

    }
}
