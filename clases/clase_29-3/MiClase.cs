using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_29_3
{
    class MiClase
    {
        #region atributos

        public static int estatico;
        public int no_estatico;

        #endregion

        #region metodos
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

        #endregion

        #region constructor
        #region de instancia (por defecto)

        //public MiClase()
        //{
        //    this.no_estatico = 5;
        //}

        #endregion
        #region de instancia (con parametro)

        public MiClase()
        {
            this.no_estatico = 5;
        }

        #endregion
        #region de clase (static)

        static MiClase()
        {
            MiClase.estatico = 2;
        }

        #endregion
        #endregion
    }
}
