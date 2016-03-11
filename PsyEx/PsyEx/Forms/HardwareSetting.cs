using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Contexts;
using PsyEx.Util;

namespace PsyEx.Forms
{
    public partial class HardwareSetting : Form
    {
        public HardwareSetting()
        {
            InitializeComponent();
        }

        //保存
        public bool savedata(string directory, string filename)
        {
            List<string> savelist = new List<string>();
            savelist.Add("Speed=" + textBox1.Text);
            savelist.Add("Sensibility=" + textBox2.Text);
            savelist.Add("Distance=" + textBox3.Text);
            savelist.Add("Angle=" + textBox4.Text);
            
            if (DoFile.doFileOutput(directory, filename, savelist))
            {

                string exedir, exefile;
                exedir = DoFormIdentify.MakeDirectoy("ExpRun");
                exefile = MainForm.tester.Id + "_" + MainForm.tester.Name + ".hdset";
                DoFile.doFileOutput(exedir, exefile, savelist);
                return true;
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.hdConfig.Speed = DoFormIdentify.toDouble(textBox1.Text);
            MainForm.hdConfig.Sensibility = DoFormIdentify.toDouble(textBox2.Text);
            MainForm.hdConfig.Distance = DoFormIdentify.toDouble(textBox3.Text);
            MainForm.hdConfig.Angle = DoFormIdentify.toDouble(textBox4.Text);
            MainForm.hwFlag = true;

            //保存成文件
            string directory, filename;
            directory = DoFormIdentify.MakeDirectoy("HardwareSetting");
            filename = MainForm.tester.Id + "_" + MainForm.tester.Name + "_" + "autosave" + ".hdset";
            if (savedata(directory, filename))
            {
                MessageBox.Show("保存成功", "提示");
            }

            //print
            List<string> strList = TextContribute.printMainInfo(MainForm.userFlag, MainForm.exFlag, MainForm.hwFlag);
            Program.m.textBox1.Text = "";
            foreach (string str in strList)
            {
                Program.m.textBox1.Text += Environment.NewLine + str;
            }
            this.Dispose();
        }

        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void HardwareSetting_Load(object sender, EventArgs e)
        {
            if (MainForm.hwFlag)
            {
                this.textBox1.Text = MainForm.hdConfig.Speed.ToString();
                this.textBox2.Text = MainForm.hdConfig.Sensibility.ToString();
                this.textBox3.Text = MainForm.hdConfig.Distance.ToString();
                this.textBox4.Text = MainForm.hdConfig.Angle.ToString();
            }
            else
            {
                this.textBox1.Text = HDDefaultConfig.speed.ToString();
                this.textBox2.Text = HDDefaultConfig.sensibility.ToString();
                this.textBox3.Text = HDDefaultConfig.distance.ToString();
                this.textBox4.Text = HDDefaultConfig.angle.ToString();
            }

            toolTip1.SetToolTip(groupBox1, "操纵杆采用速度控制，以操纵杆的位移控制受控对象的运动速度");
            toolTip2.SetToolTip(groupBox2, "旋钮灵敏度为：旋钮实际旋转角度与受控对象实际旋转角度的比值×10，该数值越大旋钮灵敏度越低");
        }
    }
}
