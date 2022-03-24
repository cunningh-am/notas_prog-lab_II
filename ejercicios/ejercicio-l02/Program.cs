/*Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario,
 * mostrar el mensaje: "ERROR. ¡Reingresar número!".*/

using System;

namespace ejercicio_l02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado = 0;
            double cubo = 0;

            Console.Write("Ingrese un numero positivo: ");
            numero = int.Parse(Console.ReadLine());

            while (numero < 1) 
            {
                Console.Write("ERROR. ¡Reingresar número!: ");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);


            Console.WriteLine("\nEl numero {0}\n - al cuadrado es {1}\n - al cubo es {2}", numero, cuadrado, cubo);
        }
    }
}
