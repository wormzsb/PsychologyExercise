using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Util
{
    class TextContribute
    {
        //拼接主窗口打印内容
        public static List<string> printMainInfo(bool userFlag,bool exFlag,bool hwFlag,List<string> exName)
        {
            List<string> strList = new List<string>();
            strList.Add("【被试信息】：");
            if (userFlag)
            {

            }
            else
            {
                strList.Add("未配置");
            }


            return strList;
        }
    }
}
