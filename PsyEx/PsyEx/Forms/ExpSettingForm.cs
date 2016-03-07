using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using PsyEx.Mapper;

namespace PsyEx.Forms
{
    public partial class ExpSettingForm : Form
    {

        //实验配置窗口的记录map
        public static Dictionary<int, ExConfig> expConfigMap = new Dictionary<int, ExConfig>();

        //计数
        public int sortNum = 0;
        
        public ExpSettingForm()
        {
            InitializeComponent();
        }



        private void ExpSettingForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("任务1-目标跟踪能力测试");
            listBox1.Items.Add("任务2-操作力保持及时间知觉能力测试");
            listBox1.Items.Add("任务3-双任务模式突发事件反应时测试");
            listBox1.Items.Add("任务4-速度知觉能力测试");
            listBox1.Items.Add("任务5-三维心理旋转测试");
            if(MainForm.exFlag)
            {
                foreach(var item in MainForm.exConfigList)
                {
                    listBox2.Items.Add(item.ExName + "[未设置](" + item.SortId + ")");
                    if (item.SetFlag)
                    {
                        ChangeSetState(listBox2.Items[listBox2.Items.Count]);    
                    }
                    expConfigMap.Add(item.SortId, item);
                    if (item.SortId>=sortNum)
                    {
                        sortNum = item.SortId;
                    }            
                }
            }
        }

        //检查设置情况
        private bool CheckSetState()
        {
            foreach(var i in expConfigMap)
            {
                if (i.Value.SetFlag==false)
                {                    
                    return false;
                }
            }
            MainForm.exFlag = true;
            return true;
        }
        

        //向listbox2添加任务
        private void AddItem(object obj)
        {
            string SelectedItem = obj.ToString();
            sortNum++;

            //标记实验序号
            listBox2.Items.Add(SelectedItem + "[未设置]" + "(" + sortNum + ")");

            ExConfig setting = new ExConfig();
            setting.SortId = sortNum;
            setting.SetFlag = false;
            setting.ExName = SelectedItem;
            DateTime dt = DateTime.Now;
            setting.ExId = sortNum.ToString() + "_" + dt.ToFileTime().ToString();
            expConfigMap.Add(setting.SortId, setting);
        }

        //从listbox2删除任务
        private void RemoveItem(object obj, int index)
        {
            string SelectedItem = obj.ToString();
            listBox2.Items.Remove(obj);
            //调整实验序号
            for(int i=index; i<listBox2.Items.Count; i++)
            {
                string str = listBox2.Items[i].ToString();
                string newstr;
                newstr = str.Replace((char)(i + 2 + '0'), (char)(i + 1 + '0'));
                listBox2.Items[i] = newstr;
            }
            //移除map
            expConfigMap.Remove(index);
            for(int i=index+1; i<=sortNum; i++)
            {
                ExConfig t = new ExConfig();
                expConfigMap.TryGetValue(i, out t);
                expConfigMap.Remove(i);
                t.SortId--;
                expConfigMap.Add(t.SortId, t);
            }
            sortNum--;
        }

        //调整设置标记
        private object ChangeSetState(object obj)
        {
            string str = obj.ToString(), newstr;
            newstr = str.Replace("未", "已");
            return newstr;
        }


        //添加任务按钮
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm.exFlag = false;
            AddItem(listBox1.SelectedItem);            
        }

        //删除任务按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem!=null)
            {
                RemoveItem(listBox2.SelectedItem, listBox2.SelectedIndex);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        //配置参数按钮
        private void button5_Click(object sender, EventArgs e)
        {
            TaskSettingForm taskConfigForm = new TaskSettingForm();
            taskConfigForm.ShowDialog();

            //更新设置标记
            for(int i=0; i<listBox2.Items.Count; i++)
            {
                listBox2.Items[i] = ChangeSetState(listBox2.Items[i]);        
            }
            
        }

        //确认按钮
        private void button6_Click(object sender, EventArgs e)
        {
            if (CheckSetState())
            {
                foreach(var i in expConfigMap)
                {
                    MainForm.exConfigList.Add(i.Value);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("任务尚未进行设置", "提示");
            }                
        }
    }
}
