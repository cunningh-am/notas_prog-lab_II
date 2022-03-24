/*Un número perfecto es un entero positivo que es igual a la suma de todos los enteros positivos
 * (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.*/

using System;

namespace ejercicio_l04
{
    class Program
    {
		static void Main(string[] args)
		{
			int i = 1;
			int contador = 4;
			double aux;

			Console.WriteLine("Los primeros 4 numeros perfectos son:");
		
			while (contador > 0)
			{
				if (Prime(i))
				{
					aux = Math.Pow(2, i - 1) * (Math.Pow(2, i) - 1);
					if (Perfect(aux))
					{
                        Console.WriteLine(aux);
						contador--;
					}
				}
				i++;
			}
		}
		private static bool Prime(int n)
		{
			bool condicion = true;

			if (n == 1)
            {
				condicion = false;
            }

			for (int i = 2; i <= Math.Sqrt(n); ++i)
			{
				if (n % i == 0)
                {
					condicion = false;
                }
			}

			return condicion;
		}

		private static bool Perfect(double n)
		{
			bool condicion = false;
			double sumaDivisores = 0;

			for (int i = 1; i <= Math.Sqrt(n); ++i)
			{
				if (n % i == 0)
				{

					if (i == n / i)
					{
						sumaDivisores += i;
					}
					else
					{
						sumaDivisores += i;
						sumaDivisores += n / i;
					}

				}
			}

			sumaDivisores -= n;

			if (sumaDivisores == n)
            {
				condicion = true;
            }

			return condicion;
		}
	}
}
