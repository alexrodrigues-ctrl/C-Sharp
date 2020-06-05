namespace Aplicativo
{
    partial class FrmWebForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWebForm));
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fecharWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 24);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(516, 450);
            this.webBrowser.TabIndex = 0;
            this.webBrowser.Url = new System.Uri("http:\\\\www.google.com.br", System.UriKind.Absolute);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogToolStripMenuItem,
            this.fecharWebToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(516, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fecharWebToolStripMenuItem
            // 
            this.fecharWebToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharWebToolStripMenuItem.Image")));
            this.fecharWebToolStripMenuItem.Name = "fecharWebToolStripMenuItem";
            this.fecharWebToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.fecharWebToolStripMenuItem.Text = "Fechar Web";
            this.fecharWebToolStripMenuItem.Click += new System.EventHandler(this.fecharWebToolStripMenuItem_Click);
            // 
            // blogToolStripMenuItem
            // 
            this.blogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blogToolStripMenuItem.Image")));
            this.blogToolStripMenuItem.Name = "blogToolStripMenuItem";
            this.blogToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.blogToolStripMenuItem.Text = "Blog";
            this.blogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // FrmWebForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 474);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmWebForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmWebForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmWebForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogToolStripMenuItem;
    }
}