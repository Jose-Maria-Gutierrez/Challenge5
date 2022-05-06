using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.animales
{
    internal class Gato : Animal
    {
        public Gato(string nombre)
        {
            this._nombre = nombre;
        }

        public override void comer()
        {
            Console.WriteLine("el gato " + this.nombre + " come whiskas");
        }
    }
}
