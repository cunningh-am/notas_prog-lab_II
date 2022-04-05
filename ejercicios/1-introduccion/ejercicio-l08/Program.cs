/*
 * Escribir un programa que imprima por consola un triángulo.
 * El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo.
 */

using System;

namespace ejercicio_l08
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkInt;
            int cantidad;

            do
            {
                Console.Write("Ingrese la altura del triangulo: ");
                checkInt = int.TryParse(Console.ReadLine(), out cantidad);
            } while (!checkInt);

            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}