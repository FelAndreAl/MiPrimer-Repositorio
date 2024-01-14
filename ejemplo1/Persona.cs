using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        // Persona: Edad, Sueldo, Nombre.
        // ATRIBUTOS o MIEMBROS.
        //int edad;
        //float sueldo;
        //string nombre;
        // Encapsulamiento: Ningún atributo debería poder ser accedido desde el exterior,
        // es una regla básica para los atributos de una clase.
        // Los atributos se pueden declarar como privados, públicos, etc, dependiendo de cuánto
        // acceso querramos que tengan desde el exterior, estos son los moificadores de visibilidad.
        private int edad;
        private float sueldo;
        private string nombre;

        // Para acceder a estos atributos declarados como privados, vamos a crear una función pública
        // que nos permita cargar los datos para guardarlos en el tipo de dato "persona".

        public void setEdad(int e)
        {
            edad = e;
        }

        // Para obtener la edad de una variable "persona" vamos a crear otro método que nos permita
        // acceder al valor declarado.

        public int getEdad()
        {
            return edad;
        }
    }
}
