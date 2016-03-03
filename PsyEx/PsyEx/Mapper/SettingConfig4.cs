using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    public class SettingConfig4
    {
        //球颜色
        private int ballColorR;
        private int ballColorG;
        private int ballColorB;
        //背景色
        private int backgroundColorR;
        private int backgroundColorG;
        private int backgroundColorB;
        //遮挡物颜色
        private int shelterColorR;
        private int shelterColorG;
        private int shelterColorB;

        private int ballRadius;//球半径
        private int shelterRadius;//遮挡物半径
        private int ballCenterDis;//球到中心的距离

        //速度
        private int speed1;
        private int speed2;
        private int speed3;

        //起始位置
        private bool left;
        private bool right;
        private bool up;
        private bool down;

        private bool feedback;//反馈
        private int repeatNum;//重复次数
        private int timeInterval;//时间间隔

        public int BallColorR
        {
            get
            {
                return ballColorR;
            }

            set
            {
                ballColorR = value;
            }
        }

        public int BallColorG
        {
            get
            {
                return ballColorG;
            }

            set
            {
                ballColorG = value;
            }
        }

        public int BallColorB
        {
            get
            {
                return ballColorB;
            }

            set
            {
                ballColorB = value;
            }
        }

        public int BackgroundColorR
        {
            get
            {
                return backgroundColorR;
            }

            set
            {
                backgroundColorR = value;
            }
        }

        public int BackgroundColorG
        {
            get
            {
                return backgroundColorG;
            }

            set
            {
                backgroundColorG = value;
            }
        }

        public int BackgroundColorB
        {
            get
            {
                return backgroundColorB;
            }

            set
            {
                backgroundColorB = value;
            }
        }

        public int ShelterColorR
        {
            get
            {
                return shelterColorR;
            }

            set
            {
                shelterColorR = value;
            }
        }

        public int ShelterColorG
        {
            get
            {
                return shelterColorG;
            }

            set
            {
                shelterColorG = value;
            }
        }

        public int ShelterColorB
        {
            get
            {
                return shelterColorB;
            }

            set
            {
                shelterColorB = value;
            }
        }

        public int BallRadius
        {
            get
            {
                return ballRadius;
            }

            set
            {
                ballRadius = value;
            }
        }

        public int ShelterRadius
        {
            get
            {
                return shelterRadius;
            }

            set
            {
                shelterRadius = value;
            }
        }

        public int BallCenterDis
        {
            get
            {
                return ballCenterDis;
            }

            set
            {
                ballCenterDis = value;
            }
        }

        public int Speed1
        {
            get
            {
                return speed1;
            }

            set
            {
                speed1 = value;
            }
        }

        public int Speed2
        {
            get
            {
                return speed2;
            }

            set
            {
                speed2 = value;
            }
        }

        public int Speed3
        {
            get
            {
                return speed3;
            }

            set
            {
                speed3 = value;
            }
        }

        public bool Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public bool Right
        {
            get
            {
                return right;
            }

            set
            {
                right = value;
            }
        }

        public bool Up
        {
            get
            {
                return up;
            }

            set
            {
                up = value;
            }
        }

        public bool Down
        {
            get
            {
                return down;
            }

            set
            {
                down = value;
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

        public int RepeatNum
        {
            get
            {
                return repeatNum;
            }

            set
            {
                repeatNum = value;
            }
        }

        public int TimeInterval
        {
            get
            {
                return timeInterval;
            }

            set
            {
                timeInterval = value;
            }
        }
    }
}
