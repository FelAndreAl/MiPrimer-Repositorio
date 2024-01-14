using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Primer lote con 10 registros de productos, cada uno tiene:
             *      - Código de artículo (3 dígitos no correlativos)
             *      - Precio
             *      - Código de Marca (1 a 10)
             * Segundo lote con las ventas de la semana. Cada venta tiene:
             *      - Código de artículo
             *      - Cantidad
             *      - Código Cliente (1 a 100)
             * Este lote corta con Código de Cliente cero. */

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();

                Console.WriteLine("Ingrese los datos del prudcto: ");
                Console.WriteLine("Código: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 al 10): ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Código de Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese el Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // Acá se realizan las acciones correspondientes.


                //Pedimos nuevamente el cliente para reiniciar el ciclo nuevamente.
                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Código de Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }

        }
    }
}
