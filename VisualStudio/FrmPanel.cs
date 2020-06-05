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
    public partial class FrmPanel : Form
    {
        public FrmPanel()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;

        }

        private void FrmPanel_Load(object sender, EventArgs e)
        {
            dgvEstados.DataSource = Estado.Lista();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\db\Cadastro_em Panel " + DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") + ".txt",mstbNome.Text +"\n"+ mstbCPF.Text);
            MessageBox.Show(@"Salvo com Sucesso! \n caminho: C:\db\");
            mstbNome.Text = string.Empty;
            mstbCPF.Text = string.Empty;

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = false;
            pnlListaEstado.Visible = false;
           
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            pnlCadastro.Visible = true;
            pnlListaEstado.Visible = true;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            pnlListaEstado.Visible = true;

        }
    }
}
