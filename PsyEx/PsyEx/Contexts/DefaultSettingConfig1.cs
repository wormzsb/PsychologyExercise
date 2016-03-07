using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Contexts
{
    public class DefaultSettingConfig1
    {
        public static string backgroundColor = "灰黑色";//背景颜色
        public static int testTime = 60;//测试时间
        public static int testNum = 1;//测试次数

        public static string particle = "圆形";//运动轨迹
        public static int direction = 1;//运动方向：0顺时针1逆时针
        public static bool pause = false;//暂停点
        public static int pauseRate = 0;//暂停频率
        public static int moveMode = 0;//运动方式：1平移+滚转0平移

        public static int ctrlDirection = 0;//控制方向0正向1反向
        public static int speedMode = 0;//速度模式0匀速1匀加速
        public static double speed = 100;//起始速度
        public static double fSpeed = 50;//加速模式起始速度
        public static double minSpeed = 50;//最小速度
        public static double maxSpeed = 150;//最大速度
        public static double minASpeed = 2;//最小加速度
        public static double maxASpeed = 5;//最大加速度

        public static double minGTASpeed = 0.0;//滚转最小角速度
        public static double maxGTASpeed = 0.0;//滚转最大角速度
        public static double minAngle = 0.0;//滚转最小角度
        public static double maxAngel = 0.0;//滚转最大角度

        
    }
}
