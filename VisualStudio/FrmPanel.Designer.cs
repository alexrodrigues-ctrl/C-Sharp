namespace Aplicativo
{
    partial class FrmPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPanel));
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.pnlListaEstado = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mstbNome = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mstbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.pnlCadastro.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnlListaEstado.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.btnSalvar);
            this.pnlCadastro.Controls.Add(this.mstbCPF);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.mstbNome);
            this.pnlCadastro.Controls.Add(this.label2);
            this.pnlCadastro.Location = new System.Drawing.Point(3, 75);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(312, 138);
            this.pnlCadastro.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripButton3,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripLabel4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(707, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(60, 22);
            this.toolStripLabel1.Text = "Cadasatro";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(90, 22);
            this.toolStripLabel2.Text = "Lista de Estados";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // pnlListaEstado
            // 
            this.pnlListaEstado.Controls.Add(this.dgvEstados);
            this.pnlListaEstado.Location = new System.Drawing.Point(344, 75);
            this.pnlListaEstado.Name = "pnlListaEstado";
            this.pnlListaEstado.Size = new System.Drawing.Size(349, 138);
            this.pnlListaEstado.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 252);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(707, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Novo Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // mstbNome
            // 
            this.mstbNome.Location = new System.Drawing.Point(54, 11);
            this.mstbNome.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mstbNome.Name = "mstbNome";
            this.mstbNome.Size = new System.Drawing.Size(242, 20);
            this.mstbNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // mstbCPF
            // 
            this.mstbCPF.Location = new System.Drawing.Point(54, 63);
            this.mstbCPF.Mask = "000.000000-00";
            this.mstbCPF.Name = "mstbCPF";
            this.mstbCPF.Size = new System.Drawing.Size(242, 20);
            this.mstbCPF.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lista de Estados";
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(10, 3);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.Size = new System.Drawing.Size(320, 123);
            this.dgvEstados.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(54, 89);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel3.Text = "Ocultar Dados";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(84, 22);
            this.toolStripLabel4.Text = "Mostrar Dados";
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // FrmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 274);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlListaEstado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pnlCadastro);
            this.Name = "FrmPanel";
            this.Text = "FrmPanel2";
            this.Load += new System.EventHandler(this.FrmPanel_Load);
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlListaEstado.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.MaskedTextBox mstbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mstbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlListaEstado;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
    }
}