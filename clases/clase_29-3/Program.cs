using System;

namespace clase_29_3
{
    class MiClase
    {
        public static int estatico;
        public int no_estatico;

        public static void MostrarEstatico()
        {
            Console.WriteLine(MiClase.estatico);
        }

        public void MostrarNoEstatico()
        {
            Console.WriteLine(this.no_estatico);
        }

        public void MostrarTodos()
        {
            MiClase.MostrarEstatico();
            this.MostrarNoEstatico();
        }

        public MiClase()
        {
            this.no_estatico = 5;
        }

        static MiClase()
        {
            MiClase.estatico = 2;
        }
    }
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
