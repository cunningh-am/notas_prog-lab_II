using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_l02
{
    class Validador
    {
        public static bool ValidarRespuesta(char caracter)
        {
            bool condicion = false;

            if (Char.ToLower(caracter) == 's')
            {
                condicion = true;
            }

            return condicion;
        }
    }
}
