using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumerador
{
    class Jogador
    {
        //enum
        public enum Movimento{ParaCima, ParaBaixo, ParaEsquerda, ParaDireita}
        //metodo
        public void Mover(Movimento Jogada)
        {
            Console.WriteLine("Jogada "+ Jogada);
            
        }
    }
}
