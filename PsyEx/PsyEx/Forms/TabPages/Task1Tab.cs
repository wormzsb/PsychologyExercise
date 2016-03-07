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
            if (defaultFlag == true)
            {
                //加载默认设置
                this.textBox14.Text = Exercise.EXERCISE_1_NAME;
                this.comboBox1.Text = DefaultSettingConfig1.backgroundColor;
                this.textBox1.Text = DefaultSettingConfig1.testTime.ToString();
                this.textBox2.Text = DefaultSettingConfig1.testNum.ToString();
                this.comboBox2.Text = DefaultSettingConfig1.particle;
                


            }
            else
            {
                //加载config
                this.textBox14.Text = Exercise.EXERCISE_1_NAME;
                this.comboBox1.Text = config.BackgroundColor;
                this.textBox1.Text = config.TestTime.ToString();
                this.textBox2.Text = config.TestNum.ToString();
                
            }
        }
    }
}
