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
            
            if(size == 0)
            {
                return "0";
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

            if (size == 0)
            {
                return "0";
            }

            result = String.Format("{0:0.0}", all / size);

            return result;
        }

        //绝对值标准差
        public static string dataToSD(List<string> data)
        {
            double avg = DoFormIdentify.toDouble(dataToAbsAvg(data));

            double variance = 0;
            double size = data.Count()-1;
            foreach (string item in data)
            {
                variance += Math.Pow(DoFormIdentify.toDouble(item) - avg, 2);
            }
            if (size == 0)
            {
                return "0";
            }


            double sd = Math.Pow(variance / size, 0.5);         

            return String.Format("{0:0.000}", sd);
        }

        //绝对值标准差
        public static string dataToSDForOne(List<string> data)
        {
            double avg = DoFormIdentify.toDouble(dataToAbsAvg(data));

            double variance = 0;
            double size = data.Count()-1;
            foreach (string item in data)
            {
                variance += Math.Pow(DoFormIdentify.toDouble(item) - avg, 2);
            }

            if (size == 0)
            {
                return "0";
            }

            double sd = Math.Pow(variance / size, 0.5);

            return String.Format("{0:0.0}", sd);
        }

        //中位数
        public static string dataToMiddle(List<string> data)
        {
            List<double> sortData = new List<double>();
            double middle = 0;

            foreach(string i in data)
            {
                sortData.Add(DoFormIdentify.toDouble(i));
            }

            int count = sortData.Count;
            for(int i=0; i<count; i++)
            {
                for(int j= i; j<count; j++)
                {
                    if(sortData[i]>sortData[j])
                    {
                        double t = sortData[i];
                        sortData[i] = sortData[j];
                        sortData[j] = t;
                    }
                }
            }

            if (count % 2 == 1)
            {
                middle = sortData[(count - 1) / 2];
            }
            else
            {
                middle = sortData[count / 2] + sortData[count / 2 - 1];
                middle /= 2;
            }

            return string.Format("{0:0.000}", middle);

        }
    }
}
