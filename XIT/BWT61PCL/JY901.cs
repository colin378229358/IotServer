namespace XIT.BWT61PCL
{
    public class JY901
    {
        private static JY901 _jy901;

        private JY901()
        {
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        /// 
        public static JY901 GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (_jy901 == null)
            {
                _jy901 = new JY901();
            }
            return _jy901;
        }

        public short[]  ChipTime        = new short[7];     //片上时间输出
        public double[] Acceleration    = new double[4];    //加速度输出
        public double[] Palstance       = new double[4];    //角速度输出
        public double[] Angle           = new double[4];    //角度输出
        public double[] Magnetic        = new double[4];    //磁场输出
        public double[] Port            = new double[4];    //端口状态数据输出
        public double Pressure;                             //气压输出
        public double Altitude;                             //高度输出
        public long Longitude;                              //经度输出
        public long Latitude;                               //纬度输出
        public double GroundVelocity;                       //地速输出
        public double GPSYaw;                               //GPS 航向角
        public double GPSHeight;                            //GPS 高度
        public double Temperature;                          //温度输出
    }
}