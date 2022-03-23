using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 edad = 18;
            String nombre = "Juan";

            Console.Title = "Ejercicio01"; // Titulo de la consola
            Console.WriteLine("Hello World!");
            // Imprimir en consola agregando secuencia de escape de salto de linea
            // equivalente a printf("Hello World!"); de C

            // Console.Write() -> Sin salto de linea

            Console.WriteLine("Nombre: {0} y edad: {1}", nombre, edad);

            Console.WriteLine("Ingrese apellido: ");
            String retorno = Console.ReadLine();  // Lee todo lo que escriba el usuario

            Console.WriteLine("Ingrese DNI: ");
            String dni_string = Console.ReadLine();

            int dni = int.Parse(dni_string); // Casteo explicito

            Console.Clear();
            Console.WriteLine("DNI: {3}\nAPELLIDO: {2}\nEDAD: {1} - NOMBRE: {0}", nombre, edad, retorno, dni);

            Console.ReadKey(); // Esperar a que se presione una tecla para cerrar la consola
        }
    }
}