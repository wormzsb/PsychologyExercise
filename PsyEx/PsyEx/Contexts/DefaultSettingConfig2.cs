using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Contexts
{
    class DefaultSettingConfig2
    {
        public static bool mainTest = true;//主任务

        public static string moveTrail = "圆形";//运动轨迹
        public static int direction = 1;//运动方向0顺时针1逆时针
        public static int speedMode = 0;//速度模式0匀速1匀加速
        public static double speed = 100;//起始速度
        public static double minSpeed = 50;//最小速度
        public static double maxSpeed = 150;//最大速度
        public static double minASpeed = 2;//最小加速度
        public static double maxASpeed = 5;//最大加速度

        public static int ctrlDirection = 0;//控制方向0正向1反向
        public static string backgroundColor = "灰黑色";//背景颜色
        public static bool feedback = true;//反馈

        public static int estimateNum = 4;//待估次数
        public static double estimate1 = 3.0;
        public static double estimate2 = 6.0;
        public static double estimate3 = 9.0;
        public static double estimate4 = 12.0;
        public static double estimate5 = 0.0;
        public static double estimate6 = 0.0;
        public static double estimate7 = 0.0;
        public static double estimate8 = 0.0;
        public static double estimate9 = 0.0;
        public static double estimate10 = 0.0;
        public static double estimate11 = 0.0;
        public static double estimate12 = 0.0;
        public static int loop = 1;//循环次数

       
    }
}
