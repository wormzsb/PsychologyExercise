using System;
using System.Windows.Forms;
using PsyEx.Mapper;
using System.Collections.Generic;
using System.IO;
using PsyEx.Forms;
using PsyEx.Util;
using System.Runtime.InteropServices;


namespace PsyEx
{
    public partial class MainForm : Form
    {
        //用户、实验、硬件配置标识
        public static bool userFlag = false;
        public static bool exFlag = false;
        public static bool hwFlag = false;
        public static Tester tester = new Tester();
        public static List<ExConfig> exConfigList = new List<ExConfig>();
        public static HDConfig hdConfig = new HDConfig();
        public static string print = "";
        


        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<string> strList = TextContribute.printMainInfo(userFlag, exFlag, hwFlag);
            foreach (string str in strList)
            {
                textBox1.Text += Environment.NewLine + str;
            }

        }

        private void experimentSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //被试信息
        private void button1_Click(object sender, EventArgs e)
        {
            TesterInfo testerInfo = new TesterInfo();
            testerInfo.ShowDialog();
        }

        //实验配置
        private void button3_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                ExpSettingForm expSetting = new ExpSettingForm();
                expSetting.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //退出按钮
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //菜单退出
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //硬件配置
        private void button2_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                HardwareSetting hdForm = new HardwareSetting();
                hdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //硬件配置-菜单
        private void HDConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                HardwareSetting hdForm = new HardwareSetting();
                hdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //新建被试-菜单
        private void NewTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tester = new Tester();
            userFlag = false;
            TesterInfo testerInfo = new TesterInfo();
            testerInfo.ShowDialog();
        }

        //打开被试-菜单
        private void OpenTesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesterInfo testerInfo = new TesterInfo();
            testerInfo.openFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TesterInfo");
            testerInfo.openFileDialog1.ShowDialog();
            testerInfo.ShowDialog();
        }

        //当前被试-菜单
        private void PresentTeserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TesterInfo testerInfo = new TesterInfo();
            testerInfo.ShowDialog();
        }

        //新建设置-菜单
        private void NewSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                exConfigList.Clear();
                exFlag = false;
                ExpSettingForm expSetting = new ExpSettingForm();
                expSetting.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //打开配置-菜单
        private void OpenSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                exConfigList.Clear();
                exFlag = false;
                ExpSettingForm expSetting = new ExpSettingForm();
                expSetting.openFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TaskSetting");
                expSetting.openFileDialog1.ShowDialog();
                expSetting.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //当前设置-菜单
        private void PresentSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userFlag)
            {
                ExpSettingForm expSetting = new ExpSettingForm();
                expSetting.ShowDialog();
            }
            else
            {
                MessageBox.Show("被试信息未设置", "提示");
            }
        }

        //硬件校准=菜单
        private void HDCalibrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("RunDLL32.exe","Shell32.dll, Control_RunDLL joy.cpl,, 1");
        }

        //开始试验
        private void button4_Click(object sender, EventArgs e)
        {
            if (userFlag && exFlag && hwFlag)
            {
                string exePath;
                exePath = Directory.GetCurrentDirectory() + "\\ExpRun.exe";
                System.Diagnostics.Process.Start(exePath);
            }
            else
            {
                MessageBox.Show("任务设置未完成", "提示");
            }
        }
    }
}
