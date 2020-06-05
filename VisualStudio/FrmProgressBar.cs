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
    public partial class FrmProgressBar : Form
    {
        //progressBar
        private string[] lines;

        public FrmProgressBar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProgressBar_Load(object sender, EventArgs e)
        {
            
            //Barra de precesso de carregamento --> Porgress Bar
            string fileName = @"C:\db\DadosDownload.txt";
            using (var streamReader = File.OpenText(fileName))
            {
                lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                progressBar.Maximum = lines.Length;
                progressBar.Minimum = 0;               
            }
                                 
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lines.Length; i++)
            {
                
                var line = lines[i];
                progressBar.Value = (i + 1);
                tbLog.Text += line + " - "+ i +" - Baixando...\n\n";
                //tbLog.Update();
                
                /*
                caso já tivesse um usuario, uma dsl para importar ou tranferir faria:
                var user=new Usuario();
                user.nome=line;
                user.save();
                para migrar para um objeto pronto p/ mandar por banco de dados ou API

                */
            }
            //tbLog.Text = String.Join("\n", lines); //mostra as linhas do q ta baixando.
            tbLog.Text = "Arquivo baixado com sucesso!!!";
        }
    }
}
