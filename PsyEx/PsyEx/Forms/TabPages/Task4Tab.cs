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
    public partial class Task4Tab : UserControl
    {
        public bool defaultFlag = true;
        public SettingConfig4 config;

        public Task4Tab()
        {
            InitializeComponent();
        }

        private void Task4Tab_Load(object sender, EventArgs e)
        {
            if (defaultFlag == true)
            {
                textBox14.Text = Exercise.EXERCISE_4_NAME;
                textBox4.Text = DefaultSettingConfig4.ballColorR.ToString();
                textBox5.Text = DefaultSettingConfig4.ballColorG.ToString();
                textBox6.Text = DefaultSettingConfig4.ballColorB.ToString();
                textBox9.Text = DefaultSettingConfig4.backgroundColorR.ToString();
                textBox8.Text = DefaultSettingConfig4.backgroundColorG.ToString();
                textBox7.Text = DefaultSettingConfig4.backgroundColorB.ToString();
                textBox17.Text = DefaultSettingConfig4.shelterColorR.ToString();
                textBox16.Text = DefaultSettingConfig4.shelterColorG.ToString();
                textBox15.Text = DefaultSettingConfig4.shelterColorB.ToString();
                textBox3.Text = DefaultSettingConfig4.ballRadius.ToString();
                textBox2.Text = DefaultSettingConfig4.shelterRadius.ToString();
                textBox1.Text = DefaultSettingConfig4.ballCenterDis.ToString();
                textBox20.Text = DefaultSettingConfig4.speed1.ToString();
                textBox19.Text = DefaultSettingConfig4.speed2.ToString();
                textBox18.Text = DefaultSettingConfig4.speed3.ToString();
                checkBox2.Checked = DefaultSettingConfig4.left;
                checkBox1.Checked = DefaultSettingConfig4.right;
                checkBox8.Checked = DefaultSettingConfig4.up;
                checkBox7.Checked = DefaultSettingConfig4.down;
                checkBox6.Checked = DefaultSettingConfig4.feedback;
                textBox10.Text = DefaultSettingConfig4.repeatNum.ToString();
                textBox11.Text = DefaultSettingConfig4.timeInterval.ToString();
            }
            else
            {
                textBox14.Text = Exercise.EXERCISE_4_NAME;
                textBox4.Text = config.BallColorR.ToString();
                textBox5.Text = config.BallColorG.ToString();
                textBox6.Text = config.BallColorB.ToString();
                textBox9.Text = config.BackgroundColorR.ToString();
                textBox8.Text = config.BackgroundColorG.ToString();
                textBox7.Text = config.BackgroundColorB.ToString();
                textBox17.Text = config.ShelterColorR.ToString();
                textBox16.Text = config.ShelterColorG.ToString();
                textBox15.Text = config.ShelterColorB.ToString();
                textBox3.Text = config.BallRadius.ToString();
                textBox2.Text = config.ShelterRadius.ToString();
                textBox1.Text = config.BallCenterDis.ToString();
                textBox20.Text = config.Speed1.ToString();
                textBox19.Text = config.Speed2.ToString();
                textBox18.Text = config.Speed3.ToString();
                checkBox2.Checked = config.Left;
                checkBox1.Checked = config.Right;
                checkBox8.Checked = config.Up;
                checkBox7.Checked = config.Down;
                checkBox6.Checked = config.Feedback;
                textBox10.Text = config.RepeatNum.ToString();
                textBox11.Text = config.TimeInterval.ToString();
            }
        }

    }
}
