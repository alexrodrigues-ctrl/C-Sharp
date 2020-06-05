using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class TelaFornecedor:Base
    {

        public static void Chamar()
        {
            Console.WriteLine("########################  Tela de Fornecedor  ####################################\n");

            while (true)
            {
                Console.WriteLine("##########################  O que deseja fazer?  ###############################");
                Console.WriteLine("[1]-Cadastrar   [2]-Listar  [3]-Sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    var fornecedor = new Fornecedor();
                    //Fornecedor u = new Fornecedor();
                    Console.WriteLine("Digite nome do Fornecedor: ");
                    fornecedor.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do Fornecedor: ");
                    fornecedor.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do Gerente: ");
                    fornecedor.Cpf = Console.ReadLine();
                    fornecedor.Gravar();
                }
                else if (op == 2)
                {
                    var fornecedores = new Fornecedor().Ler();
                    
                    foreach(Fornecedor us in fornecedores)
                    {
                        Console.WriteLine(us.Nome);
                        Console.WriteLine(us.Cnpj);
                        Console.WriteLine(us.Telefone);
                        Console.WriteLine(us.Cpf);
                        Console.WriteLine("-------------------------------------------");

                    }
                }
                else if (op == 3)
                { 
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente. "); 
                }

            }    
      
        }

        
    }
}
