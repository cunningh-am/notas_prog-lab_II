using System;

namespace clase_30_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parte 1\n");
            Cosa obj = new Cosa();

            obj.EstablecerValor(10);
            obj.EstablecerValor(DateTime.Now);
            obj.EstablecerValor("Hola!");

            Console.WriteLine(Cosa.Mostrar(obj));

            Console.WriteLine("Parte 2\n");
            Cosa obj2 = new Cosa();
            Cosa obj3 = new Cosa("Hola");
            Cosa obj4 = new Cosa("Chau", 15);
            Cosa obj5 = new Cosa("Hola y chau", 20, new DateTime(2022, 12, 3));

            Console.WriteLine(Cosa.Mostrar(obj2));
            Console.WriteLine(Cosa.Mostrar(obj3));
            Console.WriteLine(Cosa.Mostrar(obj4));
            Console.WriteLine(Cosa.Mostrar(obj5));

            // Usando biblioteca

            Biblioteca.Class1 obj6 = new Biblioteca.Class1(); // puedo usar <using Biblioteca> 
            obj6.atributo = "probando";
            obj6.Metodo();
            Console.WriteLine(obj6.MostrarAtributo());
        }
    }
}
