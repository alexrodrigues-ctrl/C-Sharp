using System;
using System.Collections.Generic;
using System.Text;
using Calculo;
using diretorio;
using calcular;
using funcoes;
using Classes;


namespace Tela
{
    class Menu
    {
        //var CONSTANTE
        public const int LER_ARQUIVO = 1;
        public const int CALCULO_MEDIA = 2;
        public const int SOMA = 3;
        public const int TABUADA = 4;
        public const int CADASTRAR_CLIENTE = 5;
        public const int CADASTRAR_USUARIO = 6;
        public const int ENVIAR_EMAIL = 7;
        public const int CADASTRAR_FORNECEDOR = 8;
        public const int SAIR = 9;
        //MENU
        public static void Criar()
        {
            while (true)
            {
                 
                Console.WriteLine("##############################                          ###############################");
                Console.WriteLine("##############################    MENU DO SISTEMA       ###############################");
                Console.WriteLine("##############################                          ###############################");

                Console.WriteLine("\n");
                Console.WriteLine("[1]-Ler Arquivo " +
                    "\n[2]-Calcular Média" +
                    "\n[3]-Somar" +
                    "\n[4]-Tabuada" +
                    "\n[5]-Cliente" +
                    "\n[6]-Usuário" +
                    "\n[7]-Envia email" +
                    "\n[8]-Fornecedor" +
                    "\n[9]-Sair");
                Console.WriteLine("\n");
                Console.WriteLine("##############################                          ###############################");
                Console.WriteLine("##############################    OPÇÕES DO SITEMAS     ###############################");
                Console.WriteLine("##############################                          ###############################");

                Console.WriteLine("##############################    bbbbbbbbbbbbbbb       ###############################");
                Console.WriteLine("##############################    bbbbbbbbbbbbbbbb      ###############################");
                Console.WriteLine("##############################    bbbb       bbbbb      ###############################");
                Console.WriteLine("##############################    bbbb       bbbbb      ###############################");
                Console.WriteLine("##############################    bbbbbbbbbbbbbb        ###############################");
                Console.WriteLine("##############################    bbbbbbbbbbbbbb        ###############################");
                Console.WriteLine("##############################    bbbb       bbbbbb     ###############################");
                Console.WriteLine("##############################    bbbb       bbbbbbb    ###############################");
                Console.WriteLine("##############################    bbbbbbbbbbbbbbbbbb    ###############################");
                Console.WriteLine("##############################    bbbbbbbbbbbbbbbbb     ###############################");



                
                int valor = int.Parse(Console.ReadLine());

                if (LER_ARQUIVO == valor)
                {
                    Arquivo.Ler(1);//Ler Arquivo
                }
                else if (CALCULO_MEDIA == valor)
                {
                    Media.Aluno();
                }
                else if (SOMA == valor)
                {
                    Soma.CalcularSoma();
                }
                else if (TABUADA == valor)
                {
                    Tabuada.CalacularTabuada();
                }
                else if (CADASTRAR_CLIENTE == valor)
                {
                    TelaCliente.Chamar();
                }
                else if (CADASTRAR_USUARIO == valor)
                {
                    TelaUsuario.Chamar();
                }
                else if (ENVIAR_EMAIL == valor)
                {
                    TelaEmail.EnviaEmail();                   
                    
                }
                else if (CADASTRAR_FORNECEDOR == valor)
                {
                    TelaFornecedor.Chamar();

                }
                else if (SAIR == valor)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }

        }//MENU FIM
    }
}
