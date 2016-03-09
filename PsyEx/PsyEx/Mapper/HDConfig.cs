using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    public class HDConfig
    {
        private double speed;//速度
        private double sensibility;//灵敏度
        private double distance;//位移
        private double angle;//角度

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

        public double Sensibility
        {
            get
            {
                return sensibility;
            }

            set
            {
                sensibility = value;
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

        public double Angle
        {
            get
            {
                return angle;
            }

            set
            {
                angle = value;
            }
        }
    }
}
