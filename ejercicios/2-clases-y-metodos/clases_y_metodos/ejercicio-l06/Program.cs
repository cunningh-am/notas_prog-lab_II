using System;

namespace ejercicio_l06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Armar un menu?
            Console.WriteLine(CalculadoraDeArea.CalcularAreaCuadrado(20));
            Console.WriteLine(CalculadoraDeArea.CalcularAreaTriangulo(10, 8));
            Console.WriteLine(CalculadoraDeArea.CalcularAreaCirculo(8));
        }
    }
}
