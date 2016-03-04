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
            if (DoForm.isEmpty(textBox1.Text))
            {
                MessageBox.Show("被试编号没有设置", "提示");
                return false;
            }
            else
            {
                MainForm.tester.Id = textBox1.Text;
            }

            if (DoForm.isEmpty(textBox2.Text))
            {
                MessageBox.Show("被试姓名没有设置", "提示");
                return false;
            }
            else
            {
                MainForm.tester.Name = textBox2.Text;
            }

            if (DoForm.isEmpty(textBox3.Text))
            {
                MessageBox.Show("被试性别没有设置", "提示");
                return false;
            }
            else
            {
                MainForm.tester.Sex = textBox3.Text;
            }

            if (DoForm.isEmpty(textBox4.Text))
            {
                MessageBox.Show("被试年龄没有设置", "提示");
                return false;
            }
            else
            {
                MainForm.tester.Age = DoForm.toInt(textBox4.Text);
            }

            if (DoForm.isEmpty(textBox5.Text))
            {
                MessageBox.Show("被试测试次数没有设置", "提示");
                return false;
            }
            else
            {
                MainForm.tester.Count = DoForm.toInt(textBox5.Text);
            }
            return true;
        }

        private bool SaveData(string directory, string FileName)
        {
            if (CheckTesterData())
            { 
                List<string> SaveList = new List<string>();
                SaveList.Add("ID\t" + MainForm.tester.Id);
                SaveList.Add("Name\t" + MainForm.tester.Name);
                SaveList.Add("Sex\t" + MainForm.tester.Sex);
                SaveList.Add("Age\t" + MainForm.tester.Age.ToString());
                SaveList.Add("Count\t" + MainForm.tester.Count.ToString());

                if (DoForm.isEmpty(FileName))
                {
                    FileName = MainForm.tester.Id + "_" + MainForm.tester.Name + ".set";
                }
             
                if (DoFile.doFileOutput(directory, FileName, SaveList))
                {
                    MessageBox.Show("保存成功", "提示");
                    return true;
                }
            }
            else
            {
                MessageBox.Show("被试信息不完整", "提示");
            }
            return false;
        }

        //保存被试按钮
        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = DoForm.MakeDirectoy("TesterInfo");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = saveFileDialog1.FileName, FilePath, FileName;
                FilePath = localFilePath.Substring(0,localFilePath.LastIndexOf("\\"));
                FileName = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
                SaveData(FilePath, FileName);
            }
                
        }

        //打开被试信息
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = DoForm.MakeDirectoy("TesterInfo");
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
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
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //确认键
            if (SaveData(DoForm.MakeDirectoy("TesterInfo"),""))
            {
                this.Close();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoForm.isNum(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            DoForm.isNum(e);
        }
    }
}
