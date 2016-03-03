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

        //输出制定路径的文件
        public static bool doFileOutput(string path,string fileName,List<string> textList)
        {
            bool flag = false;
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(path + fileName, FileMode.Append);
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
                fs.Close();
                sw.Close();
            }


            return flag;
        }
    }
}
