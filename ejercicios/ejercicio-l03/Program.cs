/*Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 * Validar que el dato ingresado por el usuario sea un número.
 * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
 * Si ingresa "salir", cerrar la consola.
 * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar.
 * De lo contrario, cerrar la consola.*/

using System;

namespace ejercicio_l03
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            bool esNumero;
            int numero;

            do
            {
                Console.Write("Ingresar un numero positivo o \"salir\" para finalizar el programa: ");
                entrada = Console.ReadLine();
                esNumero = int.TryParse(entrada, out numero);

                if (entrada == "salir")
                {
                    break;
                }
            }
            while (!esNumero);

            if (entrada != "salir")
            {
                Console.WriteLine("\nNumeros primos hasta el {0}:", numero);
                for (int i = 1; i <= numero; i++)
                {
                    if (Primo(i))
                    {
                        Console.Write("{0} ", i);
                    }
                }
            }
        }

        private static bool Primo (int n)
        {
            bool condicion = false;

            if (n != 1 && n != 0)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        if (n == i)
                        {
                            condicion = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return condicion;
        }
    }
}
