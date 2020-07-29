namespace RT2NMEA
{
    partial class TimeMatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeMatch));
            this.file1Pathtxt = new System.Windows.Forms.TextBox();
            this.file2Pathtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.file1PathSearchBtn = new System.Windows.Forms.Button();
            this.file2PathSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.outPut = new System.Windows.Forms.Button();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // file1Pathtxt
            // 
            this.file1Pathtxt.Location = new System.Drawing.Point(143, 62);
            this.file1Pathtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file1Pathtxt.Name = "file1Pathtxt";
            this.file1Pathtxt.ReadOnly = true;
            this.file1Pathtxt.Size = new System.Drawing.Size(508, 25);
            this.file1Pathtxt.TabIndex = 0;
            // 
            // file2Pathtxt
            // 
            this.file2Pathtxt.Location = new System.Drawing.Point(143, 110);
            this.file2Pathtxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file2Pathtxt.Name = "file2Pathtxt";
            this.file2Pathtxt.ReadOnly = true;
            this.file2Pathtxt.Size = new System.Drawing.Size(508, 25);
            this.file2Pathtxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "文件2路径：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(29, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "文件1路径：";
            // 
            // file1PathSearchBtn
            // 
            this.file1PathSearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.file1PathSearchBtn.Location = new System.Drawing.Point(660, 58);
            this.file1PathSearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file1PathSearchBtn.Name = "file1PathSearchBtn";
            this.file1PathSearchBtn.Size = new System.Drawing.Size(100, 29);
            this.file1PathSearchBtn.TabIndex = 6;
            this.file1PathSearchBtn.Text = "浏览";
            this.file1PathSearchBtn.UseVisualStyleBackColor = false;
            this.file1PathSearchBtn.Click += new System.EventHandler(this.file1PathSearchBtn_Click);
            // 
            // file2PathSearchBtn
            // 
            this.file2PathSearchBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.file2PathSearchBtn.Location = new System.Drawing.Point(660, 108);
            this.file2PathSearchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.file2PathSearchBtn.Name = "file2PathSearchBtn";
            this.file2PathSearchBtn.Size = new System.Drawing.Size(100, 29);
            this.file2PathSearchBtn.TabIndex = 7;
            this.file2PathSearchBtn.Text = "浏览";
            this.file2PathSearchBtn.UseVisualStyleBackColor = false;
            this.file2PathSearchBtn.Click += new System.EventHandler(this.file2PathSearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "推荐使用完整文件来求处理";
            // 
            // outPut
            // 
            this.outPut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outPut.Location = new System.Drawing.Point(768, 108);
            this.outPut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(100, 29);
            this.outPut.TabIndex = 9;
            this.outPut.Text = "导出";
            this.outPut.UseVisualStyleBackColor = false;
            this.outPut.Click += new System.EventHandler(this.outPut_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.SynchronizingObject = this;
            // 
            // TimeMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(916, 152);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.file2PathSearchBtn);
            this.Controls.Add(this.file1PathSearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.file2Pathtxt);
            this.Controls.Add(this.file1Pathtxt);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TimeMatch";
            this.Text = "时间对齐工具";
            this.Load += new System.EventHandler(this.TimeMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file1Pathtxt;
        private System.Windows.Forms.TextBox file2Pathtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button file1PathSearchBtn;
        private System.Windows.Forms.Button file2PathSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button outPut;
        private System.Timers.Timer timer2;
    }
}