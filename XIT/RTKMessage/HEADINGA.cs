using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIT.RTKMessage
{
    public class HEADINGA
    {
        private static HEADINGA _headinga;
        private HEADINGA()
        {
        }
        /// <summary>
        /// 定义公有方法提供一个全局访问点,同时你也可以定义公有属性来提供全局访问点
        /// </summary>
        /// <returns></returns>
        /// 
        public static HEADINGA GetInstance()
        {
            // 如果类的实例不存在则创建，否则直接返回
            if (_headinga == null)
            {
                _headinga = new HEADINGA();
            }
            return _headinga;
        }

        public string LogHeader;                        //Log header（GPS 位置信息）
        public float Yaw;                               //方位角(0~360)
        public float Pitch;                             //俯仰角(+90~-90)
    }
}
