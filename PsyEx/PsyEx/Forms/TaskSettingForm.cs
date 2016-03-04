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

namespace PsyEx.Forms
{
    public partial class TaskSettingForm : Form
    {
        public TaskSettingForm()
        {
            InitializeComponent();
        }

        private void TaskSettingForm_Load(object sender, EventArgs e)
        {
            this.tabControl1.Controls.Add(new Task1Tab());
        }
    }
}
