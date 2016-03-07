using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PsyEx.Util
{
    public class DoFile
    {

        //输出指定路径的文件
        public static bool doFileOutput(string path,string fileName,List<string> textList)
        {
            bool flag = false;
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                if(File.Exists(path + "\\" + fileName))
                {
                    fs = new FileStream(path + "\\" + fileName, FileMode.Truncate, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(path + "\\" + fileName, FileMode.Append, FileAccess.Write);
                }

                sw = new StreamWriter(fs, Encoding.UTF8);
                foreach (string item in textList)
                {
                    sw.WriteLine(item);
                }
                flag = true;
            }
            catch (Exception)
            {
            }
            finally
            {
                sw.BaseStream.Flush();
                fs.Flush();
                sw.Close();
                fs.Close();
                
            }

            return flag;
        }

        //打开指定的文件
        public static List<Dictionary<string,string>> doFileInput(string fileName)
        {
            List<Dictionary<string, string>> DataList = new List<Dictionary<String, String>>();
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Open);
                sr = new StreamReader(fs);
                //未实现读取实验设置部分
                Dictionary<string, string> data = new Dictionary<String, String>();
                while (sr.Peek()>= 0)
                {
                    string str, key, value;
                    str = sr.ReadLine();
                    key = str.Substring(0, str.IndexOf("="));
                    value = str.Substring(str.IndexOf("=") + 1);
                    data.Add(key, value);
                }
                DataList.Add(data);
            }
            catch (Exception)
            {
            }
            finally
            {
                sr.BaseStream.Flush();
                fs.Flush();
                sr.Close();
                fs.Close();                
            }

            return DataList;
        }
    }
}
