using SmileWei;
using SmileWei.EmbeddedApp;

namespace WeChartNotify
{
    partial class Form2
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemSetWinodwIn = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetWinodwIn,
            this.ToolStripMenuItem_Set});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // toolStripMenuItemSetWinodwIn
            // 
            this.toolStripMenuItemSetWinodwIn.Name = "toolStripMenuItemSetWinodwIn";
            this.toolStripMenuItemSetWinodwIn.Size = new System.Drawing.Size(124, 22);
            this.toolStripMenuItemSetWinodwIn.Text = "嵌入窗口";
            this.toolStripMenuItemSetWinodwIn.Click += new System.EventHandler(this.ToolStripMenuItemSetWinodwIn_Click);
            // 
            // ToolStripMenuItem_Set
            // 
            this.ToolStripMenuItem_Set.Name = "ToolStripMenuItem_Set";
            this.ToolStripMenuItem_Set.Size = new System.Drawing.Size(124, 22);
            this.ToolStripMenuItem_Set.Text = "设置";
            this.ToolStripMenuItem_Set.Click += new System.EventHandler(this.ToolStripMenuItem_Set_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form2";
            this.Text = "Wechat-Hook";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Event);
            this.Move += new System.EventHandler(this.Move_Event);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AppContainer appBox = new AppContainer();
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Set;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetWinodwIn;
    }
}