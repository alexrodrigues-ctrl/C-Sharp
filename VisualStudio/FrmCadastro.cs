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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int res;
                //r = int.Parse(tbPrimeiroNumero.Text + tbSegundoNumero);
                int r = int.Parse(tbPrimeiroNumero.Text);
                int s = int.Parse(tbSegundoNumero.Text);
                if (r == s)
                {
                    throw new Exception("***Não é permitido somar dois números iguais:**** ");
                    tbPrimeiroNumero.Clear();
                    tbPrimeiroNumero.Focus();
                }
                res = r + s;
                MessageBox.Show("Olá " + tbNome.Text + " você somou " + r + " + " + s + " = " + res);

            }
            catch (Exception err)
            {
                MessageBox.Show(" HOUVE ERRO DE DIGITAÇÃO: " + err);
                tbPrimeiroNumero.Clear();
                tbSegundoNumero.Clear();
                tbPrimeiroNumero.Focus();
            }
            finally
            {
                //emplementaçao p/ encerrar uma seção, se tiver aberto....
                /*
                 if(file==null)
                 {
                    file.close();
                 }  
                 */
                MessageBox.Show("Operação finalizada!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
