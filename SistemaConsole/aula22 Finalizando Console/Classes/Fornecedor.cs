using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Configuration.Internal;

namespace Classes //aula 18 - Abstraçao
{
    public class Fornecedor : Base
    {
        public string Cnpj;
        public Fornecedor(string _nome, string _telefone, string _cpf, string _cnpj)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
            this.Cnpj = _cnpj; //
        }
        public Fornecedor() { }

        public static string Teste;

    }
}
