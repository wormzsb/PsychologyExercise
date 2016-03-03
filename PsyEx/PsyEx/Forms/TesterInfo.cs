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


        private bool CheckData()
        {
            //检查数据读取是否完整
            //待补全
            return true;
        }


        //载入，如果userFLag为true，读入MainForm的用户数据
        private void TesterInfo_Load(object sender, EventArgs e)
        {
            if (MainForm.userFlag)
            {
                textBox1.Text = MainForm.tester.Id;
                textBox4.Text = MainForm.tester.Name;
                textBox5.Text = MainForm.tester.Sex;
                textBox3.Text = MainForm.tester.Age.ToString();
                textBox2.Text = MainForm.tester.Count.ToString();

            }

        }

        //存储被试信息
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveFileDialog1.Filter = "设置文件(*.set)|*.set";
        }

        //保存被试按钮
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("提示","被试信息不完整");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //编号
            var Input=0;
            if (!int.TryParse(this.Text, out Input))
                MessageBox.Show("编号必须为数字", "错误");
            //待补全

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //姓名
            //待补全
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //年龄
            var Input = 0;
            if (!int.TryParse(this.Text, out Input))
                MessageBox.Show("编号必须为数字", "错误");
            //待补全
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //第N次
            var Input = 0;
            if (!int.TryParse(this.Text, out Input))
                MessageBox.Show("编号必须为数字", "错误");
            //待补全
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //性别
            //待补全
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //打开被试信息
            OpenFileDialog File_in = new OpenFileDialog();
            File_in.Filter = "设置文件(*.set)|*.set";
            if(File_in.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(File_in.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                try
                {
                    //待补全
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //确认键
            if (CheckData())
            {
                string sPath= System.IO.Directory.GetCurrentDirectory()+"//TesterInfo";
                if (!Directory.Exists(sPath))
                {
                    Directory.CreateDirectory(sPath);
                }
                if (DoFile.doFileOutput(sPath, null, null))
                {

                }
                this.Close();
                
            }
        }
    }
}
