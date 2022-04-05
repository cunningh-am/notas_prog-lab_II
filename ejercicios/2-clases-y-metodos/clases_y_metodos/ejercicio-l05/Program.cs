using System;
using System.Text;

namespace ejercicio_l05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero para ver su tabla: ");
            int numero = int.Parse(Console.ReadLine());
            string tabla = CrearTabla(numero);

            Console.WriteLine($"\nTabla de multiplicar del número {numero}: \n{tabla}");

            static string CrearTabla(int n)
            {
                StringBuilder tabla = new StringBuilder();

                for (int i = 1; i <= 9; i++)
                {
                    tabla.Append($"{n} x {i} = {n * i}\n");
                }

                return tabla.ToString();
            }
        }
    }
}
