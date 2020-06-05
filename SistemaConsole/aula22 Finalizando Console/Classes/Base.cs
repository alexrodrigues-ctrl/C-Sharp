using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using Classes;

//IMPORTANTE: AQUI É FEITO TODAS IMPLEMENTAÇÃO DAS CLASSE, OU SEJA TODA LÓGICA É FEITA AQUI

//essa classe vai ser a generica, ela vai servir os atributos p/ as outras classes

    
namespace Classes
{
    public class Base : IPessoa
    {
        public Base(string _nome, string _telefone, string _cpf, string _cnpj)
        {
            this.Nome = _nome;
            this.Telefone = _telefone;
            this.Cpf = _cpf;
            this.Cpf = _cnpj;
        }
        public Base(){}

        public string Nome;
        public string Telefone;
        public string Cpf;
        public string Cnpj;

        private string Sobre = "Rodrigues";

        //setando os nomes da interface
        public void SetNome(string _nome){ this.Nome = _nome; }
        public void SetTelefone(string _telefone) { this.Telefone = _telefone; }
        public void SetCpf(string _cpf) { this.Cpf = _cpf; }
        public void SetCnpj(string _cnpj) { this.Cnpj = _cnpj; }


        //Obrigatorio esse metodo Gravar(), pq fornece herança a interface Pessoa.cs que servi as Classes Cliente e Usuário ou quem precisar
        public virtual void Gravar() 
        {
                var dados = this.Ler(); //como vou estar na minha instancia CORRENTE dou THIS
                dados.Add(this);
                
                    // StreamWriter cria o arquivo se nao exisatir
                    StreamWriter r = new StreamWriter(DiretorioArquivo());
                    r.WriteLine("nome;telefone;cpf;");
                    foreach (Base b in dados)
                    {
                        var linha = b.Nome + ";" + b.Telefone + ";" + b.Cpf + ";";
                        r.WriteLine(linha);

                    }
                    r.Close();
                
        }// fim gravar

        public List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();
            if (File.Exists(DiretorioArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(DiretorioArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var basearquivo = linha.Split(';');
                        //criar um objeto da minha instancia corrente
                        var b = (IPessoa)Activator.CreateInstance(this.GetType()); //cabe um cast, converter Activator em IPessoa, -interface
                        //agora vou setar minha variaveis, na interface IPessoa
                        b.SetNome(basearquivo[0]);
                        b.SetTelefone(basearquivo[1]);
                        b.SetCpf(basearquivo[2]);
                        //var b = new Base(basearquivo[0], basearquivo[1], basearquivo[2]);
                        dados.Add(b);
                    }
                }
            }
            return dados;
        }


        //IMPORTANTE!!!
        /* //antigo
         private static string diretorioArquivo()
        {
            return System.Configuration.ConfigurationManager.AppSettings["BaseDeClientes"];
        } 
        */
        //novo
        /*deixa de ser static p/ serve dinamico (metodo de instancia),
        pq agora vai pegar o tipo que estou atual, ou seja, a instancia q estar herdada
        no momento neste caso Cliente. Assim o arquivo vai ser gravado como cliente.txt
        */
        
        private string DiretorioArquivo()
        {
            return System.Configuration.ConfigurationManager.AppSettings["BaseDeClientes"]+this.GetType().Name+".txt";
        }

        //
        public virtual void Olhar() 
        {
            Console.WriteLine("O cliente "+this.Nome +" "+ this.Sobre + "está olhando");
        }
        private static string caminhobase()
        {
        return ConfigurationManager.AppSettings["BaseDeClientes"];
        }

        

        //lixo tb
        //metodos PROTECTED
        protected int calcularUmeDois()
        {
            return 1 + 2;
        }
        //metodo PRIVATE
        private int calcularUmeDoiseTres()
        {
            return 1 + 2 + 3;
        }
        //metodo PUBLIC
        public int calcularUmeDoiseTreseQuatro()
        {
            return 1 + 2 + 3 + 4;
        }
        //metodo INTERNAL
        internal int calcularQuatroeCinco()
        {
            return 4 + 5;
        }


    }//fim base
}
