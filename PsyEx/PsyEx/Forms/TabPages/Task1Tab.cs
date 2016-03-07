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
            if (defaultFlag == false)
            {
                //加载默认设置
                this.textBox14.Text = Exercise.EXERCISE_1_NAME;
                

            }
        }
    }
}
