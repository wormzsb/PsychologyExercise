namespace PsyEx.Forms
{
    partial class ExpSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(50, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择实验任务";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 220);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "→";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "←";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(308, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(247, 220);
            this.listBox2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "↑";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(561, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "↓";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(50, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 64);
            this.button5.TabIndex = 1;
            this.button5.Text = "设置当前选中任务参数";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 310);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(155, 64);
            this.button6.TabIndex = 2;
            this.button6.Text = "保存该次实验配置信息";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(499, 310);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(155, 64);
            this.button7.TabIndex = 3;
            this.button7.Text = "打开已保存的实验配置";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(277, 407);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(155, 64);
            this.button8.TabIndex = 4;
            this.button8.Text = "确认使用该配置";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ExpSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 562);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpSettingForm";
            this.Text = "实验设置";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}