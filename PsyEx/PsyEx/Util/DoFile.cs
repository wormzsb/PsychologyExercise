using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using PsyEx.Mapper;

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

        //打开指定的结果文件
        public static TaskResult doResultInput(string fileName)
        {
            TaskResult tr = new TaskResult();
            FileStream fs = null;
            StreamReader sr = null;

            string[] info = fileName.Split("\\".ToArray());
            tr.Task = info[info.Length - 1].Split("-".ToArray())[0];

            try
            {
                fs = new FileStream(fileName, FileMode.Open);
                sr = new StreamReader(fs);
                //获取标题行
                string[] cols = sr.ReadLine().Split(",".ToArray());
                List<string> columns = new List<string>();
                for(int i = 0; i < cols.Length; i++)
                {
                    columns.Add(cols[i]);
                }

                tr.Columns = columns;
                //获取数据
                List<List<string>> values = new List<List<string>>();
                while (sr.Peek() >= 0)
                {
                    List<string> value = new List<string>();
                    string[] str = sr.ReadLine().Split(",".ToArray());
                    for (int i = 0; i < str.Length; i++)
                    {
                        value.Add(str[i]);
                    }
                    values.Add(value);

                }

                tr.Values = values;
                sr.Close();
                fs.Close();
            }
            catch (Exception)
            {
            }
            

            return tr;
        }

        //打开json文件
        public static string doFileJsonInput(string fileName)
        {
            string jsoninput = "";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(fileName, FileMode.Open);
                sr = new StreamReader(fs);

                jsoninput = sr.ReadLine();
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
            return jsoninput;
        }

        //解析json
        public static T parse<T>(string jsonString)
        {
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                return (T)new DataContractJsonSerializer(typeof(T)).ReadObject(ms);
            }
        }


    }
}
