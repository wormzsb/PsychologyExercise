using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Util
{
    public class DoMath
    {
        //计算据对值平均值
        //三位小数
        public static string dataToAbsAvg(List<string> data)
        {
            double all = 0.000d;
            double size = (double)data.Count();
            string result = "";
            foreach(string item in data)
            {
                all += Math.Abs(DoFormIdentify.toDouble(item));
            }
            
            result = String.Format("{0:0.000}", all / size);

            return result;
        }

        //计算据对值平均值
        //1位小数
        public static string dataToAbsAvgForOne(List<string> data)
        {
            double all = 0.000d;
            double size = (double)data.Count();
            string result = "";
            foreach (string item in data)
            {
                all += Math.Abs(DoFormIdentify.toDouble(item));
            }

            result = String.Format("{0:0.0}", all / size);

            return result;
        }

        //绝对值标准差
        public static string dataToSD(List<string> data)
        {
            double avg = DoFormIdentify.toDouble(dataToAbsAvg(data));

            double variance = 0;
            foreach (string item in data)
            {
                variance += Math.Pow(DoFormIdentify.toDouble(item) - avg, 2);
            }
            double sd = Math.Pow(variance, 0.5);         

            return String.Format("{0:0.000}", sd);
        }

        //绝对值标准差
        public static string dataToSDForOne(List<string> data)
        {
            double avg = DoFormIdentify.toDouble(dataToAbsAvg(data));

            double variance = 0;
            foreach (string item in data)
            {
                variance += Math.Pow(DoFormIdentify.toDouble(item) - avg, 2);
            }
            double sd = Math.Pow(variance, 0.5);

            return String.Format("{0:0.0}", sd);
        }
    }
}
