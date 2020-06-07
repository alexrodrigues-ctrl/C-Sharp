using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enumerador
{
    public partial class TelaJogador : Form
    {
        Jogador j1; //objeto da class jogador disponivel p/ todos os metodos 

        public TelaJogador()
        {
            InitializeComponent();
            j1 = new Jogador();//criar jogador

        }

        private void btn_cima_Click(object sender, EventArgs e)
        {
            
            j1.Mover(Jogador.Movimento.ParaCima);                                 
           
        }

        private void btn_baixo_Click(object sender, EventArgs e)
        {
            j1.Mover(Jogador.Movimento.ParaBaixo);
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            j1.Mover(Jogador.Movimento.ParaDireita);
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            j1.Mover(Jogador.Movimento.ParaEsquerda);
        }
    }
}
