// Controladores/ControladorVendedor.cs
using System; // Se necesita para utilizar clases del espacio de nombres básico
using System.Collections.Generic; // Se necesita para utilizar la clase List
using ProyectoAula.Models; // Se necesita para utilizar el modelo Vendedor

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con los vendedores
    public class ControladorVendedor
    {
        // Lista que almacena los vendedores
        private List<Vendedor> vendedores = new List<Vendedor>();

        // Método para agregar un nuevo vendedor a la lista
        public void AgregarVendedor(Vendedor vendedor)
        {
            vendedores.Add(vendedor); // Añade el vendedor proporcionado a la lista
        }

        // Método para modificar la dirección de un vendedor existente
        public void ModificarVendedor(int carne, string direccion)
        {
            // Busca el vendedor en la lista por su número de carné
            var vendedor = vendedores.Find(v => v.Carne == carne);
            if (vendedor != null) // Si se encuentra el vendedor
            {
                vendedor.Direccion = direccion; // Modifica la dirección del vendedor
            }
        }

        // Método para eliminar un vendedor de la lista
        public void EliminarVendedor(int carne)
        {
            // Busca el vendedor en la lista por su número de carné
            var vendedor = vendedores.Find(v => v.Carne == carne);
            if (vendedor != null) // Si se encuentra el vendedor
            {
                vendedores.Remove(vendedor); // Elimina el vendedor de la lista
            }
        }

        // Método para listar todos los vendedores
        public List<Vendedor> ListarVendedores()
        {
            return vendedores; // Devuelve la lista de vendedores
        }
    }
}
