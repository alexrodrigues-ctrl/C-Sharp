namespace Aplicativo
{
    partial class FrmTreeView
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Produto");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sobre");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Pagina Inicial", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Administrador");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Home");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Painel de Controle", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Home");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Produtos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Pagina inicial", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Admin");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Web Home");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Painel de Controle", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTreeView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tvSelecionar = new System.Windows.Forms.TreeView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecionado = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.treeViewLocal = new System.Windows.Forms.TreeView();
            this.treeViewExplorer = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1286, 566);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.treeViewExplorer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSelecionado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tvSelecionar);
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.ForeColor = System.Drawing.Color.DarkRed;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1278, 540);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Node Web";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeViewLocal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1278, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Node Local";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(24, 35);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "nodeProduto";
            treeNode7.Text = "Produto";
            treeNode8.Name = "nodeSobre";
            treeNode8.Text = "Sobre";
            treeNode9.Name = "nodePaginaInicial";
            treeNode9.Text = "Pagina Inicial";
            treeNode10.Name = "nodeAdministrador";
            treeNode10.Text = "Administrador";
            treeNode11.Name = "nodeHome";
            treeNode11.Text = "Home";
            treeNode12.Name = "nodePainelControle";
            treeNode12.Text = "Painel de Controle";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(316, 481);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tvSelecionar
            // 
            this.tvSelecionar.CheckBoxes = true;
            this.tvSelecionar.Location = new System.Drawing.Point(413, 35);
            this.tvSelecionar.Name = "tvSelecionar";
            treeNode1.Name = "Nó1";
            treeNode1.Text = "Home";
            treeNode2.Name = "Nó2";
            treeNode2.Text = "Produtos";
            treeNode3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode3.ImageKey = "(padrão)";
            treeNode3.Name = "nodeSeleciona";
            treeNode3.Text = "Pagina inicial";
            treeNode4.Name = "Nó4";
            treeNode4.Text = "Admin";
            treeNode5.Name = "Nó5";
            treeNode5.Text = "Web Home";
            treeNode6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode6.Name = "Nó3";
            treeNode6.Text = "Painel de Controle";
            this.tvSelecionar.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.tvSelecionar.Size = new System.Drawing.Size(345, 481);
            this.tvSelecionar.TabIndex = 1;
            this.tvSelecionar.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Com CheckeBoxes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sem CheckeBoxes";
            // 
            // btnSelecionado
            // 
            this.btnSelecionado.Location = new System.Drawing.Point(629, 46);
            this.btnSelecionado.Name = "btnSelecionado";
            this.btnSelecionado.Size = new System.Drawing.Size(119, 23);
            this.btnSelecionado.TabIndex = 1;
            this.btnSelecionado.Text = "Item Selecionado";
            this.btnSelecionado.UseVisualStyleBackColor = true;
            this.btnSelecionado.Click += new System.EventHandler(this.btnSelecionado_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(16, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // treeViewLocal
            // 
            this.treeViewLocal.Location = new System.Drawing.Point(6, 6);
            this.treeViewLocal.Name = "treeViewLocal";
            this.treeViewLocal.Size = new System.Drawing.Size(1266, 528);
            this.treeViewLocal.TabIndex = 0;
            this.treeViewLocal.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLocal_AfterSelect);
            // 
            // treeViewExplorer
            // 
            this.treeViewExplorer.Location = new System.Drawing.Point(845, 35);
            this.treeViewExplorer.Name = "treeViewExplorer";
            this.treeViewExplorer.Size = new System.Drawing.Size(314, 481);
            this.treeViewExplorer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(842, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Com CheckeBoxes";
            // 
            // FrmTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 712);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTreeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTreeView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTreeView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvSelecionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelecionado;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TreeView treeViewLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeViewExplorer;
    }
}