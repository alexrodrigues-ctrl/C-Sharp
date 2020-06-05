using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class FrmTreeView : Form
    {
        public FrmTreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Você clicou em : " + e.Node.Text);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("Você clicou em : " + e.Node.Text);

        }

        private void btnSelecionado_Click(object sender, EventArgs e)
        {
            if (LerSelecionados(tvSelecionar.Nodes[0]).Length>1 || LerSelecionados(tvSelecionar.Nodes[1]).Length > 1)
            {
                MessageBox.Show("Você marcou : "+LerSelecionados(tvSelecionar.Nodes[0])+" " + LerSelecionados(tvSelecionar.Nodes[1]));
            }
            
        }
        private string LerSelecionados(TreeNode node, string checkeds="")
        {
            foreach (TreeNode n in node.Nodes)
            {
                if (n.Checked)//se tá true
                {
                    checkeds += n.Text + " , ";
                }
                checkeds = LerSelecionados(n, checkeds);
            }
            return checkeds;
        }

        private void FrmTreeView_Load(object sender, EventArgs e)
        {
            //treeView1.Nodes.Clear();
            treeViewLocal.Nodes.Clear();
            treeViewLocal.Nodes.Add("C#");
            var node = treeViewLocal.Nodes[0];
            loadDiretorios(@"E:\C#",ref node);

            //treeViewExplorer
            treeViewExplorer.Nodes.Clear();
            treeViewExplorer.Nodes.Add("Explorer");
            var nodeexplorer = treeViewExplorer.Nodes[0];
            loadDiretorios(@"C:\Explorer", ref nodeexplorer);
        }
        private void loadDiretorios(string diretorio, ref TreeNode node)
        {
            string[] arquivos = Directory.GetFiles(diretorio);
            foreach (string arquivo in arquivos)
            {
                node.Nodes.Add(Path.GetFileName(arquivo));
            }
            //Recurse into subdirectories of this diretory
            string[] subdiretorios = Directory.GetDirectories(diretorio);
            foreach (string subdiretorio in subdiretorios)
            {
                TreeNode n = new TreeNode(Path.GetFileName(subdiretorio));
                loadDiretorios(subdiretorio, ref n);
                node.Nodes.Add(n);
            }
        }

        private void treeViewLocal_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
