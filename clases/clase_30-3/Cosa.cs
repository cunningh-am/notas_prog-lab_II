using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_30_3
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime date;

        public void EstablecerValor(int x)
        {
            this.entero = x;
        }

        public void EstablecerValor(string x)
        {
            this.cadena = x;
        }

        public void EstablecerValor(DateTime x)
        {
            this.date = x;
        }

        public static string Mostrar(Cosa obj)
        {
            return obj.Mostrar();
        }

        private string Mostrar()
        {
            return "Entero: " + this.entero + ", Cadena: " + this.cadena + ", Fecha: " + this.date.ToShortDateString();
        }
    }
}
