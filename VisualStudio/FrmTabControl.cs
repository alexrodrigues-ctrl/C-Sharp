using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbCliente.SelectTab("tbRerenciaBancaria");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enviado com Sucesaso !!! ");
            mstbBanco.Clear();
            mstbAgencia.Clear();
        }
    }
}
