using System;
using System.Text;

namespace Entidades
{
    public class Estudiante
    {
        // Atributos
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        // Constructores
        // Estatico
        static Estudiante()
        {
            random = new Random();
        }
        
        // Instancia
        public Estudiante(string nuevoNombre, string nuevoApellido, string nuevoLegajo)
        {
            this.nombre = nuevoNombre;
            this.apellido = nuevoApellido;
            this.legajo = nuevoLegajo;
        }

        // Setters
        public void SetNotaPrimerParcial(int nuevaNota)
        {
            this.notaPrimerParcial = nuevaNota;
        }
        public void SetNotaSegundoParcial(int nuevaNota)
        {
            this.notaSegundoParcial = nuevaNota;
        }

        // Metodos
        private float CalcularPromedio()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            } else
            {
                return -1;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre y apellido: {this.nombre} {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine($"Nota 1er parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota 2do parcial: {this.notaSegundoParcial}");
            sb.AppendLine($"Promedio: {CalcularPromedio()}");

            double notaFinal = CalcularNotaFinal();
            sb.AppendLine($"Nota final: {(notaFinal != -1 ? notaFinal : "Alumno desaprobado")}");

            return sb.ToString();
        }
    }
}
