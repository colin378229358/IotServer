using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace XIT
{
    class AccessRW
    {
        #region 变量
        private OleDbConnection conn;//数据库连接对象
        private OleDbCommand cmd;//数据库连接指令
        string Link_str;//数据库连接字符串
        string acc_name;
        string section, key;
        string reValue;
        StringBuilder temp = new StringBuilder(255);//一个可变的字符序列
        string filename = Application.StartupPath;
        [DllImport("kernel32")]//加载读取ini文件的方法
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        Structs.ResultStr resS = new Structs.ResultStr();
        Structs.RateStr raS = new Structs.RateStr();
        Structs.RateInt raI = new Structs.RateInt();
        Structs.FailStr faS = new Structs.FailStr();
        Structs.FailInt faI = new Structs.FailInt();
        #endregion
        public AccessRW()
        {
            section = "PARA";
            key = "ACCESS";
            GetPrivateProfileString(section, key, "读取ACCESS数据库版本失败", temp, 255, filename + "\\config.ini");
            if (temp.ToString() == "2003")
            {
                Link_str = "Provider=Microsoft.Jet.OLEDB.4.0";
                acc_name = "data.mdb";
            }
            else if (temp.ToString() == "2007")
            {
                Link_str = "Provider=Microsoft.ACE.OLEDB.12.0;Mode=Share Exclusive";
                acc_name = "CIT_Backup.accdb";
            }
            resS.init();
            raI.init();
            raS.init();
            faI.init();
            faS.init();
            conn = new OleDbConnection(Link_str + ";Data Source=" + filename + "\\" + acc_name + ";Jet OLEDB:Database Password=4351");
        }
        public void openAccess()
        {
            conn.Open();//打开数据库
        }
        public void closeAccess()
        {
            conn.Close();
        }
        public void writeResult(Structs.ResultStr rs)
        {
            int cur_hour, cur_min, cur_sec, cur_day;
            cur_hour = DateTime.Now.Hour;
            cur_min = DateTime.Now.Minute;
            cur_sec = DateTime.Now.Second;
            cur_day = DateTime.Now.Day;
            // conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbpath + "\\data.accdb" + ";Jet OLEDB:Database Password=67754400");//用于打开ACCESS2003

            cmd = new OleDbCommand("insert into sheet1 (测试结果,产品名称,时间,SN,SD卡,单SIM卡,双SIM卡,NFC,闪光灯,触摸屏,震动,按键,霍尔传感器,距离传感器,光线传感器,重力传感器,气压计,指南针,陀螺仪,前摄像头,后摄像头,LCD,WIFI,蓝牙,充电,GPS,耳机插入,耳机MIC,耳机听筒,听筒,扬声器,MIC,副MIC,收音机) values('" + rs.RESULT + "','" + rs.PRODUCTNAME + "','" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + (cur_hour).ToString() + ":" + cur_min.ToString() + "','" + rs.SN + "','" + rs.SDCARD + "','" + rs.SINGLECARD + "','" + rs.DOUBLECARD + "','" + rs.NFC + "','" + rs.FLASHLIGHT + "','" + rs.TP + "','" + rs.SHOCK + "','" + rs.BUTTON + "','" + rs.HALLSENSOR + "','" + rs.PROXIMITYSENSOR + "','" + rs.LIGHTSENSOR + "','" + rs.GSENSOR + "','" + rs.BAROMATER + "','" + rs.COMPASS + "','" + rs.GYROSCOPE + "','" + rs.FRONTCAMERA + "','" + rs.BACKCAMERA + "','" + rs.LCD + "','" + rs.WIFI + "','" + rs.BT + "','" + rs.CHARGE + "','" + rs.GPS + "','" + rs.HEADSETEXIT + "','" + rs.HEADSETMIC + "','" + rs.HEADSETRECEIVER + "','" + rs.RECEIVER + "','" + rs.SPEAKER + "','" + rs.MIC + "','" + rs.SUBMIC + "','" + rs.FM + "')", conn);
            cmd.ExecuteNonQuery();
            //cmd = new OleDbCommand("insert into sheet2 (TESTNO,FIRSTPASSNO,FIRSTPASSRATE,REPEATNO,REPEATRATE,REPAIRNO,REPAIRRATE) values('1','1','1','1','1','1','1')", conn);
            //cmd.ExecuteNonQuery();

        }
        public Structs.RateInt readRate()//读rate
        {
            //适配器工作adp
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM sheet2",conn );

            //适配器将数据填充入数据集ds
            DataSet ds = new DataSet();
            ds.Clear();
            adp.Fill(ds);
            //Cl_Ds dsst = new Cl_Ds();            
            raS.COUNT = ds.Tables[0].Rows[0]["TESTNO"].ToString();//获取之前的总的测试数
            raS.FIRSTPASSNO = ds.Tables[0].Rows[0]["FIRSTPASSNO"].ToString();//获取之前的总的直通数
            raS.REPEATNO = ds.Tables[0].Rows[0]["REPEATNO"].ToString();//获取之前的总的复测数

            raI.COUNT = int.Parse(raS.COUNT);//总数
            raI.FIRSTPASSNO = int.Parse(raS.FIRSTPASSNO);//一次通过数
            raI.REPEATNO = int.Parse(raS.REPEATNO);//复测数            
            return raI;
        }
        public void writeRate(Structs.RateInt ri)//写入rate
        {
            cmd = new OleDbCommand("update sheet2 set TESTNO='" + ri.COUNT.ToString() + "',FIRSTPASSNO='" + ri.FIRSTPASSNO.ToString() + "',FIRSTPASSRATE='" + ri.FIRSTPASSRATE.ToString("0.00") + "',REPEATNO='" + ri.REPEATNO.ToString() + "', REPEATRATE='" + ri.REPEATRATE.ToString("0.00") + "'where ID=1", conn);
            cmd.ExecuteNonQuery();
        }
        public string readFail(string field)//读失败统计
        {
            string tmp;
            //适配器工作adp
            string strSQL = "";
            OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM sheet3",conn );

            //适配器将数据填充入数据集ds
            DataSet ds = new DataSet();
            ds.Clear();
            adp.Fill(ds);
            tmp = ds.Tables[0].Rows[0][field].ToString();//获取字段数据                      
            return tmp;
        }
        public void writeFail(string field, string value)//写入失败统计
        {
            cmd = new OleDbCommand("update sheet3 set " + field + "='" + value + "'where ID=1", conn);
            cmd.ExecuteNonQuery();
        }
    }
}