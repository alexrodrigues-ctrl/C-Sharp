using Classes;
using System;
using System.Collections.Generic;
using System.Text;
using Tela;

namespace Tela
{
    class TelaEmail
    {

        public static void EnviaEmail()
        {
            Console.WriteLine("########################  Tela de Email  ####################################\n");
            
            while (true)
            {

                Console.WriteLine("##########################  O que deseja fazer?  ###############################");
                Console.WriteLine("[1]-Enviar email   [2]-Sair");
                int op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("Email De: ");
                    Email.Instancia.From = Console.ReadLine();

                    Console.WriteLine("Email Para: ");
                    Email.Instancia.To = Console.ReadLine();

                    Console.WriteLine("Título: ");
                    Email.Instancia.Subjecte = Console.ReadLine();

                    Console.WriteLine("Descrição:  ");
                    Email.Instancia.Body = Console.ReadLine();
                                        
                    Email.Instancia.EnviarEmail();
                    
                }
                else if (op == 2)
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
