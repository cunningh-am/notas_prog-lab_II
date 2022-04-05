/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números,
 * cuyas sumas son iguales. El primer centro numérico es el 6, el cual separa la lista (1 a 8) 
 * en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35,
 * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.*/

using System;

namespace ejercicio_l05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            bool check;

            do
            {
                Console.Write("Ingrese un numero: ");
                check = int.TryParse(Console.ReadLine(), out n);
            } while (!check);

            Console.WriteLine("\nCentros numericos del 1 al {0}:", n);

            for (int i = 1; i <= n; i++)
            {
                int sumaAnteriores = 0;
                for (int j = 1; j < i; j++)
                {
                    sumaAnteriores += j;
                }
                int sumaPosteriores = 0;
                int k = i + 1;
                while (sumaPosteriores < sumaAnteriores)
                {
                    sumaPosteriores += k;
                    k++;
                }
                if (sumaAnteriores == sumaPosteriores)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}