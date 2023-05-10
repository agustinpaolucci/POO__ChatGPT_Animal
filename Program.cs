using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ChatGPT_Animal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Perro dog01 = new Perro();
            dog01.Nombre = "Capitan";

            Gato cat01 = new Gato();
            cat01.Nombre = "Panchita";

            Console.WriteLine("Presiona una tecla que vamos a hacer sonidos propios...");
            Console.ReadLine();
            Console.WriteLine("Soy un PERRO, mi nombre es: "+dog01.Nombre+" y hago: ");
            dog01.Ladrar();
            Console.WriteLine("\n");
            Console.WriteLine("Soy un GATO, mi nombre es: "+cat01.Nombre+" y hago: ");
            cat01.Maullar();
            Console.WriteLine("\n");
            Console.WriteLine(dog01.ToString());
            Console.WriteLine(cat01.ToString());
            Console.ReadLine();


        }
    }
}


/*
POO - HERENCIA SOLUCIÓN A LA CONSIGNA DE CHATGPT:

1) Crear una clase "Animal" que tenga una propiedad "Nombre" y un método "HacerSonido".
2) Crear clases "Perro" y "Gato" que hereden de "Animal" y tengan sus propios métodos 
"Ladrar" y "Maullar" respectivamente.
3) Hacer solución incluyendo: super clase, subclases o clases derivadas, atributos, métodos
constructores CON parámetros y SIN, métodos ToString() y métodos de control. Instanciar las 
clases que corresondan y crear los objetos. Dictar comportamientos. Crear clase abstracta. 
Usar override cuando corresponda.
*/

