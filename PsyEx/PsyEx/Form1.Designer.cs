namespace PsyEx
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.被试管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PresentTeserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实验设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PresentSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.硬件配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HDConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始实验ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结果分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开数据文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据批处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "被试管理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "硬件配置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(47, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "实验设置";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(304, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "开始实验";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(588, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(127, 33);
            this.button6.TabIndex = 6;
            this.button6.Text = "退出";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.被试管理ToolStripMenuItem,
            this.实验设置ToolStripMenuItem,
            this.硬件配置ToolStripMenuItem,
            this.开始实验ToolStripMenuItem,
            this.结果分析ToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 被试管理ToolStripMenuItem
            // 
            this.被试管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewTesterToolStripMenuItem,
            this.OpenTesterToolStripMenuItem,
            this.PresentTeserToolStripMenuItem});
            this.被试管理ToolStripMenuItem.Name = "被试管理ToolStripMenuItem";
            this.被试管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.被试管理ToolStripMenuItem.Text = "被试管理";
            // 
            // NewTesterToolStripMenuItem
            // 
            this.NewTesterToolStripMenuItem.Name = "NewTesterToolStripMenuItem";
            this.NewTesterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.NewTesterToolStripMenuItem.Text = "新建被试信息";
            this.NewTesterToolStripMenuItem.Click += new System.EventHandler(this.NewTesterToolStripMenuItem_Click);
            // 
            // OpenTesterToolStripMenuItem
            // 
            this.OpenTesterToolStripMenuItem.Name = "OpenTesterToolStripMenuItem";
            this.OpenTesterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.OpenTesterToolStripMenuItem.Text = "打开被试信息";
            this.OpenTesterToolStripMenuItem.Click += new System.EventHandler(this.OpenTesterToolStripMenuItem_Click);
            // 
            // PresentTeserToolStripMenuItem
            // 
            this.PresentTeserToolStripMenuItem.Name = "PresentTeserToolStripMenuItem";
            this.PresentTeserToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.PresentTeserToolStripMenuItem.Text = "当前被试信息";
            this.PresentTeserToolStripMenuItem.Click += new System.EventHandler(this.PresentTeserToolStripMenuItem_Click);
            // 
            // 实验设置ToolStripMenuItem
            // 
            this.实验设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewSettingToolStripMenuItem,
            this.OpenSettingToolStripMenuItem,
            this.PresentSettingToolStripMenuItem});
            this.实验设置ToolStripMenuItem.Name = "实验设置ToolStripMenuItem";
            this.实验设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.实验设置ToolStripMenuItem.Text = "实验设置";
            // 
            // NewSettingToolStripMenuItem
            // 
            this.NewSettingToolStripMenuItem.Name = "NewSettingToolStripMenuItem";
            this.NewSettingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.NewSettingToolStripMenuItem.Text = "新建配置";
            this.NewSettingToolStripMenuItem.Click += new System.EventHandler(this.NewSettingToolStripMenuItem_Click);
            // 
            // OpenSettingToolStripMenuItem
            // 
            this.OpenSettingToolStripMenuItem.Name = "OpenSettingToolStripMenuItem";
            this.OpenSettingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.OpenSettingToolStripMenuItem.Text = "打开配置";
            this.OpenSettingToolStripMenuItem.Click += new System.EventHandler(this.OpenSettingToolStripMenuItem_Click);
            // 
            // PresentSettingToolStripMenuItem
            // 
            this.PresentSettingToolStripMenuItem.Name = "PresentSettingToolStripMenuItem";
            this.PresentSettingToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.PresentSettingToolStripMenuItem.Text = "当前配置";
            this.PresentSettingToolStripMenuItem.Click += new System.EventHandler(this.PresentSettingToolStripMenuItem_Click);
            // 
            // 硬件配置ToolStripMenuItem
            // 
            this.硬件配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HDCalibrationToolStripMenuItem,
            this.HDConfigToolStripMenuItem});
            this.硬件配置ToolStripMenuItem.Name = "硬件配置ToolStripMenuItem";
            this.硬件配置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.硬件配置ToolStripMenuItem.Text = "硬件配置";
            // 
            // HDCalibrationToolStripMenuItem
            // 
            this.HDCalibrationToolStripMenuItem.Name = "HDCalibrationToolStripMenuItem";
            this.HDCalibrationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HDCalibrationToolStripMenuItem.Text = "硬件校准";
            this.HDCalibrationToolStripMenuItem.Click += new System.EventHandler(this.HDCalibrationToolStripMenuItem_Click);
            // 
            // HDConfigToolStripMenuItem
            // 
            this.HDConfigToolStripMenuItem.Name = "HDConfigToolStripMenuItem";
            this.HDConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HDConfigToolStripMenuItem.Text = "硬件设置";
            this.HDConfigToolStripMenuItem.Click += new System.EventHandler(this.HDConfigToolStripMenuItem_Click);
            // 
            // 开始实验ToolStripMenuItem
            // 
            this.开始实验ToolStripMenuItem.Name = "开始实验ToolStripMenuItem";
            this.开始实验ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.开始实验ToolStripMenuItem.Text = "开始实验";
            // 
            // 结果分析ToolStripMenuItem
            // 
            this.结果分析ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开数据文件ToolStripMenuItem,
            this.数据批处理ToolStripMenuItem});
            this.结果分析ToolStripMenuItem.Name = "结果分析ToolStripMenuItem";
            this.结果分析ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.结果分析ToolStripMenuItem.Text = "结果分析";
            // 
            // 打开数据文件ToolStripMenuItem
            // 
            this.打开数据文件ToolStripMenuItem.Name = "打开数据文件ToolStripMenuItem";
            this.打开数据文件ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.打开数据文件ToolStripMenuItem.Text = "打开数据文件";
            // 
            // 数据批处理ToolStripMenuItem
            // 
            this.数据批处理ToolStripMenuItem.Name = "数据批处理ToolStripMenuItem";
            this.数据批处理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.数据批处理ToolStripMenuItem.Text = "数据批处理";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(246, 63);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(469, 271);
            this.textBox1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(773, 414);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "眼/手协调性测试系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 被试管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewTesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PresentTeserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 实验设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PresentSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 硬件配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HDConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始实验ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 结果分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开数据文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据批处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
    }
}

