/*Ingresar 5 números por consola, guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

using System;

namespace ejercicio_l01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 0;
            int minimo = 0;
            bool flag = true;
            int total = 0;
            double promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (flag)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = !flag;
                }
                else if (numero > maximo)
                {
                    maximo = numero;
                }
                else if (numero < minimo)
                {
                    minimo = numero;
                }

                total += numero;
                promedio = total / 5.0;
            }
            Console.WriteLine("\nEl minimo es {0}\nEl maximo es {1}\nEl promedio es {2}", minimo, maximo, promedio);
        }
    }
}