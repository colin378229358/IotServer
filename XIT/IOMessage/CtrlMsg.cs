namespace XIT.IOMessage
{
    public class CtrlMsg
    {
        private static CtrlMsg _ctrlMsg;
        private CtrlMsg()
        {
        }

        public static CtrlMsg GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (_ctrlMsg == null)
            {
                _ctrlMsg = new CtrlMsg();
            }
            return _ctrlMsg;
        }

        public string Ahead = "*AHEAD#";        //机器人前进
        public string Back  = "*BACK#";         //机器人后退
        public string Left  = "*LEFT#";         //机器人向左
        public string Right = "*RIGHT#";        //机器人向右
        public string Stop  = "*STOP#";         //机器人停止
        public string Up    = "*UP#";           //电动推杆向上
        public string Down  = "*DOWN#";         //电动推杆向下
        public string Stay  = "*STAY#";         //电动推杆保持

        public string Out1On   = "*OUT1_ON#";
        public string Out1Off  = "*OUT1_OFF#";
        public string Out2On   = "*OUT2_ON#";
        public string Out2Off  = "*OUT2_OFF#";
        public string Out3On   = "*OUT3_ON#";
        public string Out3Off  = "*OUT3_OFF#";
        public string Out4On   = "*OUT4_ON#";
        public string Out4Off  = "*OUT4_OFF#";
        public string Out5On   = "*OUT5_ON#";
        public string Out5Off  = "*OUT5_OFF#";
        public string Out6On   = "*OUT6_ON#";
        public string Out6Off  = "*OUT6_OFF#";
        public string Out7On   = "*OUT7_ON#";
        public string Out7Off  = "*OUT7_OFF#";
        public string Out8On   = "*OUT8_ON#";
        public string Out8Off  = "*OUT8_OFF#";
        public string Out9On   = "*OUT9_ON#";
        public string Out9Off  = "*OUT9_OFF#";
        public string Out10On  = "*OUT10_ON#";
        public string Out10Off = "*OUT10_OFF#";
        public string Out11On  = "*OUT11_ON#";
        public string Out11Off = "*OUT11_OFF#";
        public string Out12On  = "*OUT12_ON#";
        public string Out12Off = "*OUT12_OFF#";
        public string Out13On  = "*OUT13_ON#";
        public string Out13Off = "*OUT13_OFF#";
        public string Out14On  = "*OUT14_ON#";
        public string Out14Off = "*OUT14_OFF#";
        public string Out15On  = "*OUT15_ON#";
        public string Out15Off = "*OUT15_OFF#";
    }
}
