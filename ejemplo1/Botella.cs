using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    class Botella
    {
        // En este apartado vamos a crear un constructor para declarar de manera inicial las características de una variable botella,
        // de esta manera al crear el objeto se van a tener que declarar por primera y única vez lo que pida dicho constructor.
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        // "this." es un término para apuntar y referirse directamente a la clase, sin importar si dicha clase tiene un atributo con el mismo
        // nombre, de esta menera el contructor va a tomar como dato el parámetro que se le declaró en el programa "main".

        // Al crear este nuevo constructor estaríamos dejando obsoleto el constructor que ya tiene por defecto la clase "object", esto quiere
        // decir que ya no vamos a tener a disposición el constructor para tener un objeto vacío sin parámetros iniciales. Sin embargo, existe
        // una forma de tener éste contructor inicial además del que acabamos de crear, se denomina "sobrecarga del constructor" y consiste en
        // volver a crear nuevamente el constructor de la clase "object" pero esta vez sin parámetros, de esta manera al crear un nuevo objeto
        // el programa nos va a dar la opción de utilizar uno u otro constructor para inicializarlo.
        
        public Botella() { }

        ~Botella()
        {
            // Lógica que va a ejecutarse cuando se active actomaticamente el destructor.
        }

        // Botella: Capacidad, Color, Material;

        //private int capacidad;
        //private string color;
        //private string material;

        // PROPIEDAD
        // Una propiedad es un método simplificado para declarar valores a un atributo que nos permite utilizar C#.

        //public int Capacidad
        //{
        //    get { return Capacidad; }
        //    set { Capacidad = value; }
        //}
        // Agrego un comentario para hacer una prueba
    }
}
