using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            int edad;
            float sueldo;
            string nombre;

            // Para cargar datos la forma más clásica es crear vectores para cada tipo de dato
            // y guardarlos, pero a partir de ahora vamos a utilizar clases.
            // Para ello crearemos un nuevo tipo de dato denominado "persona" a la cual se le van a
            // declarar algunos atributos en los que vamos a modificar los datos para cada variable
            // de tipo persona.
            
            //int[] edades = new int[10];
            //float[] sueldos = new float[10];
            //string[] nombres = new string[10];

            //Persona p1 = new Persona();
            
            // Al crear la función "setEdad" ahora nos va a aparecer en las opciones cargar una edad
            // en nuestro tipo de dato. Por ejemplo:
            
            //p1.setEdad(20);

            // Nota: Cuando creamos una función en una clase se la denomina "método" por una
            // cuestión conceptual.

            // Al crear el método "getEdad" podremos leer la edad declarada en "p1".

            //Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            //Console.ReadKey();

            Botella b1 = new Botella();

            // Al crear la propiedad "Capacidad" podremos asignarle un valor al atributo capacidad de la
            // variable b1.

            //b1.Capacidad = 200;

            // Para leer este dato se hace de la siguiente manera.

            //int algo = b1.Capacidad;

            //Console.WriteLine("La capacidad de la botella es: " + algo);
            //Console.ReadKey();
            

        }
    }
}
