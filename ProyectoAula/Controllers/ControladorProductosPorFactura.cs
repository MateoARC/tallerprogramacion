using System;
using System.Collections.Generic;
using ProyectoAula.Models;

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con los productos por factura
    public class ControladorProductosPorFactura
    {
        // Lista que almacena los productos por factura
        private List<ProductosPorFactura> productosPorFactura = new List<ProductosPorFactura>();

        // Método para agregar un nuevo producto a una factura
        public void AgregarProductoPorFactura(ProductosPorFactura productoPorFactura)
        {
            productosPorFactura.Add(productoPorFactura); // Añade el producto proporcionado a la lista
        }

        // Método para modificar las propiedades de un producto en una factura existente
        public void ModificarProductoPorFactura(int numeroFactura, int codigoProducto, int cantidad, decimal subtotal)
        {
            // Busca el producto en la lista por el número de factura y el código del producto
            var producto = productosPorFactura.Find(pf => pf.Factura.Numero == numeroFactura && pf.Producto.Codigo == codigoProducto);
            if (producto != null) // Si se encuentra el producto
            {
                producto.Cantidad = cantidad; // Modifica la cantidad
                producto.Subtotal = subtotal; // Modifica el subtotal
            }
        }

        // Método para eliminar un producto de una factura
        public void EliminarProductoPorFactura(int numeroFactura, int codigoProducto)
        {
            // Busca el producto en la lista por el número de factura y el código del producto
            var producto = productosPorFactura.Find(pf => pf.Factura.Numero == numeroFactura && pf.Producto.Codigo == codigoProducto);
            if (producto != null) // Si se encuentra el producto
            {
                productosPorFactura.Remove(producto); // Elimina el producto de la lista
            }
        }

        // Método para listar todos los productos de una factura
        public List<ProductosPorFactura> ListarProductosPorFactura(int numeroFactura)
        {
            // Devuelve los productos asociados a la factura indicada
            return productosPorFactura.FindAll(pf => pf.Factura.Numero == numeroFactura);
        }

        // Método para listar todos los productos por factura en general
        public List<ProductosPorFactura> ListarTodosLosProductosPorFactura()
        {
            return productosPorFactura; // Devuelve la lista de todos los productos por factura
        }
    }
}
