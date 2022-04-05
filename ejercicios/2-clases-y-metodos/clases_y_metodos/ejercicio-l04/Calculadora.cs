using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_l04
{
    class Calculadora
    {
        public static float Calcular(float primerOperando, float segundoOperando, char operacion)
        {
            float resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;
                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;
                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;
                case '/':
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    break;
            }

            return resultado;
        }
        private static bool Validar(float segundoOperando)
        {
            return segundoOperando != 0 ? true : false;
        }
    }
}
