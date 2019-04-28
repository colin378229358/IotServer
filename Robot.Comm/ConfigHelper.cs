using System.Configuration;
using System.Xml;

namespace Robot.Comm
{
    public class ConfigApp
    {
        /// <summary>
        /// 写入值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        //public static void SetValue(string newKey, string newValue)
        //{
        //    string file = System.Windows.Forms.Application.ExecutablePath;
        //    Configuration config = ConfigurationManager.OpenExeConfiguration(file);
        //    bool exist = false;
        //    foreach (string key in config.AppSettings.Settings.AllKeys)
        //    {
        //        if (key == newKey)
        //        {
        //            exist = true;
        //        }
        //    }
        //    if (exist)
        //    {
        //        config.AppSettings.Settings.Remove(newKey);
        //    }
        //    config.AppSettings.Settings.Add(newKey, newValue);
        //    config.Save(ConfigurationSaveMode.Modified);
        //    ConfigurationManager.RefreshSection("appSettings");
        //}


        /// <summary>
        /// 读取指定key的值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

        //public string GetValueServiceTime(string key)
        //{
        //    string p = null;
        //    XmlDocument doc = new XmlDocument();
        //    string path = System.Windows.Forms.Application.StartupPath + "\\ServiceTime.xml";
        //    doc.Load(path);    //加载Xml文件  

        //    XmlNodeList nodelist = doc.SelectSingleNode("ServiceTime").ChildNodes;
        //    foreach (XmlNode xn in nodelist)
        //    {
        //        if (xn.Name == key)
        //        {
        //            p = xn.InnerText;
        //        }
        //    }

        //    return p;
        //}


        //public void SetValueServiceTime(string key, string Value)
        //{


        //    XmlDocument doc = new XmlDocument();
        //    string path = System.Windows.Forms.Application.StartupPath + "\\ServiceTime.xml";
        //    doc.Load(path);    //加载Xml文件  

        //    XmlNodeList nodelist = doc.SelectSingleNode("ServiceTime").ChildNodes;
        //    foreach (XmlNode xn in nodelist)
        //    {
        //        if (xn.Name == key)
        //        {
        //            xn.InnerText = Value;
        //            doc.Save(path);
        //        }
        //    }

        //}

    }
}
