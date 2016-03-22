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
using PsyEx.Contexts;

namespace PsyEx.Forms
{
    public partial class AnalysisForm : Form
    {
        public string task = "0";
        public List<List<string>> values;
        public List<string> columns;
        public List<List<string>> subValues;
        public List<string> subColumns;
        int row = 0;
        int rowA = 0;
        int rowS = 0;


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

                case "T1":
                    this.Text = Exercise.EXERCISE_1_NAME;
                    //移除tab
                    tabControl1.Controls.Remove(tabPage2);
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView3.AllowUserToOrderColumns = false;


                    //绘制表头
                    int cIndex1 = 1;
                    foreach (string column in columns)
                    {
                        this.AddColumn(dataGridView1, "column" + cIndex1, column);
                        cIndex1++;
                    }


                    foreach (List<string> v in values)
                    {
                        this.AddRow(dataGridView1, v.ToArray());
                    }


                    break;

                case "T2":
                    this.Text = Exercise.EXERCISE_2_NAME;
                    //移除tab
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView2.AllowUserToOrderColumns = false;
                    dataGridView3.AllowUserToOrderColumns = false;


                    //绘制表头
                    int cIndex2 = 1;
                    foreach (string column in columns)
                    {
                        this.AddColumn(dataGridView1, "column" + cIndex2, column);
                        cIndex2++;
                    }

                    int cIndex2S = 1;
                    foreach (string column in subColumns)
                    {
                        this.AddColumn(dataGridView2, "column" + cIndex2S, column);
                        cIndex2S++;
                    }

                    foreach (List<string> v in values)
                    {
                        this.AddRow(dataGridView1, v.ToArray());
                    }

                    foreach(List<string> v in subValues)
                    {
                        this.AddRowSub(dataGridView2, v.ToArray());
                    }

                    break;

                case "T3":
                    this.Text = Exercise.EXERCISE_3_NAME;
                    //移除tab
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView2.AllowUserToOrderColumns = false;
                    dataGridView3.AllowUserToOrderColumns = false;


                    //绘制表头
                    int cIndex3 = 1;
                    foreach (string column in columns)
                    {
                        this.AddColumn(dataGridView1, "column" + cIndex3, column);
                        cIndex3++;
                    }

                    int cIndex3S = 1;
                    foreach (string column in subColumns)
                    {
                        this.AddColumn(dataGridView2, "column" + cIndex3S, column);
                        cIndex3S++;
                    }

                    foreach (List<string> v in values)
                    {
                        this.AddRow(dataGridView1, v.ToArray());
                    }

                    foreach (List<string> v in subValues)
                    {
                        this.AddRowSub(dataGridView2, v.ToArray());
                    }

                    break;

                case "T4":
                    this.Text = Exercise.EXERCISE_4_NAME;
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

                case "T5":
                    this.Text = Exercise.EXERCISE_5_NAME;
                    //移除tab
                    tabControl1.Controls.Remove(tabPage2);
                    dataGridView1.AllowUserToOrderColumns = false;
                    dataGridView3.AllowUserToOrderColumns = false;

                    //绘制表头
                    int cIndex5 = 1;
                    foreach (string column in columns)
                    {
                        this.AddColumn(dataGridView1, "column" + cIndex5, column);
                        cIndex5++;
                    }

                    foreach (List<string> v in values)
                    {
                        this.AddRow(dataGridView1, v.ToArray());
                    }


                    //统计分析
                    this.AddColumn(dataGridView3, "key", "指标");
                    this.AddColumn(dataGridView3, "value", "指标值");

                    string[] zql = new string[2];
                    zql[0] = "正确率";
                    int right = 0;//正确次数
                    List<string> fys = new List<string>();//正确的反应时间
                    foreach(List<string> v in values)
                    {
                        if (v[5].Equals("1"))
                        {
                            right++;
                            fys.Add(v[6]);
                        }
                    }
                    double rl = (double)right / values.Count();
                    zql[1] = String.Format("{0:0.000}", rl);
                    this.AddRowAnaysis(dataGridView3, zql);

                    string[] fysAvg = new string[2];
                    fysAvg[0] = "平均反应时（ms）";
                    fysAvg[1] = DoMath.dataToAbsAvg(fys);
                    this.AddRowAnaysis(dataGridView3, fysAvg);

                    string[] bz = new string[2];
                    bz[0] = "反应时与正确率比值";
                    double fzbz = (double)DoFormIdentify.toDouble(fysAvg[1]) / rl;
                    bz[1] = String.Format("{0:0.000}", fzbz);
                    this.AddRowAnaysis(dataGridView3, bz);

                    string[] fysbzc = new string[2];
                    fysbzc[0] = "反应时标准差（ms）";
                    fysbzc[1] = DoMath.dataToSD(fys);
                    this.AddRowAnaysis(dataGridView3, fysbzc);

                    string[] kssj5 = new string[2];
                    kssj5[0] = "实验开始时间";
                    kssj5[1] = values[values.Count() - 1][7];
                    this.AddRowAnaysis(dataGridView3, kssj5.ToArray());

                    string[] jssj5 = new string[2];
                    jssj5[0] = "实验结束时间";
                    jssj5[1] = values[values.Count() - 1][8];
                    this.AddRowAnaysis(dataGridView3, jssj5.ToArray());

                    string[] ys5 = new string[2];
                    ys5[0] = "实验用时(s)";
                    ys5[1] = values[values.Count() - 1][9];
                    this.AddRowAnaysis(dataGridView3, ys5.ToArray());

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


        //增加sub行数据
        private void AddRowSub(DataGridView view, Object[] values)
        {
            view.Rows.Insert(rowS, values);
            rowS++;
        }

        //增加行数据统计数据
        private void AddRowAnaysis(DataGridView view, Object[] values)
        {
            view.Rows.Insert(rowA, values);
            rowA++;
        }



    }
}
