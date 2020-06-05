using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Configuration.Internal;

namespace Classes //aula 19 Propriedade -> basicamente é controla de entrada(get) e saída(set) dos atributos.
{
    public class Cachorro : Animal
    {


        public int idade = 1;//atributo simples
        private int idadeDefinida = 2; //

        //atributos complexo, PROPRIEDADE
        public int idade2
        {
            //apenas obtem dados, controla a saída nao permitindo.
            get
            {
                return idadeDefinida; //consigo obter um atributo privado e usar numa instancia
            }
            //apenas seta dados, exibi informações desejada
            set
            {
                idadeDefinida = value; //posso alterar o seu valor na instancia
            }
        }
        
        
        
        
        
        
        
        
        //aqui sou obrigado sobre escrever o metodo abstrato de animal aqui!
        public override void Latir()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Latindo");
        }
    }
    
}
