using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.animales
{
    internal class Perro : Animal
    {
        public Perro(String nombre)
        {
            this._nombre = nombre;
        }
        
        public override void comer()
        {
            Console.WriteLine("el perro " + this.nombre + " come carne");
        }
    }
}
