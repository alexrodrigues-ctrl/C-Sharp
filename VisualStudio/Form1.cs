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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        //notifyIcon
        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirSobre(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.ShowDialog();

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            tbEstadoNome.Text="Nome Estado Escolhido: "+cbListaEstado.Text;
            tbEstadoID.Text = "ID Estado Escolhido: "+((Estado)cbListaEstado.SelectedItem).id;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovaJanela_Click(object sender, EventArgs e)
        {
            FrmShow frmShow = new FrmShow();
            frmShow.lbTextoNome.Text = tbEstadoNome.Text;
            frmShow.lbTextoID.Text = tbEstadoID.Text;
            frmShow.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Fechar", Fechar_Click));
            contextMenu.MenuItems.Add(new MenuItem("Sobre", AbrirSobre));

            Icone.ContextMenu = contextMenu;

            //****************ComboBox
            /*
            //mostrando no ComboBox com foreach
            cbListaEstado.Items.Clear();
            foreach (Estado estado in Estado.Lista())
            {
                cbListaEstado.Items.Add(estado);
            }
            */
            //mostrando no ComboBox com DataSource
            cbListaEstado.DataSource = Estado.Lista();
            cbListaEstado.Text = "[Selecione]";

            //**************DataGridView

            //mostra todas as campos (propriedades -ID, Nome, Telefopne, CPF, etc...
            /*
            dgvEstados.DataSource = Estado.Lista(); //DataGridView trabalha c/ propriedade tipo get, set e nao atributos variaveis
            */

            /*
            //mostrando apenas campo desejado ex.: ID Nome
            dgvEstados.ColumnCount = 2;
            dgvEstados.Columns[0].Name = "ID";
            dgvEstados.Columns[1].Name = "Nome";

            var rows = new List<string[]>();//criando lista de array de string
            foreach (Estado estado in Estado.Lista())
            {
                string[] arows1 = new string[] { estado.id.ToString(), estado.nome };
                rows.Add(arows1);
            }
            foreach (string[] rowArray in rows)
            {
                dgvEstados.Rows.Add(rowArray);           
            }
            */

            //mostrando por LINK
            var data = from estado in Estado.Lista()
                      // where estado.id ==0 || estado.id==1 //apenas id 0 e 1
                       //orderby estado.nome //por nome
                       select new
                       {
                           id = estado.id,
                           nome = estado.nome
                       };

            dgvEstados.DataSource = data.ToList();
                     
                
        }

        private void textoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTexto frmTexto = new FrmTexto();
            frmTexto.MdiParent = MdiSingeton.InstanciaMDI();
            frmTexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre frmSobre = new FrmSobre();
            frmSobre.MdiParent = MdiSingeton.InstanciaMDI();
            frmSobre.Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLicenca frmLicenca = new FrmLicenca();
            frmLicenca.MdiParent = MdiSingeton.InstanciaMDI();
            frmLicenca.Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoacao frmDoacao = new FrmDoacao();
            frmDoacao.MdiParent = MdiSingeton.InstanciaMDI();
            frmDoacao.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //lbRelogio.Text = DateTime.Now.ToString("dd/MM/yyy | HH:mm:ss");
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastro frmCadastro = new FrmCadastro();
            frmCadastro.MdiParent = MdiSingeton.InstanciaMDI();
            frmCadastro.Show();
            //new FrmCadastro().ShowDialog();
        }

        private void btnNotificação_Click(object sender, EventArgs e)
        {
            Icone.ShowBalloonTip(10, "Notificação",tbNotificacao.Text, ToolTipIcon.Info);
        }

        private void textoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTexto frmTexto = new FrmTexto();
            frmTexto.MdiParent = MdiSingeton.InstanciaMDI();
            frmTexto.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvEstados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
