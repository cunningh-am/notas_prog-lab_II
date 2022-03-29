using System;

namespace clase_29_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase obj;
            obj = new MiClase();

            MiClase obj2 = new MiClase();

            obj.no_estatico = 8;

            obj.MostrarNoEstatico();
            obj2.MostrarNoEstatico();

            obj.MostrarTodos();

            MiClase.MostrarEstatico();
        }
    }
}
