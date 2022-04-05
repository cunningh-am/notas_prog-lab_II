using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_l03
{
    class Conversor
    {
        private static string restos = "";

        public static int ConvertirDecimalABinario(int numeroEntero)
        {
            while (numeroEntero >= 1)
            {
                Conversor.restos += numeroEntero % 2;
                numeroEntero = numeroEntero / 2;
            }

            char[] arrayChars = Conversor.restos.ToCharArray();
            string reversedString = "";
            int length = arrayChars.Length - 1;
            int i = length;

            while (i > -1)
            {
                reversedString += arrayChars[i];
                i--;
            }

            return int.Parse(reversedString);
        }
        public static int ConvertirBinarioADecimal(int numeroEntero)
        { 
            int j = 0;
            int numero = 0;

            char[] digitos = numeroEntero.ToString().ToCharArray();
            for (int i = digitos.Length - 1; i >= 0; i--)
            {
                numero += (int)Math.Pow(int.Parse(digitos[i].ToString()) * 2, j);
                j++;
            }

            return numero;
        }
    }
}
