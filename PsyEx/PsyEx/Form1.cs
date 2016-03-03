using System;
using System.Windows.Forms;
using PsyEx.Mapper;
using System.Collections.Generic;
using PsyEx.Forms;

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

        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void experimentSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TesterInfo testerInfo = new TesterInfo();
            testerInfo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

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
    }
}
