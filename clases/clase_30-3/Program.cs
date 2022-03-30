using System;

namespace clase_30_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa obj = new Cosa();

            obj.EstablecerValor(10);
            obj.EstablecerValor(DateTime.Now);
            obj.EstablecerValor("Hola!");

            Console.WriteLine(Cosa.Mostrar(obj));
        }
    }
}
