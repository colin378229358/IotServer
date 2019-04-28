using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Robot.Comm;
using Robot.IService;

namespace Robot.Sys
{
    public partial class Form1 : Form
    {
        #region 业务模型变量
        IRobotsManagerService _robotsManagerService = null;
        #endregion

        //小车实例集合
        Dictionary<int, RobotSession> _dic = null;
        //ServerConfiguration _config = ServerConfiguration.Instance;

        public Form1()
        {
            #region 逻辑处理层实例参数
            try
            {
                _robotsManagerService = Program.builder.Resolve<IRobotsManagerService>();
            }
            catch (Exception ex)
            {
               // LogHelper.Write("监控服务器错误!" + ex.Message + ex.StackTrace);
                MessageBox.Show("监控服务器错误!");
            }
            #endregion
            InitializeComponent();
            //LogHelper.ShowLogFunc = ShowLog;
        }

        #region 添加txtLog日志
        private void ShowLog(string msg)
        {
            try
            {
                if (InvokeRequired)
                {
                    //textBox_log.Invoke(new ShowLogDelegate(AddToTextBox), msg);
                }
                else
                {
                    AddToTextBox(msg);
                }

            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return;
            }
        }

        private void AddToTextBox(string msg)
        {
            string strNewData = "[" + DateTime.Now.ToString("HH:mm:ss.fff") + "]: ";
            strNewData += msg + "\r\n";
            if (textBox_log.Lines.Length > 10)
            {
                string tmpStr = null;
                for (int index = textBox_log.Lines.Length - 10; index < textBox_log.Lines.Length; index++)
                {
                    if (textBox_log.Lines[index].Trim() != "")
                    {
                        tmpStr += textBox_log.Lines[index] + "\r\n";
                    }
                }
                textBox_log.Text = tmpStr + strNewData;
            }
            else
            {
                textBox_log.Text = textBox_log.Text + strNewData;
            }
            textBox_log.SelectionStart = textBox_log.Text.Length;

            //将控件内容滚动到当前插入符号位置
            textBox_log.ScrollToCaret();

        }
        #endregion

        #region 初始化系统信息
        private void btnInitialize_Click(object sender, EventArgs e)
        {
            try
            {
                InitalzeSys();
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化服务器失败!");
                //LogHelper.Write(LogType.Error, ex);
            }
        }

        private void InitalzeSys()
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region  启动服务
        private void btnSysStart_Click(object sender, EventArgs e)
        {
            try
            {
                bool ret = _robotsManagerService.StartServer();
                //_dic = _agvsManagerService.GetSessionTable();
                if (!ret)
                {          
                    MessageBox.Show("启动服务器失败!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ShowLog("启动服务器失败!");
                    return;
                }
                else
                {

                    button_Start.Enabled = false;
                    button_Init.Enabled  = false;
                    button_Stop.Enabled  = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动服务器失败!");
            }
        }

        #endregion

        #region 关闭服务
        private void btnSysClose_Click(object sender, EventArgs e)
        {
            try
            {
                _robotsManagerService.StopServer();
                button_Stop.Enabled  = false;
                button_Start.Enabled = true;
                button_Init.Enabled  = true;
                //foreach (ToolStripMenuItem item in MainMenuStrip.Items)
                //{
                //    if (item.Text != "日志查询")
                //    {
                //        item.Enabled = true;
                //    }

                //}
            }
            catch (Exception ex)
            {
                ShowLog("关闭服务器错误!");
                MessageBox.Show("关闭服务器错误!");
            }
        }
        #endregion
    }
}
