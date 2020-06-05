using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Configuration.Internal;

namespace Classes //aula 18 - Abstraçao
{
    public class Usuario : Base
    {
        public Usuario(string _nome, string _telefone, string _cpf)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
        }
        public Usuario() { }

        public static string Teste;

    }
}
