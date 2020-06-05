using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aplicativo
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            
                //Data e hora
                tsslRelogio.Text = DateTime.Now.ToString(" dd/MM/yyy | HH:mm:ss");

        }

        private void telaZatecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
            

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void relogio_Tick(object sender, EventArgs e)
        {
           
            tsslRelogio.Text= DateTime.Now.ToString("dd/MM/yyy | HH:mm:ss");
        }

        private void mtsBaixarArquivo_Click(object sender, EventArgs e)
        {
            FrmProgressBar frmProgressBar = new FrmProgressBar();
            frmProgressBar.MdiParent = this;
            frmProgressBar.Show();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FrmProgressBar frmProgressBar = new FrmProgressBar();
            frmProgressBar.MdiParent = this;
            frmProgressBar.Show();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTabControl frmTabControl= new FrmTabControl();
            frmTabControl.MdiParent = this;
            frmTabControl.Show();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPanel frmpanel = new FrmPanel();
            frmpanel.MdiParent = this;
            frmpanel.Show();
            
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTreeView().ShowDialog();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmWebForm frmWebForm = new FrmWebForm();
            frmWebForm.MdiParent = this;
            frmWebForm.Show();
        }
    }
}
