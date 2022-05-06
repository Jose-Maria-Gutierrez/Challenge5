using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal class Coche : IVehiculo
    {
        private int _gasolina;

        public int gasolina
        {
            get { return _gasolina; }
        }

        public Coche()
        {
            _gasolina = 0;
        }

        public Coche(int gasolina)
        {
            _ = cargarNafta(gasolina);
        }

        public bool cargarNafta(int cant)
        {
            bool result = cant > 0;
            this._gasolina += result ? cant : 0;
            return result;
        }

        public void conducir()
        {
            if (this._gasolina>0)
            {
                Console.WriteLine("el coche esta conduciendo");
            }
        }

        public override string ToString()
        {
            return "cant de gasolina: " + this._gasolina;
        }
    }
}
