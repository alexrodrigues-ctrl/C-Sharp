namespace Aplicativo
{
    partial class FrmCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbPrimeiroNumero = new System.Windows.Forms.TextBox();
            this.tbSegundoNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbNome = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbEndereco = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mtbNumero = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tela de tramento de erro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Try - Catch - Thorow - Finaly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Somar dois números : Digitar texto eo invés de número para causar erro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "1º Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "2º Número";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(93, 114);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(270, 20);
            this.tbNome.TabIndex = 6;
            // 
            // tbPrimeiroNumero
            // 
            this.tbPrimeiroNumero.Location = new System.Drawing.Point(93, 156);
            this.tbPrimeiroNumero.Name = "tbPrimeiroNumero";
            this.tbPrimeiroNumero.Size = new System.Drawing.Size(100, 20);
            this.tbPrimeiroNumero.TabIndex = 7;
            // 
            // tbSegundoNumero
            // 
            this.tbSegundoNumero.Location = new System.Drawing.Point(93, 192);
            this.tbSegundoNumero.Name = "tbSegundoNumero";
            this.tbSegundoNumero.Size = new System.Drawing.Size(100, 20);
            this.tbSegundoNumero.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(199, 190);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Masked TextBox";
            // 
            // mtbNome
            // 
            this.mtbNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mtbNome.Location = new System.Drawing.Point(93, 290);
            this.mtbNome.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtbNome.Name = "mtbNome";
            this.mtbNome.Size = new System.Drawing.Size(270, 20);
            this.mtbNome.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "TextBox com entrada específica";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nome:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "End.:";
            // 
            // mtbEndereco
            // 
            this.mtbEndereco.Location = new System.Drawing.Point(93, 321);
            this.mtbEndereco.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtbEndereco.Name = "mtbEndereco";
            this.mtbEndereco.Size = new System.Drawing.Size(210, 20);
            this.mtbEndereco.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tel.:";
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(93, 349);
            this.mtbTelefone.Mask = "(00) 0000-0000";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(271, 20);
            this.mtbTelefone.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "N.";
            // 
            // mtbNumero
            // 
            this.mtbNumero.Location = new System.Drawing.Point(327, 321);
            this.mtbNumero.Mask = "0000";
            this.mtbNumero.Name = "mtbNumero";
            this.mtbNumero.Size = new System.Drawing.Size(37, 20);
            this.mtbNumero.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cel.:";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(93, 374);
            this.mtbCelular.Mask = "(00) 00000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(271, 20);
            this.mtbCelular.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 406);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "CPF:";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(93, 402);
            this.mtbCPF.Mask = "000.000000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(271, 20);
            this.mtbCPF.TabIndex = 25;
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 442);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mtbNumero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mtbEndereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.tbSegundoNumero);
            this.Controls.Add(this.tbPrimeiroNumero);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCadastro";
            this.Text = "FrmCadastro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbPrimeiroNumero;
        private System.Windows.Forms.TextBox tbSegundoNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtbNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbEndereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtbNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
    }
}