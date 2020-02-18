using M2cTool.Common.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M2cToolite
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            string versionstring = $"{ M2cObject.GetVersion(Application.ExecutablePath, Properties.Resources.ProductVersionString)}";
            Label_Version.Text = ($"程序版本 {versionstring}");
            //MessageBox.Show($"{versionstring}\r\nQQ交流群:1001276925\r\n轻量级的 MirServer 版本修改工具。\r\n在绝大多数情况下，它都能很好的完成你对 MirServer 的日常操作。", "关于", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void LinkLabel_QQgroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("?","?");
        }
    }
}
