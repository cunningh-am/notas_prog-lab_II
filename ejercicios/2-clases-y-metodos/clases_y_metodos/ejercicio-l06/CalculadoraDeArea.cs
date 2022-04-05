using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_l06
{
    class CalculadoraDeArea
    {
        private const double PI = Math.PI;
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double baseT, double altura)
        {
            return (baseT * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio)
        {
            return CalculadoraDeArea.PI * Math.Pow(radio, 2);
        }
    }
}
