using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5.animales
{
    internal abstract class Animal
    {
        protected String _nombre { get; set; }

        public string nombre
        {
            get { return _nombre; }
        }

        public abstract void comer();

    }
}
