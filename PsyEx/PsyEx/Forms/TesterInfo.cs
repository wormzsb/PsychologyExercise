using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PsyEx.Mapper;
using PsyEx.Util;

namespace PsyEx.Forms
{
    public partial class TesterInfo : Form
    {

        public TesterInfo()
        {
            InitializeComponent();
        }

        ~TesterInfo()
        {
            Dispose();
        }

        //载入，如果userFLag为true，读入MainForm的用户数据
        private void TesterInfo_Load(object sender, EventArgs e)
        {
            if (MainForm.userFlag)
            {
                textBox1.Text = MainForm.tester.Id;
                textBox2.Text = MainForm.tester.Name;
                textBox3.Text = MainForm.tester.Sex;
                textBox4.Text = MainForm.tester.Age.ToString();
                textBox5.Text = MainForm.tester.Count.ToString();

            }

        }

        //检查被试数据读取是否完整
        private bool CheckTesterData()
        {
            if (DoFormIdentify.isEmpty(textBox1.Text))
            {
                MessageBox.Show("被试编号没有设置", "提示");
                return false;
            }

            if (DoFormIdentify.isEmpty(textBox2.Text))
            {
                MessageBox.Show("被试姓名没有设置", "提示");
                return false;
            }

            if (DoFormIdentify.isEmpty(textBox3.Text))
            {
                MessageBox.Show("被试性别没有设置", "提示");
                return false;
            }

            if (DoFormIdentify.isEmpty(textBox4.Text))
            {
                MessageBox.Show("被试年龄没有设置", "提示");
                return false;
            }

            if (DoFormIdentify.isEmpty(textBox5.Text))
            {
                MessageBox.Show("被试测试次数没有设置", "提示");
                return false;
            }

            return true;
        }

        public bool SaveData(string directory, string FileName)
        {
            if (CheckTesterData())
            { 
                List<string> SaveList = new List<string>();
                SaveList.Add("ID=" + textBox1.Text);
                SaveList.Add("Name=" + textBox2.Text);
                SaveList.Add("Sex=" + textBox3.Text);
                SaveList.Add("Age=" + textBox4.Text);
                SaveList.Add("Count=" + textBox5.Text);

                if (DoFormIdentify.isEmpty(FileName))
                {
                    FileName = textBox1.Text + "_" + textBox2.Text+"_autosave" + ".tester";
                }
             
                if (DoFile.doFileOutput(directory, FileName, SaveList))
                {                    
                    string exedir, exefile;
                    exedir = DoFormIdentify.MakeDirectoy("ExpRun");
                    exefile = "play.tester";
                    DoFile.doFileOutput(exedir, exefile, SaveList);
                    return true;
                }
            }
            return false;
        }

        //保存被试按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckTesterData()) {
                saveFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TesterInfo");
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
            }
        
                
        }

        //打开被试信息
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TesterInfo");
            openFileDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //确认键
            if (SaveData(DoFormIdentify.MakeDirectoy("TesterInfo"),""))
            {
                MainForm.userFlag = true;
                MainForm.tester.Id = textBox1.Text;
                MainForm.tester.Name = textBox2.Text;
                MainForm.tester.Sex = textBox3.Text;
                MainForm.tester.Age = DoFormIdentify.toInt(textBox4.Text);
                MainForm.tester.Count = DoFormIdentify.toInt(textBox5.Text);
                this.Dispose();
                this.Close();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoFormIdentify.isNum(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoFormIdentify.isNum(e);
        }

        //保存文件
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string localFilePath = saveFileDialog1.FileName, FilePath, FileName;
            FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
            FileName = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
            if(SaveData(FilePath, FileName))
            {
                MessageBox.Show("保存成功", "提示");
            }
            else
            {
                MessageBox.Show("保存发生错误", "提示");
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Dictionary<string, string> DataList = new Dictionary<String, String>();
            DataList = DoFile.doFileInput(openFileDialog1.FileName)[0];
            string str;
            DataList.TryGetValue("ID", out str);
            textBox1.Text = str;
            DataList.TryGetValue("Name", out str);
            textBox2.Text = str;
            DataList.TryGetValue("Sex", out str);
            textBox3.Text = str;
            DataList.TryGetValue("Age", out str);
            textBox4.Text = str;
            DataList.TryGetValue("Count", out str);
            textBox5.Text = str;
            MainForm.tester = new Tester();
            MainForm.userFlag = false;
        }

        private void TesterInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> strList = TextContribute.printMainInfo(MainForm.userFlag, MainForm.exFlag, MainForm.hwFlag);
            Program.m.textBox1.Text = "";
            foreach (string str in strList)
            {
                Program.m.textBox1.Text += Environment.NewLine + str;
            }
            this.Dispose();
        }
    }
}
