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
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void SalvaTexto()
        {
            File.WriteAllText(@"C:\db\aula28 "+ DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") +".txt", tbTexto.Text);
            MessageBox.Show("Salvo com Sucesso!");
            tbTexto.Text = string.Empty;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalvaTexto();
        }

        private void tbTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\db\aula28 " + DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss") + ".txt", tbTexto.Text);
            MessageBox.Show("Salvo com Sucesso!");
            tbTexto.Text = string.Empty;
        }
    }
}
