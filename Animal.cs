using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Animal
{
    public abstract class Animal
    {
        // ATRIBUTO PRIVADO
		private string nombre;

		// PROPERTIES PUBLICA
		public string Nombre	
		{
			get { return nombre; }
			set { nombre = value; }
		}

		// CONSTRUCTOR SIN PARAMETROS
		public Animal()
		{
			nombre = string.Empty;
		}

		// CONSTRUCTOR CON PARAMETROS

		public Animal(string nombre)
		{
			this.nombre = nombre;
		}

        // METODO DE CONTROL
		
		public void HacerSonido()
		{
            Console.WriteLine("Hago un sonido generico de animal...");
		}


        // METODO DE TOSTRING SOBREESCRITO
        public override string ToString()
		{
			return nombre;
		}

	}
}
