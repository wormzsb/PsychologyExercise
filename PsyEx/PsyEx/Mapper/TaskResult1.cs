using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace PsyEx.Mapper
{
    public class TaskResult1
    {
        private Tester tester;
        private SettingConfig1 settingconfig1;

        private int trial;
        private int pointNum;
        private DateTime pointTime;
        private double objPointX;
        private double objPointY;
        private double postPointX;
        private double postPointY;
        private double objRotate;
        private double postRotate;
        private double distance;
        private double rotateError;
        private bool hit;
        private double objSpeedX;
        private double objSpeedY;
        private double postSpeedX;
        private double postSpeedY;
        private double objRotateSpeed;
        private double postRotateSpeed;

        public int Trial
        {
            get
            {
                return trial;
            }

            set
            {
                trial = value;
            }
        }

        public int PointNum
        {
            get
            {
                return pointNum;
            }

            set
            {
                pointNum = value;
            }
        }

        public DateTime PointTime
        {
            get
            {
                return pointTime;
            }

            set
            {
                pointTime = value;
            }
        }

        public double ObjPointX
        {
            get
            {
                return objPointX;
            }

            set
            {
                objPointX = value;
            }
        }

        public double ObjPointY
        {
            get
            {
                return objPointY;
            }

            set
            {
                objPointY = value;
            }
        }

        public double PostPointX
        {
            get
            {
                return postPointX;
            }

            set
            {
                postPointX = value;
            }
        }

        public double PostPointY
        {
            get
            {
                return postPointY;
            }

            set
            {
                postPointY = value;
            }
        }

        public double ObjRotate
        {
            get
            {
                return objRotate;
            }

            set
            {
                objRotate = value;
            }
        }

        public double PostRotate
        {
            get
            {
                return postRotate;
            }

            set
            {
                postRotate = value;
            }
        }

        public double Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public double RotateError
        {
            get
            {
                return rotateError;
            }

            set
            {
                rotateError = value;
            }
        }

        public bool Hit
        {
            get
            {
                return hit;
            }

            set
            {
                hit = value;
            }
        }

        public double ObjSpeedX
        {
            get
            {
                return objSpeedX;
            }

            set
            {
                objSpeedX = value;
            }
        }

        public double ObjSpeedY
        {
            get
            {
                return objSpeedY;
            }

            set
            {
                objSpeedY = value;
            }
        }

        public double PostSpeedX
        {
            get
            {
                return postSpeedX;
            }

            set
            {
                postSpeedX = value;
            }
        }

        public double PostSpeedY
        {
            get
            {
                return postSpeedY;
            }

            set
            {
                postSpeedY = value;
            }
        }

        public double ObjRotateSpeed
        {
            get
            {
                return objRotateSpeed;
            }

            set
            {
                objRotateSpeed = value;
            }
        }

        public double PostRotateSpeed
        {
            get
            {
                return postRotateSpeed;
            }

            set
            {
                postRotateSpeed = value;
            }
        }

        public Tester Tester
        {
            get
            {
                return tester;
            }

            set
            {
                tester = value;
            }
        }

        public SettingConfig1 Settingconfig1
        {
            get
            {
                return settingconfig1;
            }

            set
            {
                settingconfig1 = value;
            }
        }
    }
}
