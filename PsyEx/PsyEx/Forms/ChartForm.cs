using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Util;
using System.Windows.Forms.DataVisualization.Charting;

namespace PsyEx.Forms
{
    public partial class ChartForm : Form
    {
        public string task;
        public List<List<string>> values;

        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            switch (task)
            {
                case "T1":
                    tabPage1.Text = "位移误差随时间变化的曲线";
                    chart1.Series.Clear();

                    chart1.Series.Add("distance");
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart1.ChartAreas[0].AxisY.Title = "位移偏差(pix)";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    double time = 0;
                    foreach(List<string> v in values)
                    {
                        chart1.Series[0].Points.AddXY(time,DoFormIdentify.toDouble(v[12]));
                        time += 0.040d;
                    }

                    tabPage2.Text = "角度误差随时间变化的曲线";
                    chart2.Series.Clear();

                    chart2.Series.Add("rotate");
                    chart2.Series[0].ChartType = SeriesChartType.Line;
                    chart2.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart2.ChartAreas[0].AxisY.Title = "角度";
                    chart2.ChartAreas[0].AxisX.Interval = 1;

                    double time1 = 0;
                    foreach (List<string> v in values)
                    {
                        chart2.Series[0].Points.AddXY(time1, DoFormIdentify.toDouble(v[13]));
                        time1 += 0.040d;
                    }

                    tabPage3.Text = "目标、瞄准器速度随时间变化的曲线";
                    chart3.Series.Clear();

                    chart3.Series.Add("目标x轴速度");
                    chart3.Series.Add("目标y轴速度");
                    chart3.Series.Add("控制器x轴速度");
                    chart3.Series.Add("控制器y轴速度");
                    chart3.Series[0].ChartType = SeriesChartType.Line;
                    chart3.Series[1].ChartType = SeriesChartType.Line;
                    chart3.Series[2].ChartType = SeriesChartType.Line;
                    chart3.Series[3].ChartType = SeriesChartType.Line;
                    chart3.Legends.Add("目标x轴速度");
                    chart3.Legends.Add("目标y轴速度");
                    chart3.Legends.Add("控制器x轴速度");
                    chart3.Legends.Add("控制器y轴速度");
                    chart3.Legends[0].DockedToChartArea = "ChartArea1";
                    chart3.Legends[1].DockedToChartArea = "ChartArea1";
                    chart3.Legends[2].DockedToChartArea = "ChartArea1";
                    chart3.Legends[3].DockedToChartArea = "ChartArea1";
                    chart3.Series[0].Legend = "目标x轴速度";
                    chart3.Series[1].Legend = "目标y轴速度";
                    chart3.Series[2].Legend = "控制器x轴速度";
                    chart3.Series[3].Legend = "控制器y轴速度";
                    chart3.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart3.ChartAreas[0].AxisY.Title = "速度(pix/s)";
                    chart3.ChartAreas[0].AxisX.Interval = 1;

                    double time2 = 0;
                    foreach (List<string> v in values)
                    {
                        chart3.Series[0].Points.AddXY(time2, DoFormIdentify.toDouble(v[15]));
                        chart3.Series[1].Points.AddXY(time2, DoFormIdentify.toDouble(v[16]));
                        chart3.Series[2].Points.AddXY(time2, DoFormIdentify.toDouble(v[17]));
                        chart3.Series[3].Points.AddXY(time2, DoFormIdentify.toDouble(v[18]));
                        time2 += 0.040d;
                    }

                    tabPage4.Text = "目标、瞄准器角速度随时间变化的曲线";
                    chart4.Series.Clear();

                    chart4.Series.Add("目标角速度");
                    chart4.Series.Add("控制器角速度");
                    chart4.Series[0].ChartType = SeriesChartType.Line;
                    chart4.Series[1].ChartType = SeriesChartType.Line;
                    chart4.Legends.Add("目标角速度");
                    chart4.Legends.Add("控制器角速度");
                    chart4.Legends[0].DockedToChartArea = "ChartArea1";
                    chart4.Legends[1].DockedToChartArea = "ChartArea1";
                    chart4.Series[0].Legend = "目标角速度";
                    chart4.Series[1].Legend = "控制器角速度";
                    chart4.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart4.ChartAreas[0].AxisY.Title = "角速度";
                    chart4.ChartAreas[0].AxisX.Interval = 1;

                    double time3 = 0;
                    foreach (List<string> v in values)
                    {
                        chart4.Series[0].Points.AddXY(time2, DoFormIdentify.toDouble(v[19]));
                        chart4.Series[1].Points.AddXY(time2, DoFormIdentify.toDouble(v[20]));
                        time3 += 0.040d;
                    }

                    tabPage5.Text = "轨迹图";
                    chart5.Series.Clear();

                    chart5.Series.Add("目标运动轨迹");
                    chart5.Series.Add("追踪轨迹");
                    chart5.Series[0].ChartType = SeriesChartType.Line;
                    chart5.Series[1].ChartType = SeriesChartType.Line;
                    chart5.Legends.Add("目标运动轨迹");
                    chart5.Legends.Add("追踪轨迹");
                    chart5.Legends[0].DockedToChartArea = "ChartArea1";
                    chart5.Legends[1].DockedToChartArea = "ChartArea1";
                    chart5.Series[0].Legend = "目标运动轨迹";
                    chart5.Series[1].Legend = "追踪轨迹";
                    chart5.ChartAreas[0].AxisX.Interval = 50;
                    chart5.ChartAreas[0].AxisY.Interval = 50;

                    foreach (List<string> v in values)
                    {
                        chart5.Series[0].Points.AddXY(DoFormIdentify.toDouble(v[6]), DoFormIdentify.toDouble(v[7]));
                        chart5.Series[1].Points.AddXY(DoFormIdentify.toDouble(v[8]), DoFormIdentify.toDouble(v[9]));
                    }

                    break;

                case "T2":
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);

                    tabPage1.Text = "位移误差随时间变化的曲线";
                    chart1.Series.Clear();

                    chart1.Series.Add("distance");
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart1.ChartAreas[0].AxisY.Title = "位移偏差(pix)";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    time = 0;
                    foreach (List<string> v in values)
                    {
                        chart1.Series[0].Points.AddXY(time, DoFormIdentify.toDouble(v[10]));
                        time += 0.040d;
                    }

                    tabPage2.Text = "目标、瞄准器速度随时间变化的曲线";
                    chart2.Series.Clear();

                    chart2.Series.Add("目标x轴速度");
                    chart2.Series.Add("目标y轴速度");
                    chart2.Series.Add("控制器x轴速度");
                    chart2.Series.Add("控制器y轴速度");
                    chart2.Series[0].ChartType = SeriesChartType.Line;
                    chart2.Series[1].ChartType = SeriesChartType.Line;
                    chart2.Series[2].ChartType = SeriesChartType.Line;
                    chart2.Series[3].ChartType = SeriesChartType.Line;
                    chart2.Legends.Add("目标x轴速度");
                    chart2.Legends.Add("目标y轴速度");
                    chart2.Legends.Add("控制器x轴速度");
                    chart2.Legends.Add("控制器y轴速度");
                    chart2.Legends[0].DockedToChartArea = "ChartArea1";
                    chart2.Legends[1].DockedToChartArea = "ChartArea1";
                    chart2.Legends[2].DockedToChartArea = "ChartArea1";
                    chart2.Legends[3].DockedToChartArea = "ChartArea1";
                    chart2.Series[0].Legend = "目标x轴速度";
                    chart2.Series[1].Legend = "目标y轴速度";
                    chart2.Series[2].Legend = "控制器x轴速度";
                    chart2.Series[3].Legend = "控制器y轴速度";
                    chart2.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart2.ChartAreas[0].AxisY.Title = "速度(pix/s)";
                    chart2.ChartAreas[0].AxisX.Interval = 1;

                    time2 = 0;
                    foreach (List<string> v in values)
                    {
                        chart2.Series[0].Points.AddXY(time2, DoFormIdentify.toDouble(v[12]));
                        chart2.Series[1].Points.AddXY(time2, DoFormIdentify.toDouble(v[13]));
                        chart2.Series[2].Points.AddXY(time2, DoFormIdentify.toDouble(v[14]));
                        chart2.Series[3].Points.AddXY(time2, DoFormIdentify.toDouble(v[15]));
                        time2 += 0.040d;
                    }

                    tabPage3.Text = "轨迹图";
                    chart3.Series.Clear();

                    chart3.Series.Add("目标运动轨迹");
                    chart3.Series.Add("追踪轨迹");
                    chart3.Series[0].ChartType = SeriesChartType.Line;
                    chart3.Series[1].ChartType = SeriesChartType.Line;
                    chart3.Legends.Add("目标运动轨迹");
                    chart3.Legends.Add("追踪轨迹");
                    chart3.Legends[0].DockedToChartArea = "ChartArea1";
                    chart3.Legends[1].DockedToChartArea = "ChartArea1";
                    chart3.Series[0].Legend = "目标运动轨迹";
                    chart3.Series[1].Legend = "追踪轨迹";
                    chart3.ChartAreas[0].AxisX.Interval = 50;
                    chart3.ChartAreas[0].AxisY.Interval = 50;

                    foreach (List<string> v in values)
                    {
                        chart3.Series[0].Points.AddXY(DoFormIdentify.toDouble(v[6]), DoFormIdentify.toDouble(v[7]));
                        chart3.Series[1].Points.AddXY(DoFormIdentify.toDouble(v[8]), DoFormIdentify.toDouble(v[9]));
                    }
                    break;

                case "3":
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);

                    tabPage1.Text = "位移误差随时间变化的曲线";
                    chart1.Series.Clear();

                    chart1.Series.Add("distance");
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                    chart1.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart1.ChartAreas[0].AxisY.Title = "位移偏差(pix)";
                    chart1.ChartAreas[0].AxisX.Interval = 1;
                    time = 0;
                    foreach (List<string> v in values)
                    {
                        chart1.Series[0].Points.AddXY(time, DoFormIdentify.toDouble(v[10]));
                        time += 0.040d;
                    }

                    tabPage2.Text = "目标、瞄准器速度随时间变化的曲线";
                    chart2.Series.Clear();

                    chart2.Series.Add("目标x轴速度");
                    chart2.Series.Add("目标y轴速度");
                    chart2.Series.Add("控制器x轴速度");
                    chart2.Series.Add("控制器y轴速度");
                    chart2.Series[0].ChartType = SeriesChartType.Line;
                    chart2.Series[1].ChartType = SeriesChartType.Line;
                    chart2.Series[2].ChartType = SeriesChartType.Line;
                    chart2.Series[3].ChartType = SeriesChartType.Line;
                    chart2.Legends.Add("目标x轴速度");
                    chart2.Legends.Add("目标y轴速度");
                    chart2.Legends.Add("控制器x轴速度");
                    chart2.Legends.Add("控制器y轴速度");
                    chart2.Legends[0].DockedToChartArea = "ChartArea1";
                    chart2.Legends[1].DockedToChartArea = "ChartArea1";
                    chart2.Legends[2].DockedToChartArea = "ChartArea1";
                    chart2.Legends[3].DockedToChartArea = "ChartArea1";
                    chart2.Series[0].Legend = "目标x轴速度";
                    chart2.Series[1].Legend = "目标y轴速度";
                    chart2.Series[2].Legend = "控制器x轴速度";
                    chart2.Series[3].Legend = "控制器y轴速度";
                    chart2.ChartAreas[0].AxisX.Title = "时间(s)";
                    chart2.ChartAreas[0].AxisY.Title = "速度(pix/s)";
                    chart2.ChartAreas[0].AxisX.Interval = 1;

                    time2 = 0;
                    foreach (List<string> v in values)
                    {
                        chart2.Series[0].Points.AddXY(time2, DoFormIdentify.toDouble(v[12]));
                        chart2.Series[1].Points.AddXY(time2, DoFormIdentify.toDouble(v[13]));
                        chart2.Series[2].Points.AddXY(time2, DoFormIdentify.toDouble(v[14]));
                        chart2.Series[3].Points.AddXY(time2, DoFormIdentify.toDouble(v[15]));
                        time2 += 0.040d;
                    }

                    tabPage3.Text = "轨迹图";
                    chart3.Series.Clear();

                    chart3.Series.Add("目标运动轨迹");
                    chart3.Series.Add("追踪轨迹");
                    chart3.Series[0].ChartType = SeriesChartType.Line;
                    chart3.Series[1].ChartType = SeriesChartType.Line;
                    chart3.Legends.Add("目标运动轨迹");
                    chart3.Legends.Add("追踪轨迹");
                    chart3.Legends[0].DockedToChartArea = "ChartArea1";
                    chart3.Legends[1].DockedToChartArea = "ChartArea1";
                    chart3.Series[0].Legend = "目标运动轨迹";
                    chart3.Series[1].Legend = "追踪轨迹";
                    chart3.ChartAreas[0].AxisX.Interval = 50;
                    chart3.ChartAreas[0].AxisY.Interval = 50;

                    foreach (List<string> v in values)
                    {
                        chart3.Series[0].Points.AddXY(DoFormIdentify.toDouble(v[6]), DoFormIdentify.toDouble(v[7]));
                        chart3.Series[1].Points.AddXY(DoFormIdentify.toDouble(v[8]), DoFormIdentify.toDouble(v[9]));
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
