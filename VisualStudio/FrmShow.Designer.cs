namespace Aplicativo
{
    partial class FrmShow
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
            this.lbTextoNome = new System.Windows.Forms.Label();
            this.lbTextoID = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTextoNome
            // 
            this.lbTextoNome.AutoSize = true;
            this.lbTextoNome.Location = new System.Drawing.Point(30, 42);
            this.lbTextoNome.Name = "lbTextoNome";
            this.lbTextoNome.Size = new System.Drawing.Size(16, 13);
            this.lbTextoNome.TabIndex = 0;
            this.lbTextoNome.Text = "...";
            // 
            // lbTextoID
            // 
            this.lbTextoID.AutoSize = true;
            this.lbTextoID.Location = new System.Drawing.Point(30, 110);
            this.lbTextoID.Name = "lbTextoID";
            this.lbTextoID.Size = new System.Drawing.Size(16, 13);
            this.lbTextoID.TabIndex = 1;
            this.lbTextoID.Text = "...";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(115, 174);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FrmShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 209);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lbTextoID);
            this.Controls.Add(this.lbTextoNome);
            this.Name = "FrmShow";
            this.Text = "FrmShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Label lbTextoNome;
        public System.Windows.Forms.Label lbTextoID;
    }
}