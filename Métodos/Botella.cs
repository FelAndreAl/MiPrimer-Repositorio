using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos
{
    class Botella
    {
        // Capacidad máxima: 100
        // Cantidad actual: inicia en cero.
        // Método recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100.

        public Botella()
        {
            capacidad = 100;
            cantidadActual = 0;
        }

        private int capacidad;
        private int cantidadActual;

        // Métodos

        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int Cantidad
        {
            get { return cantidadActual; }
        }
    }
}
