using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Robot.Comm;

namespace Robot.Sys
{
    static class Program
    {
        public static IContainer builder;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DependencyRegistrar dependencyregister = new DependencyRegistrar(Assembly.GetExecutingAssembly());
                builder = dependencyregister.DataRegister();

                bool blnIsRunning;
                Mutex mutexApp = new Mutex(false, Assembly.GetExecutingAssembly().FullName, out blnIsRunning);
                if (!blnIsRunning)
                {
                    MessageBox.Show("程序已经运行！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).ToList().Count > 1)
                {
                    MessageBox.Show("程序已经运行！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {

                //LogHelper.Write(LogType.Error, "程序出现异常错误:{0}", ex.Message + ex.StackTrace);
            }


        }
    }
}
