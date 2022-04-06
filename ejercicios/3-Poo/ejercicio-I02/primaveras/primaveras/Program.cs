using System;
using Entidades;

namespace primaveras
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Martin", new DateTime(1994, 12, 25), 38232983);
            Persona personaDos = new Persona("Juan", new DateTime(2004, 10, 18), 45562643);
            Persona personaTres = new Persona("Martina", new DateTime(2000, 3, 13), 43341574);

            if (personaUno.EsMayorDeEdad() == "Es mayor de edad") Console.WriteLine(personaUno.Mostrar());
            if (personaDos.EsMayorDeEdad() == "Es mayor de edad") Console.WriteLine(personaDos.Mostrar());
            if (personaTres.EsMayorDeEdad() == "Es mayor de edad") Console.WriteLine(personaTres.Mostrar());
        }
    }
}
