using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsyEx.Forms
{
    public partial class ExpSettingForm : Form
    {
        public ExpSettingForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        //配置参数
        private void button5_Click(object sender, EventArgs e)
        {
            TaskSettingForm taskConfigForm = new TaskSettingForm();
            taskConfigForm.ShowDialog();
        }
    }
}
