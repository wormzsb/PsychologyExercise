using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Contexts
{
    public class DefaultSettingConfig3
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

        public static int secTestMode = 0;//次任务模式0简单反应1选择反应
        public static bool leftUp = true;
        public static bool leftDown = true;
        public static bool rightUp = true;
        public static bool rightDown = true;

        public static int plane = 1;//飞机比率
        public static int copter = 1;//直升机比率
        public static int viewTime = 2 ;//呈现时间
        public static int waitTime = 2;//等待反应时间
        public static int minTimeSpace = 4;
        public static int maxTimeSpace = 8;
        public static int testNum = 1;//测试次数

        
    }
}
