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
    public class DoForm
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




    }
}
