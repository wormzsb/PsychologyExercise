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
    public partial class Task2Tab : UserControl
    {
        public bool defaultFlag = true;
        public SettingConfig2 config;

        public Task2Tab()
        {
            InitializeComponent();
        }

        private void Task2Tab_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("圆形");
            comboBox2.Items.Add("横8字形");
            comboBox1.Items.Add("灰黑色");
            comboBox1.Items.Add("蓝黑色");
            for(int i=1; i<=12; i++)
            {
                comboBox3.Items.Add(i.ToString());
            }

            
            if (defaultFlag == true)
            {
                //加载默认设置
                textBox14.Text = Exercise.EXERCISE_2_NAME;
                checkBox2.Checked = DefaultSettingConfig2.mainTest;
                comboBox2.Text = DefaultSettingConfig2.moveTrail;
                radioButton1.Checked = (DefaultSettingConfig2.direction == 1 ? true : false);
                radioButton10.Checked = (DefaultSettingConfig2.speedMode == 0 ? true : false);
                textBox4.Text = DefaultSettingConfig2.speed.ToString();
                textBox5.Text = DefaultSettingConfig2.fspeed.ToString();
                textBox7.Text = DefaultSettingConfig2.minSpeed.ToString();
                textBox6.Text = DefaultSettingConfig2.maxSpeed.ToString();
                textBox8.Text = DefaultSettingConfig2.minASpeed.ToString();
                textBox9.Text = DefaultSettingConfig2.maxASpeed.ToString();
                radioButton8.Checked = (DefaultSettingConfig2.ctrlDirection == 0 ? true : false);
                comboBox1.Text = DefaultSettingConfig2.backgroundColor;
                checkBox1.Checked = DefaultSettingConfig2.feedback;
                comboBox3.Text = DefaultSettingConfig2.estimateNum.ToString();
                textBox1.Text = DefaultSettingConfig2.estimate1.ToString();
                textBox2.Text = DefaultSettingConfig2.estimate2.ToString();
                textBox3.Text = DefaultSettingConfig2.estimate3.ToString();
                textBox10.Text = DefaultSettingConfig2.estimate4.ToString();
                textBox11.Text = DefaultSettingConfig2.estimate5.ToString();
                textBox12.Text = DefaultSettingConfig2.estimate6.ToString();
                textBox13.Text = DefaultSettingConfig2.estimate7.ToString();
                textBox15.Text = DefaultSettingConfig2.estimate8.ToString();
                textBox16.Text = DefaultSettingConfig2.estimate9.ToString();
                textBox17.Text = DefaultSettingConfig2.estimate10.ToString();
                textBox18.Text = DefaultSettingConfig2.estimate11.ToString();
                textBox19.Text = DefaultSettingConfig2.estimate12.ToString();
                textBox20.Text = DefaultSettingConfig2.loop.ToString();
            }
            else
            {
                //加载config
                textBox14.Text = Exercise.EXERCISE_2_NAME;
                checkBox2.Checked = config.MainTest;
                comboBox2.Text = config.MoveTrail;
                radioButton1.Checked = (config.Direction == 1 ? true : false);
                radioButton10.Checked = (config.SpeedMode == 0 ? true : false);
                textBox4.Text = config.Speed.ToString();
                textBox5.Text = config.Speed.ToString();
                textBox7.Text = config.MinSpeed.ToString();
                textBox6.Text = config.MaxSpeed.ToString();
                textBox8.Text = config.MinASpeed.ToString();
                textBox9.Text = config.MaxASpeed.ToString();
                radioButton8.Checked = (config.CtrlDirection == 0 ? true : false);
                comboBox1.Text = config.BackgroundColor;
                checkBox1.Checked = config.Feedback;
                comboBox3.Text = config.EstimateNum.ToString();
                textBox1.Text = config.Estimate1.ToString();
                textBox2.Text = config.Estimate2.ToString();
                textBox3.Text = config.Estimate3.ToString();
                textBox10.Text = config.Estimate4.ToString();
                textBox11.Text = config.Estimate5.ToString();
                textBox12.Text = config.Estimate6.ToString();
                textBox13.Text = config.Estimate7.ToString();
                textBox15.Text = config.Estimate8.ToString();
                textBox16.Text = config.Estimate9.ToString();
                textBox17.Text = config.Estimate10.ToString();
                textBox18.Text = config.Estimate11.ToString();
                textBox19.Text = config.Estimate12.ToString();
                textBox20.Text = config.Loop.ToString();
            }
        }

        //匀速和加速
        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                label13.Enabled = label12.Enabled = textBox4.Enabled = true;
                label16.Enabled = label18.Enabled = label20.Enabled = textBox6.Enabled = textBox7.Enabled = false;
                label14.Enabled = label15.Enabled = textBox5.Enabled = false;
                label17.Enabled = label19.Enabled = label21.Enabled = textBox8.Enabled = textBox9.Enabled = false;
            }
            else
            {
                label13.Enabled = label12.Enabled = textBox4.Enabled = false;
                label16.Enabled = label18.Enabled = label20.Enabled = textBox6.Enabled = textBox7.Enabled = true;
                label14.Enabled = label15.Enabled = textBox5.Enabled = true;
                label17.Enabled = label19.Enabled = label21.Enabled = textBox8.Enabled = textBox9.Enabled = true;
            }
        }

        //禁用每组待估时间
        private void ChangeAbleState2(bool state)
        {
            label7.Enabled = textBox2.Enabled = label8.Enabled = state;
        }

        private void ChangeAbleState3(bool state)
        {
            label9.Enabled = textBox3.Enabled = label10.Enabled = state;
        }

        private void ChangeAbleState4(bool state)
        {
            label22.Enabled = textBox10.Enabled = label23.Enabled = state;
        }

        private void ChangeAbleState5(bool state)
        {
            label24.Enabled = textBox11.Enabled = label25.Enabled = state;
        }

        private void ChangeAbleState6(bool state)
        {
            label26.Enabled = textBox12.Enabled = label27.Enabled = state;
        }

        private void ChangeAbleState7(bool state)
        {
            label29.Enabled = textBox13.Enabled = label30.Enabled = state;
        }

        private void ChangeAbleState8(bool state)
        {
            label31.Enabled = textBox15.Enabled = label32.Enabled = state;
        }

        private void ChangeAbleState9(bool state)
        {
            label33.Enabled = textBox16.Enabled = label34.Enabled = state;
        }

        private void ChangeAbleState10(bool state)
        {
            label35.Enabled = textBox17.Enabled = label36.Enabled = state;
        }

        private void ChangeAbleState11(bool state)
        {
            label37.Enabled = textBox18.Enabled = label38.Enabled = state;
        }

        private void ChangeAbleState12(bool state)
        {
            label39.Enabled = textBox19.Enabled = label40.Enabled = state;
        }

        private void comboBox3_TextChanged(object sender, EventArgs e)
        {
            List<Action<bool>> changeablestate = new List<Action<bool>>();
            changeablestate.Add(ChangeAbleState2);
            changeablestate.Add(ChangeAbleState3);
            changeablestate.Add(ChangeAbleState4);
            changeablestate.Add(ChangeAbleState5);
            changeablestate.Add(ChangeAbleState6);
            changeablestate.Add(ChangeAbleState7);
            changeablestate.Add(ChangeAbleState8);
            changeablestate.Add(ChangeAbleState9);
            changeablestate.Add(ChangeAbleState10);
            changeablestate.Add(ChangeAbleState11);
            changeablestate.Add(ChangeAbleState12);

            int ablecount;
            int.TryParse(comboBox3.Text, out ablecount);
            ablecount--;
            for (int i = 0; i < ablecount; i++)
            {
                changeablestate[i](true);
            }
            for (int i = ablecount; i < 11; i++)
            {
                changeablestate[i](false);
            }            
        }

    }
}
