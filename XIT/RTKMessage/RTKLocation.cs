using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XIT.Message
{
    public class RTKLocation
    {
        private static RTKLocation _rtklocation;

        private RTKLocation()
        {
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        /// 
        public static RTKLocation GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (_rtklocation == null)
            {
                _rtklocation = new RTKLocation();
            }
            return _rtklocation;
        }

        public int GPStime { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int MsgStatus { get; set; }
        public int PlanetNum { get; set; }
    }
}
