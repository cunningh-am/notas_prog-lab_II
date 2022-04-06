using System;

namespace ClassLibrary
{
    public class Cuenta
    {
        // Atributos
        private string titular;
        private decimal cantidad;

        // Constructor
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        // Getters
        public string getTitular()
        {
            return this.titular;
        }
        
        public decimal getCantidad()
        {
            return this.cantidad;
        }

        // Metodos
        public string Mostrar()
        {
            // usar StringBuilder?
            return $"Datos de la cuenta: \n" +
                $"Razon social del titular de la cuenta: {getTitular()}\n" +
                $"Monto actual de la cuenta: {getCantidad()}\n";
        }

        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                this.cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            this.cantidad -= monto;
        }
    }
}
