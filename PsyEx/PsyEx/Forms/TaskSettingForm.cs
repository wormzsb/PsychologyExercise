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
using PsyEx.Mapper;
using PsyEx.Contexts;

namespace PsyEx.Forms
{
    public partial class TaskSettingForm : Form
    {
        List<TabPage> tabPages = new List<TabPage>();

        public TaskSettingForm()
        {
            InitializeComponent();
        }

        private void TaskSettingForm_Load(object sender, EventArgs e)
        {
            //循环加载tab页面
            for(int i = 0;i < ExpSettingForm.expConfigMap.Count();i++){
                ExConfig ex = ExpSettingForm.expConfigMap[i + 1];
                switch (ex.ExId.Substring(0,1))
                {
                    case "1":
                        TabPage tp1 = new TabPage();
                        Task1Tab task1 = new Task1Tab();
                        if (ex.SetFlag)
                        {
                            task1.config = new SettingConfig1();
                            task1.config = ex.Config1;
                            task1.defaultFlag = false;
                        }
                        else
                        {
                            task1.config = new SettingConfig1();
                            task1.defaultFlag = true;
                        }

                        tp1.Controls.Add(task1);
                        tabPages.Add(tp1);
                        tp1.Text = "实验1";
                        this.tabControl1.Controls.Add(tp1);

                        if (ex.SetFlag)
                        {
                            task1.config = new SettingConfig1();
                            task1.config = ex.Config1;
                        }
                        else
                        {
                            task1.config = new SettingConfig1();
                            task1.defaultFlag = true;
                        }


                        break;

                    case "2":
                        TabPage tp2 = new TabPage();
                        tp2.Controls.Add(new Task2Tab());
                        tabPages.Add(tp2);
                        tp2.Text = "实验2";
                        this.tabControl1.Controls.Add(tp2);


                        break;

                    case "3":
                        TabPage tp3 = new TabPage();
                        tp3.Controls.Add(new Task3Tab());
                        tabPages.Add(tp3);
                        tp3.Text = "实验3";
                        this.tabControl1.Controls.Add(tp3);


                        break;

                    case "4":
                        TabPage tp4 = new TabPage();
                        tp4.Controls.Add(new Task4Tab());
                        tabPages.Add(tp4);
                        tp4.Text = "实验4";
                        this.tabControl1.Controls.Add(tp4);


                        break;

                    case "5":

                        TabPage tp5 = new TabPage();
                        tp5.Controls.Add(new Task5Tab());
                        tabPages.Add(tp5);
                        tp5.Text = "实验5";
                        this.tabControl1.Controls.Add(tp5);

                        break;
                }
            }

        }
    }
}
