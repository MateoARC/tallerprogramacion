using System;
using System.Collections.Generic;
using ProyectoAula.Models;

namespace ProyectoAula.Controllers
{
    public class ControladorPersonas
    {
        // almacenar la informacion de las personas en una lista
        private List<Personas> ListaPersonas = new List<Personas>();

        // método para agregar una persona 
        public void AgregarPersona(Personas persona)
        {
            ListaPersonas.Add(persona);
        }

        // Método para modificar las propiedades de una persona existente
        public void ModificarPersona(int codigo, string email, string nombre, string telefono)
        {
            // Busca la persona en la lista por su código
            var persona = ListaPersonas.Find(p => p.Codigo == codigo);
            if (persona != null) // Si se encuentra la persona
            {
                persona.Email = email; // Modifica el email de la persona
                persona.Nombre = nombre; // Modifica el nombre de la persona
                persona.Telefono = telefono; // Modifica el teléfono de la persona
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }

        // Método para eliminar una persona de la lista
        public void EliminarPersona(int codigo)
        {
            // Busca la persona en la lista por su código
            var persona = ListaPersonas.Find(p => p.Codigo == codigo);
            if (persona != null) // Si se encuentra la persona
            {
                ListaPersonas.Remove(persona); // Elimina la persona de la lista
            }
            else
            {
                Console.WriteLine("Persona no encontrada.");
            }
        }

        // Método para listar todas las personas
        public List<Personas> ListarPersonas()
        {
            return ListaPersonas; // Devuelve la lista de personas
        }
    }
}
