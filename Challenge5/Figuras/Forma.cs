using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal interface Forma
    {
        public Ubicacion c { get; set; }

        public double area();
        public double perimetro();

        public string ToString();
    }
}
