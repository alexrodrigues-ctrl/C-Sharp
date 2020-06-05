namespace Aplicativo
{
    partial class FrmLicenca
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.btnObter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(326, 100);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(15, 100);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(305, 20);
            this.txtChave.TabIndex = 1;
            this.txtChave.Text = "Digite a chave";
            // 
            // btnObter
            // 
            this.btnObter.Location = new System.Drawing.Point(15, 71);
            this.btnObter.Name = "btnObter";
            this.btnObter.Size = new System.Drawing.Size(75, 23);
            this.btnObter.TabIndex = 2;
            this.btnObter.Text = "Obter";
            this.btnObter.UseVisualStyleBackColor = true;
            this.btnObter.Click += new System.EventHandler(this.btnObter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clique em Obter licença para ir para SITE";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObter);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLicenca";
            this.Text = "FrmLicenca";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnObter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
    }
}