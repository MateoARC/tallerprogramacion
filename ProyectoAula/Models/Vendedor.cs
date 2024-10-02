namespace ProyectoAula.Models
{
    // Clase que representa un vendedor
    public class Vendedor
    {
        // Propiedad que almacena el número de identificación del vendedor
        public int Carne { get; set; }
        
        // Propiedad que almacena la dirección del vendedor
        public string Direccion { get; set; }

        // Constructor de la clase Vendedor
        // Inicializa las propiedades Carne y Direccion con los valores proporcionados
        public Vendedor(int carne, string direccion)
        {
            Carne = carne; // Asigna el valor del carne al atributo Carne
            Direccion = direccion; // Asigna el valor de la dirección al atributo Direccion
        }
    }
}
