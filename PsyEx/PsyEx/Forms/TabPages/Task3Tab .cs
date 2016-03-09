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
using PsyEx.Util;

namespace PsyEx.Forms.TabPages
{
    public partial class Task3Tab : UserControl
    {
        public SettingConfig3 config;
        public bool defaultFlag = true;

        public Task3Tab()
        {
            InitializeComponent();
        }

        private void Task3Tab_Load(object sender, EventArgs e)
        {
            if (defaultFlag)
            {
                this.textBox14.Text = Exercise.EXERCISE_3_NAME;
                this.comboBox1.Text = DefaultSettingConfig3.backgroundColor;
                this.comboBox2.Text = DefaultSettingConfig3.moveTrail;

                //speed
                this.textBox4.Text = DefaultSettingConfig3.speed.ToString();
                this.textBox5.Text = DefaultSettingConfig3.aSpeed.ToString();
                this.textBox7.Text = DefaultSettingConfig3.minSpeed.ToString();
                this.textBox6.Text = DefaultSettingConfig3.maxSpeed.ToString();
                this.textBox8.Text = DefaultSettingConfig3.minASpeed.ToString();
                this.textBox9.Text = DefaultSettingConfig3.maxASpeed.ToString();

                this.textBox5.Enabled = false;
                this.textBox7.Enabled = false;
                this.textBox6.Enabled = false;
                this.textBox8.Enabled = false;
                this.textBox9.Enabled = false;
                this.label14.Enabled = false;
                this.label15.Enabled = false;
                this.label16.Enabled = false;
                this.label17.Enabled = false;
                this.label18.Enabled = false;
                this.label19.Enabled = false;

                this.textBox1.Text = DefaultSettingConfig3.plane.ToString();
                this.textBox2.Text = DefaultSettingConfig3.copter.ToString();
                this.textBox3.Text = DefaultSettingConfig3.viewTime.ToString();

                this.textBox10.Text = DefaultSettingConfig3.waitTime.ToString();
                this.textBox11.Text = DefaultSettingConfig3.minTimeSpace.ToString();
                this.textBox12.Text = DefaultSettingConfig3.maxTimeSpace.ToString();
                this.textBox13.Text = DefaultSettingConfig3.testNum.ToString();
            }
            else
            {
                this.textBox14.Text = Exercise.EXERCISE_3_NAME;
                this.comboBox1.Text = config.BackgroundColor;
                this.comboBox2.Text = config.MoveTrail;

                if(config.Direction == 0)
                {
                    this.radioButton1.Checked = true;
                }
                else
                {
                    this.radioButton2.Checked = true;
                }

                //speed
                this.textBox4.Text = config.Speed.ToString();
                this.textBox5.Text = config.Speed.ToString();
                this.textBox7.Text = config.MinSpeed.ToString();
                this.textBox6.Text = config.MaxSpeed.ToString();
                this.textBox8.Text = config.MinASpeed.ToString();
                this.textBox9.Text = config.MaxASpeed.ToString();

                if(config.SpeedMode == 0)
                {
                    this.textBox5.Enabled = false;
                    this.textBox7.Enabled = false;
                    this.textBox6.Enabled = false;
                    this.textBox8.Enabled = false;
                    this.textBox9.Enabled = false;
                    this.label14.Enabled = false;
                    this.label15.Enabled = false;
                    this.label16.Enabled = false;
                    this.label17.Enabled = false;
                    this.label18.Enabled = false;
                    this.label19.Enabled = false;
                }
                else
                {
                    this.radioButton9.Checked = true;
                    this.textBox4.Enabled = false;
                    this.label13.Enabled = false;
                    this.label12.Enabled = false;
                }

                if (config.Feedback)
                {
                    this.checkBox1.Checked = true;
                }
                else
                {
                    this.checkBox1.Checked = false;
                }

                if (config.CtrlDirection == 0)
                {
                    this.radioButton8.Checked = true;
                }
                else
                {
                    this.radioButton7.Checked = true;
                }

                if (config.SecTestMode == 0)
                {
                    this.radioButton3.Checked = true;
                }
                else
                {
                    this.radioButton4.Checked = true;
                }

                if (config.LeftUp)
                {
                    this.checkBox3.Checked = true;
                }
                else
                {
                    this.checkBox3.Checked = false;
                }

                if (config.LeftDown)
                {
                    this.checkBox4.Checked = true;
                }
                else
                {
                    this.checkBox4.Checked = false;
                }

                if (config.RightUp)
                {
                    this.checkBox5.Checked = true;
                }
                else
                {
                    this.checkBox5.Checked = false;
                }

                if (config.RightDown)
                {
                    this.checkBox6.Checked = true;
                }
                else
                {
                    this.checkBox6.Checked = false;
                }

                if (config.MainTest)
                {
                    this.checkBox2.Checked = true;
                }
                else
                {
                    this.checkBox2.Checked = false;
                }

                this.textBox1.Text = config.Plane.ToString();
                this.textBox2.Text = config.Copter.ToString();
                this.textBox3.Text = config.ViewTime.ToString();

                this.textBox10.Text = config.WaitTime.ToString();
                this.textBox11.Text = config.MinTimeSpace.ToString();
                this.textBox12.Text = config.MaxTimeSpace.ToString();
                this.textBox13.Text = config.TestNum.ToString();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

            this.textBox5.Enabled = true;
            this.textBox7.Enabled = true;
            this.textBox6.Enabled = true;
            this.textBox8.Enabled = true;
            this.textBox9.Enabled = true;
            this.label14.Enabled = true;
            this.label15.Enabled = true;
            this.label16.Enabled = true;
            this.label17.Enabled = true;
            this.label18.Enabled = true;
            this.label19.Enabled = true;

            this.textBox4.Enabled = false;
            this.label13.Enabled = false;
            this.label12.Enabled = false;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox5.Enabled = false;
            this.textBox7.Enabled = false;
            this.textBox6.Enabled = false;
            this.textBox8.Enabled = false;
            this.textBox9.Enabled = false;
            this.label14.Enabled = false;
            this.label15.Enabled = false;
            this.label16.Enabled = false;
            this.label17.Enabled = false;
            this.label18.Enabled = false;
            this.label19.Enabled = false;

            this.textBox4.Enabled = true;
            this.label13.Enabled = true;
            this.label12.Enabled = true;
        }
    }
}
