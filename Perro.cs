using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Animal
{
    public class Perro : Animal
    {
        // CONSTRUCTOR SIN PARAMETROS

        public Perro()
        {
            base.Nombre = string.Empty;
        }

        // CONSTRUCTOR CON PARAMETROS
        public Perro(string nombre) :base(nombre)
        {
            base.Nombre = nombre;
        }

        // METODO DE CONTROL
        public void Ladrar()
        {
            Console.WriteLine("GUAU! GUAU! GUAU!");
        }

        // METODO TOSTRING

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
