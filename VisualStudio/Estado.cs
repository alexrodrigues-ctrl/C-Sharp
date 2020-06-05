using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo
{
    public class Estado
    {
        //public int x; //atributo
        public int id { get; set; } //propriedade
        public string nome{get; set;}
        public string telefone { get; set; }
        public string cpf { get; set; }


        public override string ToString()
        {
            return this.nome;
        }

        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();

            var e1 = new Estado(); ;
            e1.id = 0;
            e1.nome = "BA";
            lista.Add(e1);
            //
            e1 = new Estado(); ;
            e1.id = 1;
            e1.nome = "MG";
            lista.Add(e1);
            //
            e1 = new Estado(); ;
            e1.id = 2;
            e1.nome = "RJ";
            lista.Add(e1);
            //



            return lista;
        }

    }
}
