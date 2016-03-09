using System;
using System.Windows.Forms;
using PsyEx.Mapper;
using System.Collections.Generic;
using PsyEx.Forms;
using PsyEx.Util;

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
            ExpSettingForm expSetting = new ExpSettingForm();
            expSetting.ShowDialog();
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
            HardwareSetting hdForm = new HardwareSetting();
            hdForm.ShowDialog();
        }

        //硬件配置-菜单
        private void HDConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HardwareSetting hdForm = new HardwareSetting();
            hdForm.ShowDialog();
        }
    }
}
