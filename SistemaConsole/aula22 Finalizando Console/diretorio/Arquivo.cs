using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;

namespace diretorio
{
    class Arquivo
    {
        private static string caminhoArquivo() 
        {
            return ConfigurationManager.AppSettings["CaminhoArquivos"];
        }
        
        //Ler Aquivos INICIO
        public static void Ler(int numeroarquivo)//apartir da aula 7 funçoes e recursividade
        {
            string arquivoComCamiho = caminhoArquivo() + "arq" + numeroarquivo + ".txt";
            if (File.Exists(arquivoComCamiho))
                Console.WriteLine(arquivoComCamiho);

            using (StreamReader arquivo = File.OpenText(arquivoComCamiho))
            {
                string linha;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    Console.WriteLine(linha);
                }
            }
            string arquivoComCamiho2 = caminhoArquivo() + "arq" + (numeroarquivo + 1) + ".txt";

            if (File.Exists(arquivoComCamiho2))
            {
                Arquivo.Ler(numeroarquivo + 1);
            }

        }//Ler Aquivos FIM
    }
}
