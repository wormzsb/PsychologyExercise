using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    public class SettingConfig2
    {
        private bool mainTest;//主任务

        private string moveTrail;//运动轨迹
        private int direction;//运动方向
        private int speedMode;//速度模式0匀速1匀加速
        private double speed;//起始速度
        private double fspeed;//加速度起始速度
        private double minSpeed;//最小速度
        private double maxSpeed;//最大速度
        private double minASpeed;//最小加速度
        private double maxASpeed;//最大加速度

        private int ctrlDirection;//控制方向0正向1反向
        private string backgroundColor;//背景颜色
        private bool feedback;//反馈

        private int estimateNum;//待估次数
        private double estimate1;
        private double estimate2;
        private double estimate3;
        private double estimate4;
        private double estimate5;
        private double estimate6;
        private double estimate7;
        private double estimate8;
        private double estimate9;
        private double estimate10;
        private double estimate11;
        private double estimate12;
        private int loop;//循环次数

        public string MoveTrail
        {
            get
            {
                return moveTrail;
            }

            set
            {
                moveTrail = value;
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

        public double Fspeed
        {
            get
            {
                return Fspeed;
            }

            set
            {
                Fspeed = value;
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

        public bool Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }

        public int EstimateNum
        {
            get
            {
                return estimateNum;
            }

            set
            {
                estimateNum = value;
            }
        }

        public double Estimate1
        {
            get
            {
                return estimate1;
            }

            set
            {
                estimate1 = value;
            }
        }

        public double Estimate2
        {
            get
            {
                return estimate2;
            }

            set
            {
                estimate2 = value;
            }
        }

        public double Estimate3
        {
            get
            {
                return estimate3;
            }

            set
            {
                estimate3 = value;
            }
        }

        public double Estimate4
        {
            get
            {
                return estimate4;
            }

            set
            {
                estimate4 = value;
            }
        }

        public double Estimate5
        {
            get
            {
                return estimate5;
            }

            set
            {
                estimate5 = value;
            }
        }

        public double Estimate6
        {
            get
            {
                return estimate6;
            }

            set
            {
                estimate6 = value;
            }
        }

        public double Estimate7
        {
            get
            {
                return estimate7;
            }

            set
            {
                estimate7 = value;
            }
        }

        public double Estimate8
        {
            get
            {
                return estimate8;
            }

            set
            {
                estimate8 = value;
            }
        }

        public double Estimate9
        {
            get
            {
                return estimate9;
            }

            set
            {
                estimate9 = value;
            }
        }

        public double Estimate10
        {
            get
            {
                return estimate10;
            }

            set
            {
                estimate10 = value;
            }
        }

        public double Estimate11
        {
            get
            {
                return estimate11;
            }

            set
            {
                estimate11 = value;
            }
        }

        public double Estimate12
        {
            get
            {
                return estimate12;
            }

            set
            {
                estimate12 = value;
            }
        }

        public int Loop
        {
            get
            {
                return loop;
            }

            set
            {
                loop = value;
            }
        }

        public bool MainTest
        {
            get
            {
                return mainTest;
            }

            set
            {
                mainTest = value;
            }
        }
    }
}
