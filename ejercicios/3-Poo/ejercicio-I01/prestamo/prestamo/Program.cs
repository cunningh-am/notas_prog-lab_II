using System;
using ClassLibrary;

namespace prestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("UTN", 7000.25m);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Ingresar(2500);
            Console.WriteLine(cuenta.Mostrar());

            cuenta.Retirar(6000.260m);
            Console.WriteLine(cuenta.Mostrar());
        }
    }
}
