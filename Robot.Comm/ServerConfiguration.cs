using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot.Comm
{
    public class ServerConfiguration
    {
        private ServerConfiguration() { }
        public static readonly ServerConfiguration Instance = new ServerConfiguration();
        public int ServerPort
        {
            get
            {
                string p = ConfigApp.GetValue("ServerPort");
                return int.Parse(p);
            }
        }
        public int MaxSessionCount
        {
            get
            {
                string p = ConfigApp.GetValue("MaxSessionCount");
                return int.Parse(p);
            }
        }
        public int SessionTimeout
        {
            get
            {
                string p = ConfigApp.GetValue("SessionTimeout");
                return int.Parse(p);
            }
        }
        public int MaxDatagramSize
        {
            get
            {
                string p = ConfigApp.GetValue("MaxDatagramSize");
                return int.Parse(p);
            }
        }
        public int ReceiveBufferSize
        {
            get
            {
                string p = ConfigApp.GetValue("ReceiveBufferSize");
                return int.Parse(p);
            }
        }
        public int SendBufferSize
        {
            get
            {
                string p = ConfigApp.GetValue("SendBufferSize");
                return int.Parse(p);
            }
        }
        public int CtrlRxTimeout
        {
            get
            {
                string p = ConfigApp.GetValue("CtrlRxTimeout");
                return int.Parse(p);
            }
        }
        public int CrcCheck
        {
            get
            {
                string p = ConfigApp.GetValue("CrcCheck");
                return int.Parse(p);
            }
        }
        public int LoginCheck
        {
            get
            {
                string p = ConfigApp.GetValue("LoginCheck");
                return int.Parse(p);
            }
        }
        public int EnableDB
        {
            get
            {
                string p = ConfigApp.GetValue("dbEnable");
                return int.Parse(p);
            }
        }

        public int PageSize
        {
            get
            {
                string p = ConfigApp.GetValue("PageSize");
                return int.Parse(p);
            }
        }


        public int TaskSys
        {
            get
            {
                string p = ConfigApp.GetValue("TaskSys");
                return int.Parse(p);
            }
        }
    }
}
