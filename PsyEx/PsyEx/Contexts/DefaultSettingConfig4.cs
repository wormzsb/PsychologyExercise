using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Contexts
{
    public class DefaultSettingConfig4
    {
        //球颜色
        public static int ballColorR = 255;
        public static int ballColorG = 0;
        public static int ballColorB = 0;
        //背景色
        public static int backgroundColorR = 0;
        public static int backgroundColorG = 0;
        public static int backgroundColorB = 0;
        //遮挡物颜色
        public static int shelterColorR = 80;
        public static int shelterColorG = 80;
        public static int shelterColorB = 80;

        public static int ballRadius = 15;//球半径
        public static int shelterRadius = 180;//遮挡物半径
        public static int ballCenterDis = 330;//球到中心的距离

        //速度
        public static int speed1 = 50;
        public static int speed2 = 100;
        public static int speed3 = 150;

        //起始位置
        public static bool left = true;
        public static bool right = true;
        public static bool up = true;
        public static bool down = true;

        public static bool feedback = true;//反馈
        public static int repeatNum = 3;//重复次数
        public static int timeInterval = 1;//时间间隔
    }
}
