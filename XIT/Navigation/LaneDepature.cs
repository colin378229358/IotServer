using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIT.IOMessage;

namespace XIT.Navigation
{
    public class LaneDepature
    {
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        private readonly string _fileSerial = Application.StartupPath;
        private string section;
        private string key;
        StringBuilder temp = new StringBuilder(255);//一个可变的字符序列
        public LaneDepature()
        {            
            section = "MPU";
            key     = "Yaw";            
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, _fileSerial + "\\Config\\config.ini");
            Yaw = double.Parse(temp.ToString());

            key = "YawOffset";
            GetPrivateProfileString(section, key, "读取信息失败", temp, 255, _fileSerial + "\\Config\\config.ini");
            YawOffset = double.Parse(temp.ToString());
        }

        private double Yaw   { set; get; }  //偏航角,表示机头偏离正北方多少度，范围-180到+180；
        private double YawOffset { set; get; }
        private double Pitch { set; get; }  //俯仰角，表示机头正方向与水平线的夹角，范围-90到+90
        private double Roll  { set; get; }  //翻滚角，表示机翼与水平线的夹角，范围：-180到+180
                
        public string[] MpuNavigation(double mpuYaw)
        {
            string[] pwmMsg=new string[2];
            if ((mpuYaw - Yaw) > YawOffset)     //机器人东偏
            {
                //pwmMsg[0] = "D1:085";
                //pwmMsg[1] = "D3:080";
                pwmMsg[0] = "D1:080";
                pwmMsg[1] = "D3:085";
                return pwmMsg;
            }
            else if((mpuYaw - Yaw)< -YawOffset) //机器人西偏
            {
                //pwmMsg[0] = "D1:080";
                //pwmMsg[1] = "D3:085";
                pwmMsg[0] = "D1:085";
                pwmMsg[1] = "D3:080";
            }
            else 
            {
                pwmMsg[0] = "D1:085";
                pwmMsg[1] = "D3:085";
            }
            return pwmMsg;
       }
    }
}
