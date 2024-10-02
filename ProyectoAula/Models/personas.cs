using System.Collections.Generic; // Se necesita para utilizar la lista de facturas

namespace ProyectoAula.Models
{
    // Clase que representa a una persona
    public class Personas
    {
        // Propiedad que almacena el código único de la persona
        public int Codigo { get; set; }
        
        // Propiedad que almacena el correo electrónico de la persona
        public string Email { get; set; }
        
        // Propiedad que almacena el nombre de la persona
        public string Nombre { get; set; }
        
        // Propiedad que almacena el número de teléfono de la persona
        public string Telefono { get; set; }

        // Constructor por defecto
        public Personas() { }
        



        // Constructor de la clase Persona
        // Inicializa las propiedades de la persona con los valores proporcionados
        public Personas(int codigo, string email, string nombre, string telefono)
        {
            this.Codigo = codigo; // Asigna el valor del código al atributo Codigo
            this.Email = email; // Asigna el valor del email al atributo Email
            this.Nombre = nombre; // Asigna el valor del nombre al atributo Nombre
            this.Telefono = telefono; // Asigna el valor del teléfono al atributo Telefono

        }


    }
}
