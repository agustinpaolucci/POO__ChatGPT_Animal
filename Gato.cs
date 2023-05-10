using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Animal
{
    public class Gato : Animal
    {
        // CONSTRUCTOR SIN PARAMETROS

        public Gato() 
        { 
            base.Nombre = string.Empty;
        }

        public Gato(string nombre) : base(nombre) 
        {
            base.Nombre = nombre;
        
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Maullar()
        {
            Console.WriteLine("MIAU! MIAU! MIAU!"  );

        }

    }
}
