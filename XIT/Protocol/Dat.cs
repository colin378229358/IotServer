using System.Collections.Generic;

namespace SocketServer.Protocol
{
    public class Dat
    {
        public static readonly Dat Content = new Dat();

        public Dictionary<string, string> DB2Type = new Dictionary<string, string>();
        public Dictionary<string, string> Messages = new Dictionary<string, string>();
        //public Dictionary<string, Message> Messages = new Dictionary<string, Message>();
    }
}