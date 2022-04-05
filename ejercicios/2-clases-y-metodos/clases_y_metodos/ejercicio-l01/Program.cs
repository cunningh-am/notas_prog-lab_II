
using System;

namespace ejercicio_l01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int rangoMenor = -100;
            int rangoMayor = 100;
            bool checkInt;
            bool flag = true;
            int minimo = 0;
            int maximo = 0;
            int total = 0;
            float promedio = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}- Ingrese un numero entero dentro del rango {1} {2}: ", i, rangoMenor, rangoMayor);
                checkInt = int.TryParse(Console.ReadLine(), out numero);

                while (!checkInt || !Validador.Validar(numero, rangoMenor, rangoMayor))
                {
                    Console.WriteLine("\nError, ingreso invalido.");
                    Console.Write("{0}- Ingrese un numero entero dentro del rango {1} {2}: ", i, rangoMenor, rangoMayor);
                    checkInt = int.TryParse(Console.ReadLine(), out numero);
                }
     
                if (flag)
                {
                    minimo = numero;
                    maximo = numero;
                    flag = false;
                } else if (numero < minimo)
                {
                    minimo = numero;
                } else if (numero > maximo)
                {
                    maximo = numero;
                }

                total += numero;   
            }

            promedio = total / 10;
            Console.WriteLine("\nValor minimo ingresado: {0}\nValor maximo ingresado: {1}\nPromedio: {2}", minimo, maximo, promedio);
        }
    }
}
