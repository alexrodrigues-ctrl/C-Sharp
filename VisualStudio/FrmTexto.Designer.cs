namespace Aplicativo
{
    partial class FrmTexto
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
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(0, 27);
            this.tbTexto.Multiline = true;
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(1245, 490);
            this.tbTexto.TabIndex = 0;
            this.tbTexto.TextChanged += new System.EventHandler(this.tbTexto_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.salvarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1245, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.arquivoToolStripMenuItem.Text = "Salvar";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.salvarToolStripMenuItem1.Text = "Fechar";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.salvarToolStripMenuItem1_Click);
            // 
            // FrmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 508);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmTexto";
            this.Text = "FrmTexto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
    }
}