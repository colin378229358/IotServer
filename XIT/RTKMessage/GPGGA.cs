using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIT.RTKMessage
{
    public class GPGGA
    {
        private static GPGGA _gpgga;

        private GPGGA()
        {
        }

        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        /// 
        public static GPGGA GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (_gpgga == null)
            {
                _gpgga = new GPGGA();
            }
            return _gpgga;
        }

        public string LogHeader;                        //Log header（GPS 位置信息）
        public float UTCtime { get; set; }              //UTC时间(时/分/秒)
        public float Latitude { get; set; }            //纬度：-90~90度 纬度一般取前俩位
        public string LatitudeDir { get; set; }        //纬度方向：N：北；S：南
        public float Longitude { get; set; }            //经度：-180~180度 经度一般取前三位(在南方)
        public string LongitudeDir { get; set; }        //经度方向：E：东；W：西
        public byte MsgStatus { get; set; }             //解状态 0：无效解；1：单点定位解；2：伪距差分；4：固定解；5：浮动解；
        public byte PlanetNum { get; set; }             //卫星数
        public float DopLevel { get; set; }             //水平DOP值
        public float AntennaPlanetNum { get; set; }        //天线海拔高度
        public string AntennaUnit { get; set; }           //海拔高度单位（米）
        public float SeaPlanetNum { get; set; }            //海平面分离度
        public string SeaUnit { get; set; }             //海平面分离度单位（米）
        public byte DiffCorDelay { get; set; }     //差分校正时延（秒）
        public string ReferenceId { get; set; }         //参考站ID
        public byte Crc { get; set; }                   //校验和
    }
}
