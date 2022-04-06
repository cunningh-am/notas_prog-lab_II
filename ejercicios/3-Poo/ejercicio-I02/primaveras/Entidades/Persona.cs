using System;

namespace Entidades
{
    public class Persona
    {
        // Atributos
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        // Constructor
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        // Setters
        public void SetNombre(string nuevoNombre)
        {
            this.nombre = nuevoNombre;
        }
        public void SetFecha(DateTime nuevaFecha)
        {
            this.fechaDeNacimiento = nuevaFecha;
        }
        public void SetDni(int nuevoDni)
        {
            this.dni = nuevoDni;
        }

        // Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFecha()
        {
            return this.fechaDeNacimiento;
        }
        public int GetDni()
        {
            return this.dni;
        }

        // Metodos
        private int CalcularEdad()
        {
            return DateTime.Today.Year - this.fechaDeNacimiento.Year;
        }

        public string Mostrar()
        {
            return $"Datos: " +
                $"\nNombre: {this.nombre}\n" +
                $"Fecha nacimiento: {this.fechaDeNacimiento}\n" +
                $"Dni: {this.dni}\n" +
                $"Edad: {CalcularEdad()}\n";
        }

        public string EsMayorDeEdad()
        {
            if (CalcularEdad() > 18) return "Es mayor de edad";
            else return "Es menor";
        }
    }
}
