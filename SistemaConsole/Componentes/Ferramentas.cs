using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;


namespace Componentes //criando assembly (.dll)
{
    public class Ferramentas
    {
        //metodo somente para uso interno, ou seja, neste assembly
        internal string MetodoSomenteParaMeuAssembly()
        {
            return "Este metodo so pode ser acessado dentro deste assembly componentes, uso interno";
        }

        //metodo para uso de todos, ou seja, todas as classes
        public string MetodoParaTodasClasses()
        {
            return "Metodo para todos que utilizar o aseembly";
        }
        public bool ValidarCpf(string cpf)
        {
            return true;
        }

    }
}
