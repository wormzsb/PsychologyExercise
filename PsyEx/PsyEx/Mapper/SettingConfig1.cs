using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    class SettingConfig1
    {
        private string backgroundColor;//背景颜色
        private int testTime;//测试时间
        private int testNum;//测试次数

        private string particle;//运动轨迹
        private int direction;//运动方向：0顺时针1逆时针
        private bool pause;//暂停点
        private int pauseRate;//暂停频率
        private int moveMode;//运动方式：1平移+滚转0平移

        private int ctrlDirection;//控制方向0正向1反向
        private int speedMode;//速度模式0匀速1匀加速
        private double speed;//起始速度
        private double minSpeed;//最小速度
        private double maxSpeed;//最大速度
        private double minASpeed;//最小加速度
        private double maxASpeed;//最大加速度

        private double minGTASpeed;//滚转最小角速度
        private double maxGTASpeed;//滚转最大角速度
        private double minAngle;//滚转最小角度
        private double maxAngel;//滚转最大角度

        public string BackgroundColor
        {
            get
            {
                return backgroundColor;
            }

            set
            {
                backgroundColor = value;
            }
        }

        public int TestTime
        {
            get
            {
                return testTime;
            }

            set
            {
                testTime = value;
            }
        }

        public int TestNum
        {
            get
            {
                return testNum;
            }

            set
            {
                testNum = value;
            }
        }

        public string Particle
        {
            get
            {
                return particle;
            }

            set
            {
                particle = value;
            }
        }

        public int Direction
        {
            get
            {
                return direction;
            }

            set
            {
                direction = value;
            }
        }

        public bool Pause
        {
            get
            {
                return pause;
            }

            set
            {
                pause = value;
            }
        }

        public int PauseRate
        {
            get
            {
                return pauseRate;
            }

            set
            {
                pauseRate = value;
            }
        }

        public int MoveMode
        {
            get
            {
                return moveMode;
            }

            set
            {
                moveMode = value;
            }
        }

        public int CtrlDirection
        {
            get
            {
                return ctrlDirection;
            }

            set
            {
                ctrlDirection = value;
            }
        }

        public int SpeedMode
        {
            get
            {
                return speedMode;
            }

            set
            {
                speedMode = value;
            }
        }

        public double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public double MinSpeed
        {
            get
            {
                return minSpeed;
            }

            set
            {
                minSpeed = value;
            }
        }

        public double MaxSpeed
        {
            get
            {
                return maxSpeed;
            }

            set
            {
                maxSpeed = value;
            }
        }

        public double MinASpeed
        {
            get
            {
                return minASpeed;
            }

            set
            {
                minASpeed = value;
            }
        }

        public double MaxASpeed
        {
            get
            {
                return maxASpeed;
            }

            set
            {
                maxASpeed = value;
            }
        }

        public double MinGTASpeed
        {
            get
            {
                return minGTASpeed;
            }

            set
            {
                minGTASpeed = value;
            }
        }

        public double MaxGTASpeed
        {
            get
            {
                return maxGTASpeed;
            }

            set
            {
                maxGTASpeed = value;
            }
        }

        public double MinAngle
        {
            get
            {
                return minAngle;
            }

            set
            {
                minAngle = value;
            }
        }

        public double MaxAngel
        {
            get
            {
                return maxAngel;
            }

            set
            {
                maxAngel = value;
            }
        }
    }
}
