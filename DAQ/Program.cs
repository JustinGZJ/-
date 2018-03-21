using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAQ
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (RunningInstance()==null)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                SetAutoRun(Application.ExecutablePath, true);
                Application.Run(new Daq()); 
            }
            else
            {
                MessageBox.Show(System.IO.Path.GetFileName(Application.ExecutablePath) + "已有一个实例在运行!");
            }
        }
        /// <summary>
        /// 设置应用程序开机自动运行
        /// </summary>
        /// <param name="fileName">应用程序的文件名</param>
        /// <param name="isAutoRun">是否自动运行，为false时，取消自动运行</param>
        /// <exception cref="System.Exception">设置不成功时抛出异常</exception>
        public static void SetAutoRun(string fileName, bool isAutoRun)
        {
            RegistryKey reg = null;
            try
            {
                if (!System.IO.File.Exists(fileName))
                    throw new Exception("该文件不存在!");
                String name = fileName.Substring(fileName.LastIndexOf(@"\") + 1);
                reg = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                if (reg == null)
                    reg = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
                if (isAutoRun)
                    reg.SetValue(name, fileName);
                else
                    reg.SetValue(name, false);
            }
            catch (Exception ex)
            {
               // throw new Exception(ex.ToString());
            }
            finally
            {
                if (reg != null)
                    reg.Close();
            }

        }

        public static System.Diagnostics.Process RunningInstance()
        {
            System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process process in processes.Where(p=>p.ProcessName==current.ProcessName)) //查找相同名称的进程 
            {
                if (process.Id != current.Id) //忽略当前进程 
                { //确认相同进程的程序运行位置是否一样. 
                    if (System.Reflection.Assembly.GetExecutingAssembly().Location.Replace("/", @"/") == current.MainModule.FileName)
                    { //Return the other process instance. 
                        return process;
                    }
                }
            } //No other instance was found, return null. 
            return null;
        }
    }
}
