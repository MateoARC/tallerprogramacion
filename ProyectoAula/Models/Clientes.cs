namespace ProyectoAula.Models
{
    // Clase que representa a un cliente
    public class Cliente
    {
        // Propiedad que almacena el código único del cliente
        public int Codigo { get; set; }

        // Propiedad que almacena el crédito del cliente
        public decimal Credito { get; set; }

        // Constructor de la clase Cliente
        public Cliente(int codigo, decimal credito)
        {
            Codigo = codigo; // Asigna el valor del código al atributo Codigo
            Credito = credito; // Asigna el valor del crédito al atributo Credito
        }
    }
}
