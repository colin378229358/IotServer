using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XIT.TYMessage
{
    public class TY232
    {
        public byte ID { get; set; }        //设备地址
        public byte CMD { get; set; }       //命令号
        public byte AddrH { get; set; }     //寄存器地址高8位
        public byte AddrL { get; set; }     //寄存器地址低8位
        public byte Dat1 { get; set; }      //下置数据个数高8位
        public byte Dat2 { get; set; }      //下置数据个数低8位
        public byte Dat3 { get; set; }      //下置数据字节数
        public byte Dat4 { get; set; }      //下置的数据高8位
        public byte Dat5 { get; set; }      //下置的数据低8位
        public byte Crc { get; set; }     

    }

}
