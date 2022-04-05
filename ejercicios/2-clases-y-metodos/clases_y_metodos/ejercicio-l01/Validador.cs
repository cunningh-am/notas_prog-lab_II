using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_l01
{
    class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool condicion = false;

            if (valor >= min && valor <= max)
            {
                condicion = true;
            }
            return condicion;
        }
    }
}
