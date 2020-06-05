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
    public partial class FrmWebForm : Form
    {
        public FrmWebForm()
        {
            InitializeComponent();
        }

        private void fecharWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Close();
        }      

        private void FrmWebForm_Load(object sender, EventArgs e)
        {
            //comportamento da web no form
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri("http://www.blogvladsalomao.com.br");
        }
    }
}
