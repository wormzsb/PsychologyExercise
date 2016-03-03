namespace PsyEx.Mapper
{
    public class ExConfig
    {
        private string exId;//实验id
        private string exName;//实验名
        private int sortId;//排序序号
        private SettingConfig1 config1;
        private SettingConfig2 config2;
        private SettingConfig3 config3;
        private SettingConfig4 config4;
        private SettingConfig5 config5;

        public string ExId
        {
            get
            {
                return exId;
            }

            set
            {
                exId = value;
            }
        }

        public string ExName
        {
            get
            {
                return exName;
            }

            set
            {
                exName = value;
            }
        }

        public int SortId
        {
            get
            {
                return sortId;
            }

            set
            {
                sortId = value;
            }
        }

        internal SettingConfig1 Config1
        {
            get
            {
                return config1;
            }

            set
            {
                config1 = value;
            }
        }

        internal SettingConfig2 Config2
        {
            get
            {
                return config2;
            }

            set
            {
                config2 = value;
            }
        }

        internal SettingConfig3 Config3
        {
            get
            {
                return config3;
            }

            set
            {
                config3 = value;
            }
        }

        internal SettingConfig4 Config4
        {
            get
            {
                return config4;
            }

            set
            {
                config4 = value;
            }
        }

        internal SettingConfig5 Config5
        {
            get
            {
                return config5;
            }

            set
            {
                config5 = value;
            }
        }
    }
}
