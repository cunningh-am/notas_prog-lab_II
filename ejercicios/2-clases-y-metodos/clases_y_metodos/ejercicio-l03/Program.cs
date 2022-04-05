using System;

namespace ejercicio_l03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool checkint;

            do
            {
                Console.Write("Ingrese un numero decimal para convertir a binario: ");
                checkint = int.TryParse(Console.ReadLine(), out numero);
            } while (!checkint);

            Console.WriteLine("Resultado de la conversion: " + Conversor.ConvertirDecimalABinario(numero)); 

            do
            {
                Console.Write("\nIngrese un numero binario para convertir a decimal: ");
                checkint = int.TryParse(Console.ReadLine(), out numero);
            } while (!checkint || numero.ToString().Length > 8);

            // Ademas, habria que validar que el numero binario solo contenga 1 y 0.
            Console.WriteLine("Resultado de la conversion: " + Conversor.ConvertirBinarioADecimal(numero));
        }
    }
}
