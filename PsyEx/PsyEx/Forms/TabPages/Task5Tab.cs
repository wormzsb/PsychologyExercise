﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsyEx.Mapper;
using PsyEx.Contexts;

namespace PsyEx.Forms.TabPages
{
    public partial class Task5Tab : UserControl
    {
        public SettingConfig5 config;
        public bool defaultFlag = true;
        public Task5Tab()
        {
            InitializeComponent();
        }
    }
}
