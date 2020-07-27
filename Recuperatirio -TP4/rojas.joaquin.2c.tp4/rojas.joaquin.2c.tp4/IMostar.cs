using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rojas.joaquin._2c.tp4
{
    public interface IMostar<T>
    {
        string MostrarDatos(IMostar<T> elemento);
    }
}
