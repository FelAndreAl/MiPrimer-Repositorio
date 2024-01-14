using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Manuel");
            //p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Carlos"));

            //Console.WriteLine("La edad de la persona es: " + p1.getEdad());

            /*Botella b1 = new Botella();
            Console.WriteLine("Capacidad de botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.Cantidad);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.Cantidad);
            */
            Console.ReadKey();
        }
    }
}
