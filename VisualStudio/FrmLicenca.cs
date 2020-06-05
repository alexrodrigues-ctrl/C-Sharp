using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aplicativo
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //aqui onde implementaria para registrar
            MessageBox.Show("Registrado com Sucesso!");
        }

        private void btnObter_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.meusite.com.br");
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
