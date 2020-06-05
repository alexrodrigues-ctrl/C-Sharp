namespace Aplicativo
{
    partial class FrmTabControl
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
            this.tbCliente = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbRerenciaBancaria = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mstbAgencia = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.mstbBanco = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbCliente.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tbRerenciaBancaria.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCliente
            // 
            this.tbCliente.Controls.Add(this.tabPage1);
            this.tbCliente.Controls.Add(this.tbRerenciaBancaria);
            this.tbCliente.Location = new System.Drawing.Point(0, 1);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.SelectedIndex = 0;
            this.tbCliente.Size = new System.Drawing.Size(748, 267);
            this.tbCliente.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.maskedTextBox4);
            this.tabPage1.Controls.Add(this.maskedTextBox5);
            this.tabPage1.Controls.Add(this.maskedTextBox6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(740, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbRerenciaBancaria
            // 
            this.tbRerenciaBancaria.Controls.Add(this.btnEnviar);
            this.tbRerenciaBancaria.Controls.Add(this.comboBox1);
            this.tbRerenciaBancaria.Controls.Add(this.mstbAgencia);
            this.tbRerenciaBancaria.Controls.Add(this.maskedTextBox2);
            this.tbRerenciaBancaria.Controls.Add(this.mstbBanco);
            this.tbRerenciaBancaria.Controls.Add(this.label4);
            this.tbRerenciaBancaria.Controls.Add(this.label3);
            this.tbRerenciaBancaria.Controls.Add(this.label2);
            this.tbRerenciaBancaria.Controls.Add(this.label1);
            this.tbRerenciaBancaria.Location = new System.Drawing.Point(4, 22);
            this.tbRerenciaBancaria.Name = "tbRerenciaBancaria";
            this.tbRerenciaBancaria.Padding = new System.Windows.Forms.Padding(3);
            this.tbRerenciaBancaria.Size = new System.Drawing.Size(740, 241);
            this.tbRerenciaBancaria.TabIndex = 1;
            this.tbRerenciaBancaria.Text = "Referencia Bancária";
            this.tbRerenciaBancaria.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Poupança",
            "Corrente",
            "Salário",
            "Outros"});
            this.comboBox1.Location = new System.Drawing.Point(80, 151);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // mstbAgencia
            // 
            this.mstbAgencia.Location = new System.Drawing.Point(80, 58);
            this.mstbAgencia.Mask = "0000/000";
            this.mstbAgencia.Name = "mstbAgencia";
            this.mstbAgencia.Size = new System.Drawing.Size(159, 20);
            this.mstbAgencia.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(80, 102);
            this.maskedTextBox2.Mask = "000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(159, 20);
            this.maskedTextBox2.TabIndex = 13;
            // 
            // mstbBanco
            // 
            this.mstbBanco.Location = new System.Drawing.Point(80, 24);
            this.mstbBanco.Mask = ">LLLLLLLLLLLLLLLLLLLL";
            this.mstbBanco.Name = "mstbBanco";
            this.mstbBanco.Size = new System.Drawing.Size(159, 20);
            this.mstbBanco.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Agencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Banco";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Casado",
            "Solterio",
            "Viuvo",
            "Comunhão de bem"});
            this.comboBox2.Location = new System.Drawing.Point(106, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.Location = new System.Drawing.Point(106, 126);
            this.maskedTextBox4.Mask = "000.000.000-00";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(159, 20);
            this.maskedTextBox4.TabIndex = 22;
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.Location = new System.Drawing.Point(106, 79);
            this.maskedTextBox5.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(427, 20);
            this.maskedTextBox5.TabIndex = 21;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.Location = new System.Drawing.Point(106, 36);
            this.maskedTextBox6.Mask = ">LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(349, 20);
            this.maskedTextBox6.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Estado Civíl:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "CPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Endereço:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nome Completo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(18, 212);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 24;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(25, 212);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 16;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 278);
            this.Controls.Add(this.tbCliente);
            this.Name = "FrmTabControl";
            this.Text = "FrmTabControl";
            this.tbCliente.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tbRerenciaBancaria.ResumeLayout(false);
            this.tbRerenciaBancaria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCliente;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tbRerenciaBancaria;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox mstbAgencia;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox mstbBanco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEnviar;
    }
}