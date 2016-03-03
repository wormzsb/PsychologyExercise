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

        private bool SaveFile(string FileName)
        {
            //保存为文件
            FileStream fs = new FileStream(FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            try
            {
                //待补全
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                sw.Close();
                fs.Close();
                return false;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
            return true;
        }

        private void TesterInfo_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //另存被试信息
           if (CheckData())
            {
                SaveFileDialog File_out = new SaveFileDialog();
                File_out.Filter = "设置文件(*.set)|*.set";
                if (File_out.ShowDialog() == DialogResult.OK)
                    if (!SaveFile(File_out.FileName))
                        MessageBox.Show("保存失败", "提示");
                    else
                        MessageBox.Show("保存成功", "提示");
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
                if (SaveFile(sPath + "//"))//路径待补全
                    MessageBox.Show("被试信息保存完毕", "提示");
                this.Close();
            }
        }
    }
}
