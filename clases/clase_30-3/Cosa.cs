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
        private DateTime fecha;

        // parte 2
        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string pC) : this()
        {
            this.cadena = pC;
        }

        public Cosa(string pC, int pE) : this(pC)
        {
            this.entero = pE;
        }

        public Cosa(string pC, int pE, DateTime pF) : this(pC, pE)
        {
            this.fecha = pF;
        }

        // parte 1
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
            this.fecha = x;
        }

        public static string Mostrar(Cosa obj)
        {
            return obj.Mostrar();
        }

        private string Mostrar()
        {
            return "Entero: " + this.entero + "\nCadena: " + this.cadena + "\nFecha: " + this.fecha.ToShortDateString() + "\n";
        }
    }
}
