using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using System.Configuration.Internal;

namespace Classes //aula 18 - Abstração
{
    public abstract class Animal
    {
        public string Coleira;
        public string Pelo;
        public string Olho;

        //metodo que deve ser implementado na Class Cachorro quando for herdado. Nao pode ser instaciada
        public abstract void Latir();

        //metodo já implementado.
        public string Correr()
        {
            return "Correndo";
        }

    }
}
