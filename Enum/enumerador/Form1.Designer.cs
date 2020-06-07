namespace enumerador
{
    partial class TelaJogador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_status = new System.Windows.Forms.Label();
            this.btn_cima = new System.Windows.Forms.Button();
            this.btn_baixo = new System.Windows.Forms.Button();
            this.btn_esquerda = new System.Windows.Forms.Button();
            this.btn_direita = new System.Windows.Forms.Button();
            this.lb_movimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(45, 170);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(99, 13);
            this.lb_status.TabIndex = 0;
            this.lb_status.Text = "Status do Jogador: ";
            // 
            // btn_cima
            // 
            this.btn_cima.Location = new System.Drawing.Point(123, 46);
            this.btn_cima.Name = "btn_cima";
            this.btn_cima.Size = new System.Drawing.Size(112, 23);
            this.btn_cima.TabIndex = 1;
            this.btn_cima.Text = "Para cima";
            this.btn_cima.UseVisualStyleBackColor = true;
            this.btn_cima.Click += new System.EventHandler(this.btn_cima_Click);
            // 
            // btn_baixo
            // 
            this.btn_baixo.Location = new System.Drawing.Point(123, 101);
            this.btn_baixo.Name = "btn_baixo";
            this.btn_baixo.Size = new System.Drawing.Size(112, 23);
            this.btn_baixo.TabIndex = 2;
            this.btn_baixo.Text = "Para baixo";
            this.btn_baixo.UseVisualStyleBackColor = true;
            this.btn_baixo.Click += new System.EventHandler(this.btn_baixo_Click);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.Location = new System.Drawing.Point(14, 72);
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(112, 23);
            this.btn_esquerda.TabIndex = 3;
            this.btn_esquerda.Text = "Para Esquerda";
            this.btn_esquerda.UseVisualStyleBackColor = true;
            this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
            // 
            // btn_direita
            // 
            this.btn_direita.Location = new System.Drawing.Point(232, 72);
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(112, 23);
            this.btn_direita.TabIndex = 4;
            this.btn_direita.Text = "Para Direita";
            this.btn_direita.UseVisualStyleBackColor = true;
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // lb_movimento
            // 
            this.lb_movimento.AutoSize = true;
            this.lb_movimento.Location = new System.Drawing.Point(150, 170);
            this.lb_movimento.Name = "lb_movimento";
            this.lb_movimento.Size = new System.Drawing.Size(16, 13);
            this.lb_movimento.TabIndex = 5;
            this.lb_movimento.Text = "...";
            // 
            // TelaJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 209);
            this.Controls.Add(this.lb_movimento);
            this.Controls.Add(this.btn_direita);
            this.Controls.Add(this.btn_esquerda);
            this.Controls.Add(this.btn_baixo);
            this.Controls.Add(this.btn_cima);
            this.Controls.Add(this.lb_status);
            this.Name = "TelaJogador";
            this.Text = "Jogador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Button btn_cima;
        private System.Windows.Forms.Button btn_baixo;
        private System.Windows.Forms.Button btn_esquerda;
        private System.Windows.Forms.Button btn_direita;
        private System.Windows.Forms.Label lb_movimento;
    }
}

