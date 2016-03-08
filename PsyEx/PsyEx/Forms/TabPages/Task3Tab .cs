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

            }
        }
    }
}
