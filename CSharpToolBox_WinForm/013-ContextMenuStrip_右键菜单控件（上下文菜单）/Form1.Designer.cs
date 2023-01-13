namespace _013
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭窗体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开窗体ToolStripMenuItem,
            this.关闭窗体ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            // 
            // 打开窗体ToolStripMenuItem
            // 
            this.打开窗体ToolStripMenuItem.Name = "打开窗体ToolStripMenuItem";
            this.打开窗体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开窗体ToolStripMenuItem.Text = "打开窗体";
            this.打开窗体ToolStripMenuItem.Click += new System.EventHandler(this.打开窗体ToolStripMenuItem_Click);
            // 
            // 关闭窗体ToolStripMenuItem
            // 
            this.关闭窗体ToolStripMenuItem.Name = "关闭窗体ToolStripMenuItem";
            this.关闭窗体ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭窗体ToolStripMenuItem.Text = "关闭窗体";
            this.关闭窗体ToolStripMenuItem.Click += new System.EventHandler(this.关闭窗体ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 213);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Name = "Form1";
            this.Text = "ContextMenuStrip";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭窗体ToolStripMenuItem;
    }
}

