using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace XIT
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Mutex mutex = new System.Threading.Mutex(false, "This should only Run once");
            bool running = !mutex.WaitOne(0, false);
            if (running)
            {
                MessageBox.Show("程序已经打开，不能重复打开！");
                return;
            }

            Application.ThreadException += Application_ThreadException; //UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //多线程异常
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.StackTrace + "\r\n\r\n\r\nEXCEPTION MESSAGE:" + e.Exception.Message);
            //Application.Exit();
        }        
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)e.ExceptionObject).StackTrace + "\r\n\r\n\r\nEXCEPTION MESSAGE:" + ((Exception)e.ExceptionObject).Message);
            //MessageBox.Show(((Exception)e.ExceptionObject).Message);
            //Application.Exit();
        }
    }
}
