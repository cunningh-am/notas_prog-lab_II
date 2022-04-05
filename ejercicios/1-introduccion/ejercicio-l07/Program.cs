/*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años)
 * y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total
 * (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
 * hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de 
 * todas esas operaciones restarle el 13% en concepto de descuentos.
 * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
 * el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados. */

using System;

namespace ejericicio_l07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkInt;
            string nombre;
            int cantidad, valorHora, years, horas;
            double totalBruto, totalNeto;

            do
            {
                Console.Write("Ingrese cantidad de empleados: ");
                checkInt = int.TryParse(Console.ReadLine(), out cantidad);
            } while (!checkInt);

            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese nombre del empleado: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese el valor por hora: ");
                    checkInt = int.TryParse(Console.ReadLine(), out valorHora);
                } while (!checkInt);

                do
                {
                    Console.Write("Ingrese la antigüedad (en años): ");
                    checkInt = int.TryParse(Console.ReadLine(), out years);
                } while (!checkInt);

                do
                {
                    Console.Write("Ingrese cantidad de horas trabajadas en el mes: ");
                    checkInt = int.TryParse(Console.ReadLine(), out horas);
                } while (!checkInt);

                totalBruto = (valorHora * horas) + (years * 150);
                totalNeto = totalBruto - (totalBruto * .13);

                Console.WriteLine("\nRecibo: ");
                Console.WriteLine("* Nombre: " + nombre);
                Console.WriteLine("* Antigüedad: " + years);
                Console.WriteLine("* Valor por hora: " + valorHora);
                Console.WriteLine("* Total bruto: " + totalBruto);
                Console.WriteLine("* Total neto: " + totalNeto);
                Console.WriteLine();
            }
        }
    }
}