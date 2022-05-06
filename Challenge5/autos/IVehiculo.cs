using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5
{
    internal interface IVehiculo
    {
        void conducir();
        bool cargarNafta(int cant);
    }
}
