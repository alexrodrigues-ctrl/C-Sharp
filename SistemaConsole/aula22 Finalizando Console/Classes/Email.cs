using System;
using System.Collections.Generic;
using System.Text;


namespace Classes
{
    public class Email //coloquei publico
    {
        private Email(){} //construtor privado, 

        //atributo para armazenar a Instancia desejada (note instancia)
        private static Email instancia;
        public string From;
        public string To;
        public string Subjecte;
        public string Body;

        public void EnviarEmail()
        {
            //poderia configurar uma DLL para envio do email
            Console.WriteLine("###################      Enviado com sucesso!        ##################");
            Console.WriteLine("De: "+ From+"\nPara: "+To+"\nTítulo: "+Subjecte+"\nDescrição: "+Body);
        }
       
        //Propriedade para da ação a minha instancia da classe (NOTE Instancia)
        public static Email Instancia
        {
            get
            {
                if (instancia == null)
                {
                    //AQUI posso cria a instância tô dentro da minha classe
                    instancia = new Email();
                }
                return instancia;
            
            }
            //set; //nao preciso do SET (escrever), apenas o GET (leitura) 
        }       
        
        
    }
}
