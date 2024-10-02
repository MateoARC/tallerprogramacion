using System;
using System.Collections.Generic;
using ProyectoAula.Models;

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con los clientes
    public class ControladorCliente
    {
        // Lista que almacena los clientes
        private List<Cliente> clientes = new List<Cliente>();
        // Método para agregar un nuevo cliente a la lista
        public void AgregarCliente(Cliente cliente)
        {
            clientes.Add(cliente); // Añade el cliente proporcionado a la lista
        }

        // Método para modificar las propiedades de un cliente existente
        public void ModificarCliente(int codigo, decimal credito)
        {
            // Busca el cliente en la lista por su código
            var cliente = clientes.Find(c => c.Codigo == codigo);
            if (cliente != null) // Si se encuentra el cliente
            {
                cliente.Credito = credito; // Modifica el crédito del cliente
            }
        }

        // Método para eliminar un cliente de la lista
        public void EliminarCliente(int codigo)
        {
            // Busca el cliente en la lista por su código
            var cliente = clientes.Find(c => c.Codigo == codigo);
            if (cliente != null) // Si se encuentra el cliente
            {
                clientes.Remove(cliente); // Elimina el cliente de la lista
            }
        }

        // Método para listar todos los clientes
        public List<Cliente> ListarClientes()
        {
            return clientes; // Devuelve la lista de clientes
        }
    }
}
