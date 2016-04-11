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

                    //统计分析
                    this.AddColumn(dataGridView3, "key", "指标");
                    this.AddColumn(dataGridView3, "value", "指标值");

                    List<string> disList = new List<string>();
                    List<string> reList = new List<string>();
                    int count = 0;
                    int hit = 0;
                    foreach(List<string> v in values)
                    {

                        count++;
                        if(count > 156)
                        {

                            if (v[14].Equals("1"))
                            {
                                hit++;
                            }
                            disList.Add(v[12]);
                            reList.Add(v[13]);
                        }

                    }

                    string[] da = new string[2];
                    da[0] = "位移误差平均值（DistanceAve）";
                    da[1] = DoMath.dataToAbsAvgForOne(disList);
                    this.AddRowAnaysis(dataGridView3, da);

                    string[] ds = new string[2];
                    ds[0] = "位移误差标准差（DistanceSqt）";
                    ds[1] = DoMath.dataToSDForOne(disList);
                    this.AddRowAnaysis(dataGridView3, ds);

                    string[] rea = new string[2];
                    rea[0] = "角度误差平均值（RotateErrorAve）";
                    rea[1] = DoMath.dataToAbsAvgForOne(reList);
                    this.AddRowAnaysis(dataGridView3, rea);

                    string[] res = new string[2];
                    res[0] = "角度误差标准差（RotateErrorSqt）";
                    res[1] = DoMath.dataToSDForOne(reList);
                    this.AddRowAnaysis(dataGridView3, res);

                    string[] htt = new string[2];
                    htt[0] = "击中总时间（HitTimeTotal）";
                    htt[1] = hit * 40 + "";
                    this.AddRowAnaysis(dataGridView3, htt);

                    string[] htr = new string[2];
                    htr[0] = "击中时间比（HitTimeRate）";
                    htr[1] = String.Format("{0:0.00}", (double)hit / ((double)values.Count() - 156));
           
                    this.AddRowAnaysis(dataGridView3, htr);

                    break;

                case "T2":
                    this.Text = Exercise.EXERCISE_2_NAME;
                    tabPage1.Text = "目标追踪结果";
                    tabPage2.Text = "时间保持结果";
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


                    //统计分析
                    this.AddColumn(dataGridView3, "key", "指标");
                    this.AddColumn(dataGridView3, "value", "指标值");

                    List<string> disList2 = new List<string>();
                    int count2 = 0;
                    int hit2 = 0;
                    foreach (List<string> v in values)
                    {

                        count2++;
                        if (count2 > 156)
                        {
                            if (v[11].Equals("1"))
                            {
                                hit2++;
                            }
                            disList2.Add(v[10]);
                        }

                    }

                    string[] da2 = new string[2];
                    da2[0] = "位移误差平均值（DistanceAve）";
                    da2[1] = DoMath.dataToAbsAvgForOne(disList2);
                    this.AddRowAnaysis(dataGridView3, da2);

                    string[] ds2 = new string[2];
                    ds2[0] = "位移误差标准差（DistanceSqt）";
                    ds2[1] = DoMath.dataToSDForOne(disList2);
                    this.AddRowAnaysis(dataGridView3, ds2);

                    string[] htt2 = new string[2];
                    htt2[0] = "击中总时间（HitTimeTotal）";
                    htt2[1] = hit2 * 40 + "";
                    this.AddRowAnaysis(dataGridView3, htt2);

                    string[] htr2 = new string[2];
                    htr2[0] = "击中时间比（HitTimeRate）";
                    htr2[1] = String.Format("{0:0.00}", (double)hit2 / ((double)values.Count() - 156));
                    this.AddRowAnaysis(dataGridView3, htr2);

                    int holdCount = 0;
                    int[] holdTime = new int[12];
                    double[,] totalError = new double[12, 2];

                    holdCount = DoFormIdentify.toInt(subValues[0][7]);
                    
                    for(int i=0; i< holdCount; i++)
                    {
                        holdTime[i] = DoFormIdentify.toInt(subValues[0][8 + i]);
                    }

                    foreach (List<string> v in subValues)
                    {
                        for (int i = 0; i < holdCount; i++)
                        {
                            if ( (DoFormIdentify.toInt(v[1]) == (holdTime[i] * 1000)) && (v[4] != "-1"))
                            {
                                totalError[i, 0] += Math.Abs(DoFormIdentify.toDouble(v[6]));
                                totalError[i, 1]++;
                                break;
                            }
                        }
                    }

                    for(int i=0; i<holdCount; i++)
                    {
                        string[] holdError = new string[2];
                        string singleHoldError;
                        holdError[0] = "保持时间" + (i + 1).ToString() + "误差率(HoldTimeRate" + (i + 1).ToString() + ")";
                        if (totalError[i,1]!=0)
                        {
                            singleHoldError = (totalError[i, 0] / totalError[i, 1]).ToString("f2");
                        }
                        else
                        {
                            singleHoldError = "反应超时";
                        }
                        holdError[1] = singleHoldError;
                        this.AddRowAnaysis(dataGridView3, holdError);
                    }


                    break;

                case "T3":
                    this.Text = Exercise.EXERCISE_3_NAME;
                    tabPage1.Text = "目标追踪结果";
                    tabPage2.Text = "突发事件结果";
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

                    //统计分析
                    this.AddColumn(dataGridView3, "key", "指标");
                    this.AddColumn(dataGridView3, "value", "指标值");

                    List<string> disList3 = new List<string>();
                    int count3 = 0;
                    int hit3 = 0;
                    foreach (List<string> v in values)
                    {

                        count3++;
                        if (count3 > 156)
                        {
                            if (v[11].Equals("1"))
                            {
                                hit3++;
                            }
                            disList3.Add(v[10]);
                        }

                    }

                    string[] da3 = new string[2];
                    da3[0] = "位移误差平均值（DistanceAve）";
                    da3[1] = DoMath.dataToAbsAvgForOne(disList3);
                    this.AddRowAnaysis(dataGridView3, da3);

                    string[] ds3 = new string[2];
                    ds3[0] = "位移误差标准差（DistanceSqt）";
                    ds3[1] = DoMath.dataToSDForOne(disList3);
                    this.AddRowAnaysis(dataGridView3, ds3);

                    string[] htt3 = new string[2];
                    htt3[0] = "击中总时间（HitTimeTotal）";
                    htt3[1] = hit3 * 40 + "";
                    this.AddRowAnaysis(dataGridView3, htt3);

                    string[] htr3 = new string[2];
                    htr3[0] = "击中时间比（HitTimeRate）";
                    htr3[1] = String.Format("{0:0.00}", (double)hit3 / ((double)values.Count() - 156));
                    this.AddRowAnaysis(dataGridView3, htr3);

                    int T3Type = 0;//简单反应时

                    foreach (List<string> v in subValues)
                    {
                        if (v[1].Equals("1"))
                        {
                            T3Type = 1;//1代表有直升机，选择
                        }
                    }

                    if (T3Type == 0)
                    {
                        int subHit3 = 0;
                        int subUnHit3 = 0;
                        int errorHit = 0;
                        List<string> eventRt = new List<string>();
                        foreach (List<string> v in subValues)
                        {
                            if (v[1].Equals("0") && v[5].Equals("0"))
                            {
                                subHit3++;
                            }
                            else if (v[1].Equals("0") && (v[5].Equals("1") || v[5].Equals("-1")))
                            {
                                subUnHit3++;
                            }
                            else if (v[1].Equals("2"))
                            {
                                errorHit++;
                            }

                            if (v[6].Equals("1"))
                            {
                                eventRt.Add(v[4]);
                            }

                        }

                        string[] jzs = new string[2];
                        jzs[0] = "击中数（HIT）";
                        jzs[1] = subHit3.ToString();
                        this.AddRowAnaysis(dataGridView3, jzs);

                        string[] lbs = new string[2];
                        lbs[0] = "漏报数（MISS）";
                        lbs[1] = subUnHit3.ToString();
                        this.AddRowAnaysis(dataGridView3, lbs);

                        string[] cr = new string[2];
                        cr[0] = "正确拒斥数（CR）";
                        cr[1] = "0";
                        this.AddRowAnaysis(dataGridView3, cr);

                        string[] fa = new string[2];
                        fa[0] = "虚报数（FA）";
                        fa[1] = "0";
                        this.AddRowAnaysis(dataGridView3, fa);

                        string[] fia = new string[2];
                        fia[0] = "事件未发生错误按键数（FIA）";
                        fia[1] = errorHit.ToString();
                        this.AddRowAnaysis(dataGridView3, fia);

                        string[] rtavg = new string[2];
                        rtavg[0] = "突发事件反应时间平均值（RTAvg）";
                        rtavg[1] = DoMath.dataToAbsAvg(eventRt);
                        this.AddRowAnaysis(dataGridView3, rtavg);

                        string[] rtsqr = new string[2];
                        rtsqr[0] = "突发事件反应时间标准差（RTSqr）";
                        rtsqr[1] = DoMath.dataToSD(eventRt);
                        this.AddRowAnaysis(dataGridView3, rtsqr);


                    }
                    else
                    {
                        int subHit3 = 0;
                        int subUnHit3 = 0;
                        int errorHit = 0;
                        int crHit = 0;
                        int faHit = 0;
                        List<string> eventRt = new List<string>();
                        foreach (List<string> v in subValues)
                        {
                            if (v[1].Equals("0") && v[5].Equals("0"))
                            {
                                subHit3++;
                            }
                            else if (v[1].Equals("0") && (v[5].Equals("1") || v[5].Equals("-1")))
                            {
                                subUnHit3++;
                            }
                            else if (v[1].Equals("2"))
                            {
                                errorHit++;
                            }
                            else if (v[1].Equals("1") && v[5].Equals("1"))
                            {
                                crHit++;
                            }
                            else if (v[1].Equals("1") && v[5].Equals("0"))
                            {
                                faHit++;
                            }

                            if (v[6].Equals("1"))
                            {
                                eventRt.Add(v[4]);
                            }

                        }

                        string[] jzs = new string[2];
                        jzs[0] = "击中数（HIT）";
                        jzs[1] = subHit3.ToString();
                        this.AddRowAnaysis(dataGridView3, jzs);

                        string[] lbs = new string[2];
                        lbs[0] = "漏报数（MISS）";
                        lbs[1] = subUnHit3.ToString();
                        this.AddRowAnaysis(dataGridView3, lbs);

                        string[] cr = new string[2];
                        cr[0] = "正确拒斥数（CR）";
                        cr[1] = crHit.ToString();
                        this.AddRowAnaysis(dataGridView3, cr);

                        string[] fa = new string[2];
                        fa[0] = "虚报数（FA）";
                        fa[1] = faHit.ToString();
                        this.AddRowAnaysis(dataGridView3, fa);

                        string[] fia = new string[2];
                        fia[0] = "事件未发生错误按键数（FIA）";
                        fia[1] = errorHit.ToString();
                        this.AddRowAnaysis(dataGridView3, fia);

                        string[] rtavg = new string[2];
                        rtavg[0] = "突发事件反应时间平均值（RTAvg）";
                        rtavg[1] = DoMath.dataToAbsAvg(eventRt);
                        this.AddRowAnaysis(dataGridView3, rtavg);

                        string[] rtsqr = new string[2];
                        rtsqr[0] = "突发事件反应时间标准差（RTSqr）";
                        rtsqr[1] = DoMath.dataToSD(eventRt);
                        this.AddRowAnaysis(dataGridView3, rtsqr);

                    }

                    break;

                case "T4":
                    this.Text = Exercise.EXERCISE_4_NAME;
                    tabPage1.Text = "速度知觉结果";
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

                    string[] zws = new string[2];
                    zws[0] = "偏差率中位数";
                    zws[1] = DoMath.dataToMiddle(pclData);
                    this.AddRowAnaysis(dataGridView3, zws.ToArray());

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
                    tabPage1.Text = "三维心理旋转结果";
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

                    //删除练习模式
                    for (int i = 0; i < 4; i++)
                    {
                        values.Remove(values[0]);
                    }
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

        private void ChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartForm cf = new ChartForm();
            cf.task = task;
            cf.values = values;
            cf.TopMost = true;
            cf.ShowDialog();
        }
    }
}
