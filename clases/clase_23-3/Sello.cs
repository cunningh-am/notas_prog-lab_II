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
            string mensajeConFormato = "";
            string asteriscos = "";

            if (TryParse(Sello.mensaje, out string texto))
            {
                for (int i = 0; i < texto.Length + 2; i++)
                {
                    asteriscos += "*";
                }

                mensajeConFormato = asteriscos + "\n*" + texto + "*\n" + asteriscos;
            }

            return mensajeConFormato;
        }
        private static bool TryParse(string entrada, out string salida)
        {
            bool retorno = false;
            salida = "";

            if (entrada.Length > 0)
            {
                salida = entrada;
                retorno = true;
            }

            return retorno;
        }
    }
}
