using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XIT.BSDBMessage
{
    public class BSDB232
    {
        public byte ID { get; set; }        //本机TTL232 地址,默认为0x01.若ID 不对,那本机将无响应.
        public byte CMD { get; set; }       //命令字, 分为读命令0xA0 和写命令0x51,0x52,0x54
        public byte AddrH { get; set; }     //对象地址高8位
        public byte AddrL { get; set; }     //对象地址低8位
        public byte ErrR { get; set; }      //错误报告与清除
        public byte Dat1 { get; set; }      //数据区1(,高位在前,地位在后)
        public byte Dat2 { get; set; }      //数据区2
        public byte Dat3 { get; set; }      //数据区3
        public byte Dat4 { get; set; }      //数据区4
        public byte Check { get; set; }     //校验和, Check=[Byte1~Byte9]求和取低8 位.
    }
}
