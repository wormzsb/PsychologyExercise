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
    public partial class Task5Tab : UserControl
    {
        public SettingConfig5 config;
        public bool defaultFlag = true;
        public Task5Tab()
        {
            InitializeComponent();
        }

        private void Task5Tab_Load(object sender, EventArgs e)
        {
            if (defaultFlag)
            {
                this.textBox14.Text = Exercise.EXERCISE_5_NAME;
                this.textBox4.Text = DefaultSettingConfig5.pointTime.ToString();
                this.textBox9.Text = DefaultSettingConfig5.viewTime.ToString();
                this.textBox17.Text = DefaultSettingConfig5.lastTime.ToString();
            }
            else
            {
                this.textBox14.Text = Exercise.EXERCISE_5_NAME;
                this.textBox4.Text = config.PointTime.ToString();
                this.textBox9.Text = config.ViewTime.ToString();
                this.textBox17.Text = config.LastTime.ToString();
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            CheckAble();
        }

        private void CheckAble()
        {
            int presentTime = 0;
            int countDown = 0;

            int.TryParse(textBox9.Text, out presentTime);
            int.TryParse(textBox17.Text, out countDown);

            if (countDown > presentTime)
            {
                MessageBox.Show("输入数据有效性有问题", "提示");
                textBox17.Text = "";
            }
        }
    }
}
