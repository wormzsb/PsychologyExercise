using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Mapper;
using PsyEx.Contexts;

namespace PsyEx.Forms.TabPages
{
    public partial class Task1Tab : UserControl
    {
        public bool defaultFlag = true;
        public SettingConfig1 config;

        public Task1Tab()
        {
            InitializeComponent();
        }

        private void Task1Tab_Load(object sender, EventArgs e)
        {
            if (defaultFlag)
            {
                //加载默认设置
                this.textBox14.Text = Exercise.EXERCISE_1_NAME;

                //背景
                this.comboBox1.Text = DefaultSettingConfig1.backgroundColor;
                //测试时间次数
                this.textBox1.Text = DefaultSettingConfig1.testTime.ToString();
                this.textBox2.Text = DefaultSettingConfig1.testNum.ToString();
                //运动方式
                this.comboBox2.Text = DefaultSettingConfig1.particle;
                //暂停
                this.textBox3.Text = DefaultSettingConfig1.pauseRate.ToString();
                this.textBox3.Enabled = false;
                this.label9.Enabled = false;
                this.label10.Enabled = false;
                //滚转
                this.textBox10.Text = DefaultSettingConfig1.minGTASpeed.ToString();
                this.textBox11.Text = DefaultSettingConfig1.maxGTASpeed.ToString();
                this.textBox12.Text = DefaultSettingConfig1.minAngle.ToString();
                this.textBox13.Text = DefaultSettingConfig1.minAngle.ToString();
                this.textBox10.Enabled = false;
                this.textBox11.Enabled = false;
                this.textBox12.Enabled = false;
                this.textBox13.Enabled = false;
                this.label22.Enabled = false;
                this.label23.Enabled = false;
                this.label24.Enabled = false;
                this.label25.Enabled = false;
                this.label26.Enabled = false;
                this.label27.Enabled = false;

                //速度
                this.textBox4.Text = DefaultSettingConfig1.speed.ToString();
                this.textBox5.Text = DefaultSettingConfig1.fSpeed.ToString();
                this.textBox5.Enabled = false;
                this.label14.Enabled = false;
                this.label15.Enabled = false;
                this.textBox6.Text = DefaultSettingConfig1.maxSpeed.ToString();
                this.textBox7.Text = DefaultSettingConfig1.minSpeed.ToString();
                this.textBox6.Enabled = false;
                this.textBox7.Enabled = false;
                this.textBox8.Text = DefaultSettingConfig1.minASpeed.ToString();
                this.textBox9.Text = DefaultSettingConfig1.maxASpeed.ToString();
                this.textBox8.Enabled = false;
                this.textBox9.Enabled = false;
                this.label16.Enabled = false;
                this.label17.Enabled = false;
                this.label18.Enabled = false;
                this.label19.Enabled = false;
                this.label20.Enabled = false;
                this.label21.Enabled = false;


            }
            else
            {
                //加载config
                this.textBox14.Text = Exercise.EXERCISE_1_NAME;
                //背景
                this.comboBox1.Text = config.BackgroundColor;
                //测试时间次数
                this.textBox1.Text = config.TestTime.ToString();
                this.textBox2.Text = config.TestNum.ToString();
                //运动方式
                this.comboBox2.Text = config.Particle;
                //暂停
                this.textBox3.Text = config.PauseRate.ToString();
                if (config.Pause == false)
                {
                    this.textBox3.Enabled = false;
                    this.label9.Enabled = false;
                    this.label10.Enabled = false;
                }
                else
                {
                    radioButton3.Checked = true;
                }

                //滚转
                this.textBox10.Text = config.MinGTASpeed.ToString();
                this.textBox11.Text = config.MaxGTASpeed.ToString();
                this.textBox12.Text = config.MinAngle.ToString();
                this.textBox13.Text = config.MaxAngel.ToString();
                if (config.MoveMode == 0)
                {
                    this.textBox10.Enabled = false;
                    this.textBox11.Enabled = false;
                    this.textBox12.Enabled = false;
                    this.textBox13.Enabled = false;
                    this.label22.Enabled = false;
                    this.label23.Enabled = false;
                    this.label24.Enabled = false;
                    this.label25.Enabled = false;
                    this.label26.Enabled = false;
                    this.label27.Enabled = false;
                }
                else
                {
                    radioButton5.Checked = true;
                }


                //速度
                this.textBox4.Text = config.Speed.ToString();
                this.textBox5.Text = config.Speed.ToString();

                this.textBox6.Text = config.MaxSpeed.ToString();
                this.textBox7.Text = config.MinSpeed.ToString();

                this.textBox8.Text = config.MinASpeed.ToString();
                this.textBox9.Text = config.MaxASpeed.ToString();
                if (config.Speed == 0)
                {
                    this.textBox5.Enabled = false;
                    this.label14.Enabled = false;
                    this.label15.Enabled = false;
                    this.textBox6.Enabled = false;
                    this.textBox7.Enabled = false;
                    this.textBox8.Enabled = false;
                    this.textBox9.Enabled = false;
                    this.label16.Enabled = false;
                    this.label17.Enabled = false;
                    this.label18.Enabled = false;
                    this.label19.Enabled = false;
                    this.label20.Enabled = false;
                    this.label21.Enabled = false;
                }
                else
                {
                    this.radioButton9.Checked = true;
                    this.label12.Enabled = false;
                    this.label13.Enabled = false;
                    this.textBox4.Enabled = false;
                }


            }
        }

        //暂停
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox3.Enabled = true;
            this.label9.Enabled = true;
            this.label10.Enabled = true;
        }

        //加速
        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            this.label12.Enabled = false;
            this.label13.Enabled = false;
            this.textBox4.Enabled = false;

            this.textBox5.Enabled = true;
            this.label14.Enabled = true;
            this.label15.Enabled = true;
            this.textBox6.Enabled = true;
            this.textBox7.Enabled = true;
            this.textBox8.Enabled = true;
            this.textBox9.Enabled = true;
            this.label16.Enabled = true;
            this.label17.Enabled = true;
            this.label18.Enabled = true;
            this.label19.Enabled = true;
            this.label20.Enabled = true;
            this.label21.Enabled = true;
        }

        //转动
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox10.Enabled = true;
            this.textBox11.Enabled = true;
            this.textBox12.Enabled = true;
            this.textBox13.Enabled = true;
            this.label22.Enabled = true;
            this.label23.Enabled = true;
            this.label24.Enabled = true;
            this.label25.Enabled = true;
            this.label26.Enabled = true;
            this.label27.Enabled = true;
        }

        //没有暂停
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox3.Enabled = false;
            this.label9.Enabled = false;
            this.label10.Enabled = false;
        }

        //匀速

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.label12.Enabled = true;
            this.label13.Enabled = true;
            this.textBox4.Enabled = true;

            this.textBox5.Enabled = false;
            this.label14.Enabled = false;
            this.label15.Enabled = false;
            this.textBox6.Enabled = false;
            this.textBox7.Enabled = false;
            this.textBox8.Enabled = false;
            this.textBox9.Enabled = false;
            this.label16.Enabled = false;
            this.label17.Enabled = false;
            this.label18.Enabled = false;
            this.label19.Enabled = false;
            this.label20.Enabled = false;
            this.label21.Enabled = false;
        }

        //平移
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox10.Enabled = false;
            this.textBox11.Enabled = false;
            this.textBox12.Enabled = false;
            this.textBox13.Enabled = false;
            this.label22.Enabled = false;
            this.label23.Enabled = false;
            this.label24.Enabled = false;
            this.label25.Enabled = false;
            this.label26.Enabled = false;
            this.label27.Enabled = false;
        }
    }
}
