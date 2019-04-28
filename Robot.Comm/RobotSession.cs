using System;
using System.Net;
using System.Text;
using FrameWork.SocketServer;
using Robot.Provider.Model;

namespace Robot.Comm
{
    public class RobotSession : SessionBase
    {
        #region 小车状态
        private CartStatus _cartStatus = null;
        public CartStatus CartStatus
        {
            get { return _cartStatus; }
            set { _cartStatus = value; }
        }
        #endregion

        public string DevType = null;
        //包分隔符 *
        private static readonly byte[] FHEAD = {42};
        protected override void AnalyzeDatagram(byte[] datagramBytes)
        {
            //throw new NotImplementedException();
            base.OnDatagramAccepted();  // 接收到一个完整的数据包
            string dat = Encoding.UTF8.GetString(datagramBytes);
            try
            {

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected override void ResolveSessionBuffer(int readBytesLength)
        {
            try
            {
                ////帧头标志
                //bool hasHeadDelimiter = false;

                //int bufferOffset = _bufferManager.GetReceivevBufferOffset(_bufferBlockIndex);
                //int subIndex     = bufferOffset;                    // 缓冲区下标
                //int endIndex     = bufferOffset + readBytesLength;  //缓冲区数据结束位置
                ////写入日志
                //LogHelper.WriteRx(_receiveBuffer, subIndex, readBytesLength);
                //while (subIndex + 1 < endIndex)
                //{
                //    //预判是否已有包头
                //    if (_datagramBuffer != null)
                //    {
                //        if (_datagramBuffer.Length == 1) //报文缓冲区仅有一个字节'*'
                //        {
                //            hasHeadDelimiter = true;
                //        }
                //    }

                //}             
                    this.CopyToDatagramBuffer(1, readBytesLength);
                return;
            }
            catch
            {
                throw;
            }
        }
    }
}
