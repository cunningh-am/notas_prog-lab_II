using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_23_3
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static void Imprimir()
        {
            string msj;       
            msj = ArmarFormatoMensaje();
            Console.WriteLine(msj);
            ArmarFormatoMensaje();
           
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Imprimir();
            Console.ResetColor();
        }
        private static string ArmarFormatoMensaje()
        {
            string mensajeConFormato;
            string asteriscos = "";

            for (int i = 0; i < Sello.mensaje.Length + 2; i++)
            {
                asteriscos += "*";
            }

            mensajeConFormato = asteriscos + "\n*" + Sello.mensaje + "*\n" + asteriscos;
            return mensajeConFormato;
        }
    }
}
