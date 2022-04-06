using System;
using Entidades;

namespace ejemploUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteUno = new Estudiante("Geronimo", "Rodriguez", "A123");
            Estudiante estudianteDos = new Estudiante("Luana", "Loren", "B343");
            Estudiante estudianteTres = new Estudiante("Lucas", "Benavidez", "A504");

            estudianteUno.SetNotaPrimerParcial(8);
            estudianteUno.SetNotaSegundoParcial(7);

            estudianteDos.SetNotaPrimerParcial(7);
            estudianteDos.SetNotaSegundoParcial(10);

            estudianteTres.SetNotaPrimerParcial(3);
            estudianteTres.SetNotaSegundoParcial(2);

            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());
        }
    }
}
