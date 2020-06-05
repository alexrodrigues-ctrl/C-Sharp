using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicativo
{
    public partial class FrmDoacao : Form
    {
        public FrmDoacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.paypal/com/aleex.zatec");
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDoacao_Load(object sender, EventArgs e)
        {

        }
    }
}
