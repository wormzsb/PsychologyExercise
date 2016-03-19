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
using PsyEx.Util;

namespace PsyEx.Forms
{
    public partial class AnalysisForm : Form
    {
        public string task = "0";
        public List<List<string>> values;
        public List<string> columns;
        int row = 0;
        int rowA = 0;


        public AnalysisForm()
        {
            InitializeComponent();
        }

        
        private void AnalysisForm_Load(object sender, EventArgs e)
        {
            switch (task)
            {
                case "0":
                    MessageBox.Show("提示", "读取实验结果记录失败");
                    this.Text = "实验结果读取失败";
                    break;

                case "T4":
                    //移除tab
                    tabControl1.Controls.Remove(tabPage2);
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView3.AllowUserToOrderColumns = false;

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

                    //统计分析
                    this.AddColumn(dataGridView3, "key", "指标");
                    this.AddColumn(dataGridView3, "value", "指标值");

                    string[] questNum = new string[2];
                    questNum[0] = "任务次数";
                    questNum[1] = values.Count().ToString();
                    this.AddRowAnaysis(dataGridView3,questNum);

                    string[] pcl = new string[2];
                    pcl[0] = "偏差率";

                    List<string> pclData = new List<string>();
                    foreach(List<string> v in values)
                    {
                        if (!v[10].Equals("-1")) {
                            pclData.Add(v[10]);
                        }
                    }
                    pcl[1] = DoMath.dataToAbsAvg(pclData);
                    this.AddRowAnaysis(dataGridView3, pcl.ToArray());

                    string[] bzc = new string[2];
                    bzc[0] = "偏差率标准差";
                    bzc[1] = DoMath.dataToSD(pclData);
                    this.AddRowAnaysis(dataGridView3, bzc.ToArray());

                    string[] csfy = new string[2];
                    csfy[0] = "未反应次数";
                    csfy[1] = (values.Count() - pclData.Count()).ToString();
                    this.AddRowAnaysis(dataGridView3, csfy.ToArray());

                    string[] kssj = new string[2];
                    kssj[0] = "实验开始时间";
                    kssj[1] = values[values.Count() - 1][14];
                    this.AddRowAnaysis(dataGridView3, kssj.ToArray());

                    string[] jssj = new string[2];
                    jssj[0] = "实验结束时间";
                    jssj[1] = values[values.Count() - 1][15];
                    this.AddRowAnaysis(dataGridView3,jssj.ToArray());

                    string[] ys = new string[2];
                    ys[0] = "实验用时(s)";
                    ys[1] = values[values.Count() - 1][16];
                    this.AddRowAnaysis(dataGridView3, ys.ToArray());

                    break;


            }
        }


        //增加列
        private void AddColumn(DataGridView view,string name,string text)
        {
            view.Columns.Add(name, text);
        }

        //增加行数据
        private void AddRow(DataGridView view,Object[] values)
        {
            view.Rows.Insert(row, values);
            row++;
        }

        //增加行数据统计数据
        private void AddRowAnaysis(DataGridView view, Object[] values)
        {
            view.Rows.Insert(rowA, values);
            rowA++;
        }



    }
}
