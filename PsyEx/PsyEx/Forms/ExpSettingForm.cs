using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Mapper;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using PsyEx.Util;

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
                        listBox2.Items[listBox2.Items.Count - 1] = ChangeSetState(listBox2.Items[listBox2.Items.Count - 1]);    
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
        
        //转化为json
        private string JsonOutput(List<ExConfig> setting)
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(setting.GetType());
            string szJson = "";

            //序列化
            using (MemoryStream stream = new MemoryStream())
            {
                json.WriteObject(stream, setting);
                szJson = Encoding.UTF8.GetString(stream.ToArray());
            }
            return szJson;
        }

        //打开文件
        private bool opendata(string directory)
        {
            string jsonstr;
            jsonstr = DoFile.doFileJsonInput(directory);
            List<ExConfig> jsondata = new List<ExConfig>();
            jsondata = DoFile.parse<List<ExConfig>>(jsonstr);
            expConfigMap.Clear();
            for(int i=0; i<jsondata.Count; i++)
            {
                expConfigMap.Add(i + 1, jsondata[i]);
            }
            return true;
        } 

        //保存数据
        private bool savedata(string directory, string filename)
        {
            if (CheckSetState())
            {
                List<ExConfig> savedata = new List<ExConfig>();
                foreach (var item in expConfigMap)
                {
                    savedata.Add(item.Value);
                }
                List<string> json_save = new List<string>();
                json_save.Add(JsonOutput(savedata));

                if (DoFormIdentify.isEmpty(filename))
                {
                    filename = MainForm.tester.Id + "_" + MainForm.tester.Name + "_autosave" + ".set";
                }

                if (DoFile.doFileOutput(directory, filename, json_save))
                {
                    return true;
                }
            }
            return false;
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
            setting.ExId = SelectedItem[SelectedItem.IndexOf("-") - 1] + "_" + dt.ToFileTime().ToString();
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
            //移除旧项添加新项
            int boxindex = index;
            expConfigMap.Remove(index+1);
            for(int i=index+2; i<=sortNum; i++)
            {
                string tochange;
                tochange = listBox2.Items[boxindex].ToString();
                listBox2.Items.Remove(listBox2.Items[boxindex]);
                tochange = tochange.Substring(0, tochange.IndexOf("]") + 1);
                ExConfig t = new ExConfig();
                expConfigMap.TryGetValue(i, out t);
                expConfigMap.Remove(i);
                t.SortId--;
                expConfigMap.Add(t.SortId, t);
                listBox2.Items.Add(tochange + "(" + t.SortId + ")");
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

        //执行清理
        private void clear()
        {            
            sortNum = 0;
            expConfigMap.Clear();
            this.Dispose();
        }

        //配置参数按钮
        private void button5_Click(object sender, EventArgs e)
        {
            TaskSettingForm taskConfigForm = new TaskSettingForm();
            taskConfigForm.ShowDialog();

            //更新设置标记
            foreach(var i in expConfigMap)
            {
                if (i.Value.SetFlag)
                {
                    listBox2.Items[i.Key-1] = ChangeSetState(listBox2.Items[i.Key-1]);
                }
            }
            
        }

        //确认按钮
        private void button6_Click(object sender, EventArgs e)
        {
            if (CheckSetState())
            {
                MainForm.exConfigList.Clear();
                foreach(var i in expConfigMap)
                {
                    MainForm.exConfigList.Add(i.Value);
                }
                if (savedata(DoFormIdentify.MakeDirectoy("TaskSetting"),""))
                {
                    MessageBox.Show("保存成功", "提示");
                    clear();


                    //print
                    List<string> strList = TextContribute.printMainInfo(MainForm.userFlag, MainForm.exFlag, MainForm.hwFlag);
                    Program.m.textBox1.Text = "";
                    foreach (string str in strList)
                    {
                        Program.m.textBox1.Text += Environment.NewLine + str;
                    }
                    expConfigMap.Clear();
                    sortNum = 0;
                    this.Dispose();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("保存失败", "提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("任务尚未进行设置", "提示");
            }                
        }

        private void ExpSettingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            clear();
        }

        //另存为按钮
        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckSetState())
            {
                saveFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TaskSetting");
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("任务尚未进行设置", "提示");
            }
        }

        //打开配置文件
        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = DoFormIdentify.MakeDirectoy("TaskSetting");
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            string localFilePath = saveFileDialog1.FileName, FilePath, FileName;
            FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));
            FileName = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);
            if(savedata(FilePath,FileName))
            {
                MessageBox.Show("保存成功", "提示");
            }
            else
            {
                MessageBox.Show("保存失败", "提示");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if(opendata(openFileDialog1.FileName))
            {
                MessageBox.Show("读取成功", "提示");

                listBox2.Items.Clear();
                
                foreach(var item in expConfigMap)
                {
                    listBox2.Items.Add(item.Value.ExName + "[未设置](" + item.Value.SortId + ")");
                    if (item.Value.SetFlag)
                    {
                        listBox2.Items[listBox2.Items.Count - 1] = ChangeSetState(listBox2.Items[listBox2.Items.Count - 1]);
                    }                    
                    if (item.Value.SortId >= sortNum)
                    {
                        sortNum = item.Value.SortId;
                    }
                }
                MainForm.exConfigList.Clear();
                MainForm.exFlag = false;
            }
        }



    }
}
