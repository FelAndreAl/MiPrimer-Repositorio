using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_ventas
{
    class Articulo
    {
        // - Código de artículo(3 dígitos no correlativos)
        // - Precio
        // - Código de Marca(1 a 10)
        //private int codArticulo;
        // Una forma alterna para crear una propiedad que contenga el seter y el geter sin tener que
        // declarar primero el atributo. Se hace de la siguiente manera: esrcibiendo el término "prop"
        // y presionando dos veces tab nos generaremos directamente una propiedad.
        public int CodigoArticulo { get; set; }
        // La diferencia acá es que no vamos a poder manipular las acciones que queramos realizar
        // con el get y el set.

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
