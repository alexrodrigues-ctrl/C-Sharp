using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public interface IPessoa
    {
      

        void SetNome(string _nome);
        void SetTelefone(string _telefone);
        void SetCpf(string _cpf);
        void SetCnpj(string _cnpj);

        void Gravar();
        
    }
}
