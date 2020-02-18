using M2cTool.Common.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace M2cToolite
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(!Envir.PlatformCheck)
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show("自2017年6月13日起,不再支持Windows XP/Windows 2003操作系统。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
