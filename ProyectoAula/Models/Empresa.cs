namespace ProyectoAula.Models
{
    // Clase que representa una empresa
    public class Empresa
    {
        // Propiedad que almacena el nombre de la empresa
        public string Nombre { get; set; }

        // Propiedad que almacena el código de la empresa
        public int Codigo { get; set; }

        // Constructor de la clase Empresa
        public Empresa(string nombre, int codigo)
        {
            Nombre = nombre; // Asigna el valor del nombre al atributo Nombre
            Codigo = codigo; // Asigna el valor del código al atributo Codigo
        }
    }
}
