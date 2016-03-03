using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsyEx.Mapper
{
    public class SettingConfig5
    {
        private int pointTime;//注视点时间
        private int viewTime;//呈现时间
        private int lastTime;//倒数时间

        public int PointTime
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

        public int LastTime
        {
            get
            {
                return lastTime;
            }

            set
            {
                lastTime = value;
            }
        }
    }
}
