using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Mapper;

namespace PsyEx.Forms
{
    public partial class AnalysisForm : Form
    {
        public int taskId = 0;
        public List<List<string>> values;
        public List<string> columns;
        int row = 0;
        

        public AnalysisForm()
        {
            InitializeComponent();
        }

        
        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            switch (taskId)
            {
                case 0:
                    MessageBox.Show("提示", "读取实验结果记录失败");
                    this.Text = "实验结果读取失败";
                    break;

                case 1:
                    //移除tab
                    tabControl1.Controls.Remove(tabPage2);

                    //绘制表头
                    int cIndex = 1;
                    foreach(string column in columns)
                    {
                        this.AddColumn(dataGridView1, "column" + cIndex, column);
                        cIndex++;
                    }

                    foreach(List<string> v in values)
                    {
                        this.AddRow(dataGridView1, v.ToArray());
                    }

                    break;


            }
        }


        //增加列
        private void AddColumn(DataGridView view,string name,string text)
        {
            view.Columns.Add(name, text);
        }

        private void AddRow(DataGridView view,Object[] values)
        {
            view.Rows.Add();
            view.Rows.Insert(row, values);
            row++;
        }



    }
}
