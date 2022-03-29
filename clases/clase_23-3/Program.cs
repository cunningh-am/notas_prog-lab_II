using System;

namespace clase_23_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio - Parte 1

            /*
            Sello.mensaje = "Hola mundo";
            Console.WriteLine(Sello.Imprimir());
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());
            */

            // Ejercicio - Parte 2

            /*
            Sello.mensaje = "Hola mundo C#";
            Sello.color = ConsoleColor.Green;
            Sello.ImprimirEnColor();
            */

            // Ejercicio - Parte 3 y 4

            Sello.mensaje = "Hola mundo";
            Sello.color = ConsoleColor.Green;
            Sello.ImprimirEnColor();

            Sello.Imprimir();
            Sello.Borrar();
            Sello.ImprimirEnColor();
        }
    }
}
