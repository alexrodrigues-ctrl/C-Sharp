using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Configuration.Internal;

namespace Classes //aula 18 - Abstração
{
    public class Cliente : Base //herdando 
    {
        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
        }
        public Cliente() {  }

        public static string Teste;
        
    }
}
