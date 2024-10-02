// Controladores/ControladorProducto.cs
using System; // Se necesita para utilizar clases del espacio de nombres básico
using System.Collections.Generic; // Se necesita para utilizar la clase List
using ProyectoAula.Models; // Se necesita para utilizar el modelo Producto

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con los productos
    public class ControladorProducto
    {
        // Lista que almacena los productos
        private List<Producto> productos = new List<Producto>();
        

        // Método para agregar un nuevo producto a la lista
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto); // Añade el producto proporcionado a la lista
        }

        // Método para modificar las propiedades de un producto existente
        public void ModificarProducto(int codigo, string nombre, int stock, decimal valorUnitario, string Descripcion)
        {
            // Busca el producto en la lista por su código
            var producto = productos.Find(p => p.Codigo == codigo);
            if (producto != null) // Si se encuentra el producto
            {
                producto.Nombre = nombre; // Modifica el nombre del producto
                producto.Stock = stock; // Modifica el stock del producto
                producto.ValorUnitario = valorUnitario; // Modifica el valor unitario del producto
            
            }
        }

        // Método para eliminar un producto de la lista
        public void EliminarProducto(int codigo)
        {
            // Busca el producto en la lista por su código
            var producto = productos.Find(p => p.Codigo == codigo);
            if (producto != null) // Si se encuentra el producto
            {
                productos.Remove(producto); // Elimina el producto de la lista
            }
        }

        // Método para listar todos los productos
        public List<Producto> ListarProductos()
        {
            return productos; // Devuelve la lista de productos
        }
    }
}
