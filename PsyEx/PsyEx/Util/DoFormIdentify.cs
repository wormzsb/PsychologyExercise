using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using PsyEx.Mapper;
using PsyEx.Forms;

namespace PsyEx.Util
{
    public class DoFormIdentify
    {
        //判断空值
        public static bool isEmpty(string str)
        {
            if (str == string.Empty)
            {
                return true;
            }
            return false;
        }

        //转化为整形
        public static int toInt(string str)
        {
            int i = 0;
            int.TryParse(str, out i);
            return i;
        }

        //转化为double
        public static double toDouble(string str)
        {
            double i = 0.0;
            double.TryParse(str, out i);
            return i;
        }

        //限定输入必须为数字
        public static void isNum(KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))
                {
                    e.Handled = true;
                    MessageBox.Show("输入应为数字", "提示");
                }
            }
        }

        //产生指定的路径
        public static string MakeDirectoy(string foldername)
        {

            string sPath = Directory.GetCurrentDirectory() + "\\" + foldername;
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            return sPath;
        }

        //复制目录
        public static void copyDirectory(string sourceDirectory, string destDirectory)
        {
            //判断源目录和目标目录是否存在，如果不存在，则创建一个目录
            if (!Directory.Exists(sourceDirectory))
            {
                Directory.CreateDirectory(sourceDirectory);
            }
            if (!Directory.Exists(destDirectory))
            {
                Directory.CreateDirectory(destDirectory);
            }
            //拷贝文件
            copyFile(sourceDirectory, destDirectory);

            //拷贝子目录       
            //获取所有子目录名称
            string[] directionName = Directory.GetDirectories(sourceDirectory);

            foreach (string directionPath in directionName)
            {
                //根据每个子目录名称生成对应的目标子目录名称
                string directionPathTemp = destDirectory + "\\" + directionPath.Substring(sourceDirectory.Length + 1);

                //递归下去
                copyDirectory(directionPath, directionPathTemp);
            }
        }
        public static void copyFile(string sourceDirectory, string destDirectory)
        {
            //获取所有文件名称
            string[] fileName = Directory.GetFiles(sourceDirectory);

            foreach (string filePath in fileName)
            {
                //根据每个文件名称生成对应的目标文件名称
                string filePathTemp = destDirectory + "\\" + filePath.Substring(sourceDirectory.Length + 1);

                //若不存在，直接复制文件；若存在，覆盖复制
                if (File.Exists(filePathTemp))
                {
                    File.Copy(filePath, filePathTemp, true);
                }
                else
                {
                    File.Copy(filePath, filePathTemp);
                }
            }
        }


    }
}
