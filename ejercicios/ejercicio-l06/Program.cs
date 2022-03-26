/*Escribir un programa que determine si un año es bisiesto. 
 * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
 * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.*/

using System;

namespace ejercicio_l06
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstYear, secondYear;
            bool check;

            do
            {
                Console.Write("Ingrese el año inicial: ");
                check = int.TryParse(Console.ReadLine(), out firstYear);
            } while (!check);

            do
            {
                Console.Write("Ingrese el año final: ");
                check = int.TryParse(Console.ReadLine(), out secondYear);
            } while (!check);

            Console.WriteLine("\nAños bisiestos del {0} al {1}:", firstYear, secondYear);

            for (int i = firstYear; i <= secondYear; i++)
            {
                check = false;

                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    check = true;
                }

                if (check)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
