using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Forms.TabPages;
using PsyEx.Mapper;
using PsyEx.Contexts;
using PsyEx.Util;

namespace PsyEx.Forms
{
    public partial class TaskSettingForm : Form
    {
        List<TabPage> tabPages = new List<TabPage>();

        public TaskSettingForm()
        {
            InitializeComponent();
        }

        private void TaskSettingForm_Load(object sender, EventArgs e)
        {
            //循环加载tab页面
            for(int i = 0;i < ExpSettingForm.expConfigMap.Count();i++){
                ExConfig ex = ExpSettingForm.expConfigMap[i + 1];
                switch (ex.ExId.Substring(0,1))
                {
                    case "1":
                        TabPage tp1 = new TabPage();
                        Task1Tab task1 = new Task1Tab();
                        if (ex.SetFlag)
                        {
                            task1.config = new SettingConfig1();
                            task1.config = ex.Config1;
                            task1.defaultFlag = false;
                        }
                        else
                        {
                            task1.config = new SettingConfig1();
                            task1.defaultFlag = true;
                        }

                        tp1.Controls.Add(task1);
                        tabPages.Add(tp1);
                        tp1.Text = "实验1";
                        this.tabControl1.Controls.Add(tp1);


                        break;

                    case "2":
                        TabPage tp2 = new TabPage();
                        Task2Tab task2 = new Task2Tab();
                        if (ex.SetFlag)
                        {
                            task2.config = new SettingConfig2();
                            task2.config = ex.Config2;
                            task2.defaultFlag = false;
                        }
                        else
                        {
                            task2.config = new SettingConfig2();
                            task2.defaultFlag = true;
                        }

                        tp2.Controls.Add(new Task2Tab());
                        tabPages.Add(tp2);
                        tp2.Text = "实验2";
                        this.tabControl1.Controls.Add(tp2);

                        break;

                    case "3":
                        TabPage tp3 = new TabPage();
                        tp3.Controls.Add(new Task3Tab());
                        tabPages.Add(tp3);
                        tp3.Text = "实验3";
                        this.tabControl1.Controls.Add(tp3);


                        break;

                    case "4":
                        TabPage tp4 = new TabPage();
                        Task4Tab task4 = new Task4Tab();
                        if (ex.SetFlag)
                        {
                            task4.config = new SettingConfig4();
                            task4.config = ex.Config4;
                            task4.defaultFlag = false;
                        }
                        else
                        {
                            task4.config = new SettingConfig4();
                            task4.defaultFlag = true;
                        }

                        tp4.Controls.Add(new Task4Tab());
                        tabPages.Add(tp4);
                        tp4.Text = "实验4";
                        this.tabControl1.Controls.Add(tp4);

                        break;


                    case "5":

                        TabPage tp5 = new TabPage();
                        Task5Tab task5 = new Task5Tab();
                        if (ex.SetFlag)
                        {
                            task5.config = new SettingConfig5();
                            task5.config = ex.Config5;
                            task5.defaultFlag = false;
                        }
                        else
                        {
                            task5.config = new SettingConfig5();
                            task5.defaultFlag = true;
                        }

                        tp5.Controls.Add(task5);
                        tabPages.Add(tp5);
                        tp5.Text = "实验5";
                        this.tabControl1.Controls.Add(tp5);


                        break;
                }
            }

        }

        //提交

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ExpSettingForm.expConfigMap.Count(); i++)
            {
                ExConfig ex = ExpSettingForm.expConfigMap[i+1];
                TabPage tp = tabPages[i];

                switch (ex.ExId.Substring(0, 1))
                {
                    case "1":
                        Task1Tab task1 = (Task1Tab)tp.Controls[0];
                        SettingConfig1 config1 = new SettingConfig1();
                        config1.BackgroundColor = task1.comboBox1.Text;
                        config1.TestTime = DoFormIdentify.toInt(task1.textBox1.Text);
                        config1.TestNum = DoFormIdentify.toInt(task1.textBox2.Text);
                        config1.Particle = task1.comboBox2.Text;
                        if (task1.radioButton4.Checked)
                        {
                            config1.Pause = false;
                        }
                        else
                        {
                            config1.Pause = true;
                        }
                        config1.PauseRate = DoFormIdentify.toInt(task1.textBox3.Text);

                        config1.MinGTASpeed = DoFormIdentify.toDouble(task1.textBox10.Text);
                        config1.MaxGTASpeed = DoFormIdentify.toDouble(task1.textBox11.Text);
                        config1.MinAngle = DoFormIdentify.toDouble(task1.textBox12.Text);
                        config1.MaxAngel = DoFormIdentify.toDouble(task1.textBox13.Text);

                        if (task1.radioButton6.Checked)
                        {
                            config1.MoveMode = 0;
                        }
                        else
                        {
                            config1.MoveMode = 1;
                        }

                        if (task1.radioButton10.Checked)
                        {
                            config1.SpeedMode = 0;
                            config1.Speed = DoFormIdentify.toDouble(task1.textBox4.Text);
                        }
                        else
                        {
                            config1.SpeedMode = 1;
                            config1.Speed = DoFormIdentify.toDouble(task1.textBox5.Text);
                        }

                        config1.MinSpeed = DoFormIdentify.toDouble(task1.textBox7.Text);
                        config1.MaxSpeed = DoFormIdentify.toDouble(task1.textBox6.Text);

                        config1.MinASpeed = DoFormIdentify.toDouble(task1.textBox8.Text);
                        config1.MaxASpeed = DoFormIdentify.toDouble(task1.textBox9.Text);

                        ex.SetFlag = true;
                        ex.Config1 = config1;
                        break;

                    case "2":



                        break;

                    case "3":

                        break;

                    case "4":


                        break;

                    case "5":
                        Task5Tab task5 = (Task5Tab)tp.Controls[0];
                        SettingConfig5 config5 = new SettingConfig5();

                        config5.PointTime = DoFormIdentify.toInt(task5.textBox4.Text);
                        config5.ViewTime = DoFormIdentify.toInt(task5.textBox9.Text);
                        config5.LastTime = DoFormIdentify.toInt(task5.textBox17.Text);

                        ex.SetFlag = true;
                        ex.Config5 = config5;
                        break;
                }
            }

            this.Dispose();
        }
        

        //取消
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
