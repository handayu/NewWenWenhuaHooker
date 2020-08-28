namespace SmileWei.EmbeddedApp.WinForm
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnBrowseApp = new System.Windows.Forms.Button();
            this.txtAppFilename = new System.Windows.Forms.TextBox();
            this.openApp = new System.Windows.Forms.OpenFileDialog();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblEmbedAgain = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmbedHandle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_XY = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox_StartX = new System.Windows.Forms.TextBox();
            this.textBox_StartY = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseApp
            // 
            this.btnBrowseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseApp.Location = new System.Drawing.Point(380, 331);
            this.btnBrowseApp.Name = "btnBrowseApp";
            this.btnBrowseApp.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseApp.TabIndex = 1;
            this.btnBrowseApp.Text = "浏览...";
            this.btnBrowseApp.UseVisualStyleBackColor = true;
            this.btnBrowseApp.Click += new System.EventHandler(this.btnBrowseApp_Click);
            // 
            // txtAppFilename
            // 
            this.txtAppFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAppFilename.Location = new System.Drawing.Point(234, 331);
            this.txtAppFilename.Name = "txtAppFilename";
            this.txtAppFilename.ReadOnly = true;
            this.txtAppFilename.Size = new System.Drawing.Size(140, 21);
            this.txtAppFilename.TabIndex = 2;
            // 
            // openApp
            // 
            this.openApp.Filter = "可执行程序 (*.exe)|*.exe";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEmbedAgain,
            this.lblEmbedHandle,
            this.lblInfo,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_XY});
            this.statusMain.Location = new System.Drawing.Point(0, 357);
            this.statusMain.Name = "statusMain";
            this.statusMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMain.Size = new System.Drawing.Size(467, 22);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // lblEmbedAgain
            // 
            this.lblEmbedAgain.Name = "lblEmbedAgain";
            this.lblEmbedAgain.Size = new System.Drawing.Size(56, 17);
            this.lblEmbedAgain.Text = "再次嵌入";
            this.lblEmbedAgain.Click += new System.EventHandler(this.lblEmbedAgain_Click);
            // 
            // lblEmbedHandle
            // 
            this.lblEmbedHandle.Name = "lblEmbedHandle";
            this.lblEmbedHandle.Size = new System.Drawing.Size(56, 17);
            this.lblEmbedHandle.Text = "句柄嵌入";
            this.lblEmbedHandle.Click += new System.EventHandler(this.lblEmbedHandle_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(47, 17);
            this.lblInfo.Text = "handle";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "透明/实体";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel_XY
            // 
            this.toolStripStatusLabel_XY.Name = "toolStripStatusLabel_XY";
            this.toolStripStatusLabel_XY.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel_XY.Text = "X: Y:";
            // 
            // textBox_StartX
            // 
            this.textBox_StartX.Location = new System.Drawing.Point(12, 334);
            this.textBox_StartX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_StartX.Name = "textBox_StartX";
            this.textBox_StartX.Size = new System.Drawing.Size(42, 21);
            this.textBox_StartX.TabIndex = 4;
            // 
            // textBox_StartY
            // 
            this.textBox_StartY.Location = new System.Drawing.Point(58, 334);
            this.textBox_StartY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_StartY.Name = "textBox_StartY";
            this.textBox_StartY.Size = new System.Drawing.Size(44, 21);
            this.textBox_StartY.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 334);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 21);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 334);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 21);
            this.textBox2.TabIndex = 6;
            // 
            // appBox
            // 
            this.appBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appBox.AppFilename = "";
            this.appBox.AppProcess = null;
            this.appBox.Location = new System.Drawing.Point(12, 12);
            this.appBox.Name = "appBox";
            this.appBox.ShowEmbedResult = false;
            this.appBox.Size = new System.Drawing.Size(443, 313);
            this.appBox.TabIndex = 0;
            this.appBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_AppBox);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 379);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox_StartY);
            this.Controls.Add(this.textBox_StartX);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.txtAppFilename);
            this.Controls.Add(this.btnBrowseApp);
            this.Controls.Add(this.appBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "内嵌程序";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AppContainer appBox;
        private System.Windows.Forms.Button btnBrowseApp;
        private System.Windows.Forms.TextBox txtAppFilename;
        private System.Windows.Forms.OpenFileDialog openApp;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblEmbedAgain;
        private System.Windows.Forms.ToolStripStatusLabel lblEmbedHandle;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox_StartX;
        private System.Windows.Forms.TextBox textBox_StartY;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_XY;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

