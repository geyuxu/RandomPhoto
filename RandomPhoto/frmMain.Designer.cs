namespace RandomPhoto
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pic = new System.Windows.Forms.PictureBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnChoujiang = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.ErrorImage = null;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(785, 316);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // tm
            // 
            this.tm.Interval = 10;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblClose);
            this.splitContainer1.Panel2.Controls.Add(this.btnChoujiang);
            this.splitContainer1.Size = new System.Drawing.Size(785, 384);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnChoujiang
            // 
            this.btnChoujiang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoujiang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnChoujiang.Font = new System.Drawing.Font("幼圆", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoujiang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChoujiang.Location = new System.Drawing.Point(327, 2);
            this.btnChoujiang.Name = "btnChoujiang";
            this.btnChoujiang.Size = new System.Drawing.Size(125, 59);
            this.btnChoujiang.TabIndex = 1;
            this.btnChoujiang.Text = "开始抽奖！";
            this.btnChoujiang.UseVisualStyleBackColor = false;
            this.btnChoujiang.Click += new System.EventHandler(this.btnChoujiang_Click);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(762, 49);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(11, 12);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnChoujiang;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(785, 384);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "南京罗友抽奖";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnChoujiang;
        private System.Windows.Forms.Label lblClose;
    }
}

