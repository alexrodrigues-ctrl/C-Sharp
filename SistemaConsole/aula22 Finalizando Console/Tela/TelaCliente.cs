using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class TelaCliente:Base
    {
        public static void Chamar()
        {

            Console.WriteLine("########################  Tela de Clientes  ####################################\n");

            while (true)
            {
                Console.WriteLine("##########################  O que deseja fazer?  ###############################");
                Console.WriteLine("[1]-Cadastrar  [2]-Listar  [3]-Sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    var cliente = new Cliente();

                    Console.WriteLine("Digite o Nome do Cliente: ");
                    cliente.Nome = Console.ReadLine();

                    Console.WriteLine("Digite o Telefone do Cliente: ");
                    cliente.Telefone = Console.ReadLine();

                    Console.WriteLine("Digite o CPF do Cliente: ");
                    cliente.Cpf = Console.ReadLine();

                    cliente.Gravar();

                }
                else if (op == 2)
                {
                    var clientes =new  Cliente().Ler();
                    foreach (Cliente c in clientes)
                    {
                        Console.WriteLine(c.Nome);
                        Console.WriteLine(c.Telefone);
                        Console.WriteLine(c.Cpf);
                        Console.WriteLine("------------------------------------");

                    }

                }
                else if (op==3)
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
