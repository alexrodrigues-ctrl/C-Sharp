using Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tela
{
    class TelaUsuario:Base
    {

        public static void Chamar()
        {
            Console.WriteLine("########################  Tela de Usuário  ####################################\n");

            while (true)
            {
                Console.WriteLine("##########################  O que deseja fazer?  ###############################");
                Console.WriteLine("[1]-Cadastrar   [2]-Listar  [3]-Sair");
                int op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    var usuario = new Usuario();
                    //Usuario u = new Usuario();
                    Console.WriteLine("Digite a função do Usuário: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Digite o Telefone do usuário: ");
                    usuario.Telefone = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do usuário: ");
                    usuario.Cpf = Console.ReadLine();
                    usuario.Gravar();
                }
                else if (op == 2)
                {
                    var usuarios = new Usuario().Ler();
                    
                    foreach(Usuario us in usuarios)
                    {
                        Console.WriteLine(us.Nome);
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
