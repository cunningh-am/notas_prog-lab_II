using System;

namespace ejercicio_l04
{
    class Program
    {
        static void Main(string[] args)
        {
            float operandoUno, operandoDos;
            char operacion;
            bool checkFloat;
            bool checkChar = false;
            char[] operaciones = {'+', '-', '*', '/'};

            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                checkFloat = float.TryParse(Console.ReadLine(), out operandoUno);
            } while (!checkFloat);

            do
            {
                Console.WriteLine("Ingrese el segundo operando: ");
                checkFloat = float.TryParse(Console.ReadLine(), out operandoDos);
            } while (!checkFloat);

            do
            {
                Console.WriteLine("Ingrese la operacion (+, -, *, /): ");
                operacion = Console.ReadKey().KeyChar;

                foreach (char element in operaciones)
                {
                    if (element == operacion)
                    {
                        checkChar = true;
                        break;
                    }
                }
            } while (!checkChar);

            Console.WriteLine("Resultado: " + Calculadora.Calcular(operandoUno, operandoDos, operacion));

            // Falta ingresar hasta que el usuario quiera y validar mejor la division
        }
    }
}
