using System;
using System.IO;
using System.Windows.Forms;
using M2cTool.Common.Framework;
using M2cToolite.Properties;

namespace M2cToolite
{
    public partial class MainForm : Form
    {
        readonly string configFile = AppDomain.CurrentDomain.BaseDirectory + "M2cToolite.ini";
        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.M2;
            M2cObject.InitializeConfig(configFile);
            InitializeM2cToolite();
        }
        private void InitializeM2cToolite()
        {
            if (M2cObject.GetMirServerDir(configFile) != string.Empty)
            {
                if (File.Exists(M2cObject.GetMirServerDir(configFile) + M2cConst.Setup))
                {
                    Text = $"M2配置工具({M2cObject.GetMirServerDir(configFile)})";
                }
                else
                {
                   
                }


            }
            else
            {
                Text = "M2配置工具(未配置..)";
            }
        }
        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ShowDialog();
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Func_MerChant_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MerChant);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Func_Npcs_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.NpcsConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_QManage_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.QManage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_QFunction_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.QFunction);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_AutoRunRobot_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.AutoRunRobot);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_RobotManage_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.RobotManage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MonGen_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MonGen);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Mapinfo_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Mapinfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MiniMap_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MiniMap);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Setup_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Setup);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_String_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.StringFiles);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_StartPoint_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.StartPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MapMagicEvent_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MapMagicEvent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MapEvent_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MapEvent);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Command_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.GameCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_SabukW_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.SabukWConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_AttackSabukWall_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.AttackSabukWall);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_AdminList_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.AdminList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MapQuest_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MapQuest);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MonSayMsg_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MonSayMsg);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_UserCmd_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.UserCmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_GuardList_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.GuardList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_GlobalVal_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.GlobalVal);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_UnbindList_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.UnbindList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Exps_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.ExpsConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Abuse_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.AbuseConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_NoClearMonList_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.NoClearMonList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MonDropLimitList_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MonDropLimitList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MapDesc_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.MapDesc);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Qmission_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Qmission);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MonItems_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_MonItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_QuestDiary_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_QuestDiary);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_GuildBase_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_GuildBase);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Market_def_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_MarketDef);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Npc_Def_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_NpcDef);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Notice_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_Notice);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Map_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_Map);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Envir_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_Envir);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_UserData_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_UserData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_MonUseItems_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_MonUseItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_Boxs_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.Folder_Boxs);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Func_UserCmdEngine_Click(object sender, EventArgs e)
        {
            try
            {
                M2cObject.Open(M2cObject.GetMirServerDir(configFile), M2cConst.UserCmdEngine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolStripMenuItem_SetMirServerDir_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "无特殊情况,尽量选择完整的 MirServer 服务端。";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(dialog.SelectedPath + M2cConst.Setup))
                    {
                        IniFiles.Set("Settings", "MirServerDir", dialog.SelectedPath, configFile);
                        Text = $"M2cToolite({M2cObject.GetMirServerDir(configFile)})";
                    }
                    else
                    {
                        if(MessageBox.Show($"此目录未能检测到相关配置文件。", "错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)== DialogResult.Retry)
                        {
                            ToolStripMenuItem_SetMirServerDir_Click(sender, e);
                        }
                    }
                }
            }
        }
    }
}
