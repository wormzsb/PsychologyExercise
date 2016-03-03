using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    public class SettingConfig3
    {
        private bool mainTest;//主任务

        private string moveTrail;//运动轨迹
        private int direction;//运动方向
        private int speedMode;//速度模式0匀速1匀加速
        private double speed;//起始速度
        private double minSpeed;//最小速度
        private double maxSpeed;//最大速度
        private double minASpeed;//最小加速度
        private double maxASpeed;//最大加速度

        private int ctrlDirection;//控制方向0正向1反向
        private string backgroundColor;//背景颜色
        private bool feedback;//反馈

        private int secTestMode;//次任务模式0简单反应1选择反应
        private bool leftUp;
        private bool leftDown;
        private bool rightUp;
        private bool rightDown;

        private int plane;//飞机比率
        private int copter;//直升机比率
        private int viewTime;//呈现时间
        private int waitTime;//等待反应时间
        private int minTimeSpace;
        private int maxTimeSpace;
        private int testNum;//测试次数

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

        public int SecTestMode
        {
            get
            {
                return secTestMode;
            }

            set
            {
                secTestMode = value;
            }
        }

        public bool LeftUp
        {
            get
            {
                return leftUp;
            }

            set
            {
                leftUp = value;
            }
        }

        public bool LeftDown
        {
            get
            {
                return leftDown;
            }

            set
            {
                leftDown = value;
            }
        }

        public bool RightUp
        {
            get
            {
                return rightUp;
            }

            set
            {
                rightUp = value;
            }
        }

        public bool RightDown
        {
            get
            {
                return rightDown;
            }

            set
            {
                rightDown = value;
            }
        }

        public int Plane
        {
            get
            {
                return plane;
            }

            set
            {
                plane = value;
            }
        }

        public int Copter
        {
            get
            {
                return copter;
            }

            set
            {
                copter = value;
            }
        }

        public int ViewTime
        {
            get
            {
                return viewTime;
            }

            set
            {
                viewTime = value;
            }
        }

        public int WaitTime
        {
            get
            {
                return waitTime;
            }

            set
            {
                waitTime = value;
            }
        }

        public int MinTimeSpace
        {
            get
            {
                return minTimeSpace;
            }

            set
            {
                minTimeSpace = value;
            }
        }

        public int MaxTimeSpace
        {
            get
            {
                return maxTimeSpace;
            }

            set
            {
                maxTimeSpace = value;
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
    }
}
