namespace Aplicativo
{
    partial class FrmProgressBar
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(15, 30);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(309, 23);
            this.progressBar.TabIndex = 0;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(15, 78);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(75, 23);
            this.btnBaixar.TabIndex = 1;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precesso do Download";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(249, 78);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(12, 117);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(311, 69);
            this.tbLog.TabIndex = 4;
            // 
            // FrmProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 198);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.progressBar);
            this.Name = "FrmProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProgressBar";
            this.Load += new System.EventHandler(this.FrmProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox tbLog;
    }
}