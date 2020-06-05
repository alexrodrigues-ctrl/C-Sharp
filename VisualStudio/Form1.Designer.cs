namespace Aplicativo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbEstadoNome = new System.Windows.Forms.TextBox();
            this.tbEstadoID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListaEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnNovaJanela = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNotificação = new System.Windows.Forms.Button();
            this.tbNotificacao = new System.Windows.Forms.TextBox();
            this.Icone = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEstadoNome
            // 
            this.tbEstadoNome.Location = new System.Drawing.Point(106, 98);
            this.tbEstadoNome.Name = "tbEstadoNome";
            this.tbEstadoNome.Size = new System.Drawing.Size(190, 20);
            this.tbEstadoNome.TabIndex = 0;
            // 
            // tbEstadoID
            // 
            this.tbEstadoID.Location = new System.Drawing.Point(106, 149);
            this.tbEstadoID.Name = "tbEstadoID";
            this.tbEstadoID.Size = new System.Drawing.Size(190, 20);
            this.tbEstadoID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estado por Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado por ID";
            // 
            // cbListaEstado
            // 
            this.cbListaEstado.FormattingEnabled = true;
            this.cbListaEstado.Location = new System.Drawing.Point(106, 210);
            this.cbListaEstado.Name = "cbListaEstado";
            this.cbListaEstado.Size = new System.Drawing.Size(190, 21);
            this.cbListaEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escolha a UF:";
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(562, 96);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(108, 23);
            this.btnExibir.TabIndex = 6;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnNovaJanela
            // 
            this.btnNovaJanela.Location = new System.Drawing.Point(562, 156);
            this.btnNovaJanela.Name = "btnNovaJanela";
            this.btnNovaJanela.Size = new System.Drawing.Size(108, 23);
            this.btnNovaJanela.TabIndex = 7;
            this.btnNovaJanela.Text = "Exibir Nova Janela";
            this.btnNovaJanela.UseVisualStyleBackColor = true;
            this.btnNovaJanela.Click += new System.EventHandler(this.btnNovaJanela_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(562, 208);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(302, 98);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.Size = new System.Drawing.Size(254, 133);
            this.dgvEstados.TabIndex = 9;
            this.dgvEstados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstados_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.textoToolStripMenuItem1,
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informaçõesToolStripMenuItem
            // 
            this.informaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem});
            this.informaçõesToolStripMenuItem.Name = "informaçõesToolStripMenuItem";
            this.informaçõesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.informaçõesToolStripMenuItem.Text = "Informações";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // licençaToolStripMenuItem
            // 
            this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            this.licençaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.licençaToolStripMenuItem.Text = "Licença";
            this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // textoToolStripMenuItem1
            // 
            this.textoToolStripMenuItem1.Name = "textoToolStripMenuItem1";
            this.textoToolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.textoToolStripMenuItem1.Text = "Texto";
            this.textoToolStripMenuItem1.Click += new System.EventHandler(this.textoToolStripMenuItem1_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // btnNotificação
            // 
            this.btnNotificação.Location = new System.Drawing.Point(12, 253);
            this.btnNotificação.Name = "btnNotificação";
            this.btnNotificação.Size = new System.Drawing.Size(86, 23);
            this.btnNotificação.TabIndex = 14;
            this.btnNotificação.Text = "Notificação";
            this.btnNotificação.UseVisualStyleBackColor = true;
            this.btnNotificação.Click += new System.EventHandler(this.btnNotificação_Click);
            // 
            // tbNotificacao
            // 
            this.tbNotificacao.Location = new System.Drawing.Point(106, 256);
            this.tbNotificacao.Name = "tbNotificacao";
            this.tbNotificacao.Size = new System.Drawing.Size(504, 20);
            this.tbNotificacao.TabIndex = 15;
            // 
            // Icone
            // 
            this.Icone.Icon = ((System.Drawing.Icon)(resources.GetObject("Icone.Icon")));
            this.Icone.Text = "Alex.Zatec";
            this.Icone.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 550);
            this.Controls.Add(this.tbNotificacao);
            this.Controls.Add(this.btnNotificação);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovaJanela);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbListaEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEstadoID);
            this.Controls.Add(this.tbEstadoNome);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEstadoNome;
        private System.Windows.Forms.TextBox tbEstadoID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListaEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnNovaJanela;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.Button btnNotificação;
        private System.Windows.Forms.TextBox tbNotificacao;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon Icone;
    }
}

