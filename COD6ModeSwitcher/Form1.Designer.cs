namespace COD6ModeSwitcher
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelCurMode = new System.Windows.Forms.Label();
            this.BtnSingle = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.LabelAbout = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelCurMode
            // 
            this.LabelCurMode.AutoSize = true;
            this.LabelCurMode.ForeColor = System.Drawing.Color.Blue;
            this.LabelCurMode.Location = new System.Drawing.Point(14, 13);
            this.LabelCurMode.Name = "LabelCurMode";
            this.LabelCurMode.Size = new System.Drawing.Size(101, 17);
            this.LabelCurMode.TabIndex = 0;
            this.LabelCurMode.Text = "Current Mode : ";
            // 
            // BtnSingle
            // 
            this.BtnSingle.Location = new System.Drawing.Point(16, 33);
            this.BtnSingle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSingle.Name = "BtnSingle";
            this.BtnSingle.Size = new System.Drawing.Size(127, 54);
            this.BtnSingle.TabIndex = 1;
            this.BtnSingle.Text = "SinglePlayer";
            this.BtnSingle.UseVisualStyleBackColor = true;
            this.BtnSingle.Click += new System.EventHandler(this.BtnSingle_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(209, 33);
            this.BtnMulti.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(127, 54);
            this.BtnMulti.TabIndex = 2;
            this.BtnMulti.Text = "MultiPlayer";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // LabelAbout
            // 
            this.LabelAbout.AutoSize = true;
            this.LabelAbout.Location = new System.Drawing.Point(14, 96);
            this.LabelAbout.Name = "LabelAbout";
            this.LabelAbout.Size = new System.Drawing.Size(108, 17);
            this.LabelAbout.TabIndex = 3;
            this.LabelAbout.Text = "OS Information : \r\n";
            // 
            // BtnStart
            // 
            this.BtnStart.ForeColor = System.Drawing.Color.Green;
            this.BtnStart.Location = new System.Drawing.Point(149, 33);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(54, 53);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Start\r\nGame";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 141);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelAbout);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.BtnSingle);
            this.Controls.Add(this.LabelCurMode);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Call Of Duty 6-Mode Switcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelCurMode;
        private System.Windows.Forms.Button BtnSingle;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Label LabelAbout;
        private System.Windows.Forms.Button BtnStart;
    }
}

