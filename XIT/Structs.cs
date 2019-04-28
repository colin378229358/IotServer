using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XIT
{
    class Structs
    {
        public struct ResultStr //测试结果
        {
            //1标示通过0标示失败2，N标示未测试
            public string RESULT;
            public string PRODUCTNAME;
            public string TIME;
            public string SN;
            public string SDCARD;
            public string SINGLECARD;
            public string DOUBLECARD;
            public string NFC;
            public string FLASHLIGHT;
            public string TP;
            public string SHOCK;
            public string BUTTON;
            public string HALLSENSOR;
            public string PROXIMITYSENSOR;//距感
            public string LIGHTSENSOR;
            public string PSENSORCAL;//距感校准
            public string GSENSOR;            
            public string GYROSCOPE;//陀螺仪
            public string COMPASS;
            public string BAROMATER;//气压计
            public string FRONTCAMERA;
            public string BACKCAMERA;
            public string LCD;
            public string WIFI;
            public string BT;
            public string CHARGE;
            public string GPS;
            public string HEADSETMIC;
            public string HEADSETRECEIVER;
            public string HEADSETEXIT;
            public string RECEIVER;
            public string SPEAKER;
            public string MIC;
            public string SUBMIC;
            public string FM;
            public void init()
            {
                string i = "N";
                RESULT = i;
                PRODUCTNAME = i;
                TIME = i;
                SN = i;
                SDCARD = i;
                SINGLECARD = i;
                DOUBLECARD = i;
                NFC = i;
                FLASHLIGHT = i;
                TP = i;
                SHOCK = i;
                BUTTON = i;
                HALLSENSOR = i;
                PROXIMITYSENSOR = i;
                LIGHTSENSOR = i;
                PSENSORCAL = i;
                GSENSOR = i;
                GYROSCOPE = i;
                COMPASS = i;
                BAROMATER = i;
                FRONTCAMERA = i;
                BACKCAMERA = i;
                LCD = i;
                WIFI = i;
                BT = i;
                CHARGE = i;
                GPS = i;
                HEADSETMIC = i;
                HEADSETRECEIVER = i;
                HEADSETEXIT = i;
                RECEIVER = i;
                SPEAKER = i;
                MIC = i;
                SUBMIC = i;
                FM = i;
            }
        }
        public struct RateStr//统计
        {
            public string COUNT;
            public string FIRSTPASSNO;
            public string FIRSTPASSRATE;
            public string REPEATNO;
            public string REPEATRATE;
            public void init()
            {
                string i = "";
                COUNT = i;
                FIRSTPASSNO = i;
                FIRSTPASSRATE = i;
                REPEATNO = i;
                REPEATRATE = i;
            }
        }
        public struct RateInt//统计
        {
            public int COUNT;
            public int FIRSTPASSNO;
            public double FIRSTPASSRATE;
            public int REPEATNO;
            public double REPEATRATE;
            public void init()
            {
                int i = 0;
                double j = 0.000;
                COUNT = i;
                FIRSTPASSNO = i;
                FIRSTPASSRATE = j;
                REPEATNO = i;
                REPEATRATE = j;
            }
        }
        public struct FailInt//统计S
        {
            public int NAME;
            public int COUNT;
            public int SN;
            public int SDCARD;
            public int SINGLECARD;
            public int DOUBLECARD;
            public int NFC;
            public int FLASHLIGHT;
            public int TP;
            public int SHOCK;
            public int BUTTON;
            public int HALLSENSOR;
            public int PROXIMITYSENSOR;
            public int LIGHTSENSOR;
            public int PSENSORCAL;
            public int GSENSOR;
            public int GYROSCOPE;
            public int COMPASS;
            public int BAROMATER;
            public int FRONTCAMERA;
            public int BACKCAMERA;
            public int LCD;
            public int WIFI;
            public int BT;
            public int CHARGE;
            public int GPS;
            public int HEADSETMIC;
            public int HEADSETRECEIVER;
            public int RECEIVER;
            public int MIC;
            public int SUBMIC;
            public int FM;
            public void init()
            {
                int i = 0;
                NAME = i;
                COUNT = i;
                SN = i;
                SDCARD = i;
                SINGLECARD = i;
                DOUBLECARD = i;
                NFC = i;
                FLASHLIGHT = i;
                TP = i;
                SHOCK = i;
                BUTTON = i;
                HALLSENSOR = i;
                PROXIMITYSENSOR = i;
                LIGHTSENSOR = i;
                PSENSORCAL = i;
                GSENSOR = i;
                GYROSCOPE = i;
                COMPASS = i;
                BAROMATER = i;
                FRONTCAMERA = i;
                BACKCAMERA = i;
                LCD = i;
                WIFI = i;
                BT = i;
                CHARGE = i;
                GPS = i;
                HEADSETMIC = i;
                HEADSETRECEIVER = i;
                RECEIVER = i;
                MIC = i;
                SUBMIC = i;
                FM = i;
            }
        }
        public struct FailStr//统计S
        {
            public string NAME;
            public string COUNT;
            public string SN;
            public string SDCARD;
            public string SINGLECARD;
            public string DOUBLECARD;
            public string NFC;
            public string FLASHLIGHT;
            public string TP;
            public string SHOCK;
            public string BUTTON;
            public string HALLSENSOR;
            public string PROXIMITYSENSOR;
            public string LIGHTSENSOR;
            public string PSENSORCAL;
            public string GSENSOR;
            public string GYROSCOPE;
            public string COMPASS;
            public string BAROMATER;
            public string FRONTCAMERA;
            public string BACKCAMERA;
            public string LCD;
            public string WIFI;
            public string BT;
            public string CHARGE;
            public string GPS;
            public string HEADSETMIC;
            public string HEADSETRECEIVER;
            public string RECEIVER;
            public string MIC;
            public string SUBMIC;
            public string FM;
            public void init()
            {
                string i = "";
                NAME = i;
                COUNT = i;
                SN = i;
                SDCARD = i;
                SINGLECARD = i;
                DOUBLECARD = i;
                NFC = i;
                FLASHLIGHT = i;
                TP = i;
                SHOCK = i;
                BUTTON = i;
                HALLSENSOR = i;
                PROXIMITYSENSOR = i;
                LIGHTSENSOR = i;
                PSENSORCAL = i;
                GSENSOR = i;
                GYROSCOPE = i;
                COMPASS = i;
                BAROMATER = i;
                FRONTCAMERA = i;
                BACKCAMERA = i;
                LCD = i;
                WIFI = i;
                BT = i;
                CHARGE = i;
                GPS = i;
                HEADSETMIC = i;
                HEADSETRECEIVER = i;
                RECEIVER = i;
                MIC = i;
                SUBMIC = i;
                FM = i;
            }
        }
    }
}
