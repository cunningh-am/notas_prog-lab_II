using System;

namespace ejercicio_l02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int total = 0;
            bool checkInt;
            char continuar;

            do
            {
                do
                {
                    Console.Write("Ingrese un entero: ");
                    checkInt = int.TryParse(Console.ReadLine(), out numero);
                } while (!checkInt);

                total += numero;

                Console.Write("Desea continuar ingresando numeros? (S/N): ");
                continuar = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (continuar == 's');
            Console.WriteLine("\nSuma de los numeros enteros ingresados: " + total);
        }
    }
}
