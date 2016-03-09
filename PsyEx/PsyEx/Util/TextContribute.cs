using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PsyEx.Mapper;

namespace PsyEx.Util
{
    public class TextContribute
    {
        //拼接主窗口打印内容
        public static List<string> printMainInfo(bool userFlag,bool exFlag,bool hwFlag)
        {
            List<string> strList = new List<string>();
            strList.Add("【被试信息】：");
            strList.Add(" ");
            if (userFlag)
            {
                strList.Add("  编号：" + MainForm.tester.Id);
                strList.Add("  姓名：" + MainForm.tester.Name);
                strList.Add("  性别：" + MainForm.tester.Sex);
                strList.Add("  年龄：" + MainForm.tester.Age);
                strList.Add("  第N次：" + MainForm.tester.Count);
            }
            else
            {
                strList.Add("  未配置");
            }

            strList.Add(" ");

            strList.Add("【实验信息】：");
            strList.Add(" ");

            if (exFlag)
            {
                foreach(ExConfig ex in MainForm.exConfigList)
                {
                    strList.Add("  " + ex.SortId + "." + ex.ExName);
                }
            }
            else
            {
                strList.Add("  未配置");
            }

            strList.Add(" ");

            strList.Add("【硬件信息】：");
            strList.Add(" ");


            if (hwFlag)
            {
                strList.Add("  速度：" + MainForm.hdConfig.Speed);
                strList.Add("  灵敏度：" + MainForm.hdConfig.Sensibility);
                strList.Add("  位移：" + MainForm.hdConfig.Distance);
                strList.Add("  角度：" + MainForm.hdConfig.Angle);
            }
            else
            {
                strList.Add("  未配置");
            }

            return strList;
        }
    }
}
