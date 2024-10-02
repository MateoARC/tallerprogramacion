// Controladores/ControladorFactura.cs
using System; // Se necesita para utilizar clases del espacio de nombres básico
using System.Collections.Generic; // Se necesita para utilizar la clase List
using ProyectoAula.Models; // Se necesita para utilizar el modelo Factura

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con las facturas
    public class ControladorFactura
    {
        // Lista que almacena las facturas
        private List<Factura> facturas = new List<Factura>();

        // Método para agregar una nueva factura a la lista
        public void AgregarFactura(Factura factura)
        {
            facturas.Add(factura); // Añade la factura proporcionada a la lista
        }

        // Método para modificar las propiedades de una factura existente
        public void ModificarFactura(int numero, DateTime fecha, decimal total, Producto producto)
        {
            // Busca la factura en la lista por su número
            var factura = facturas.Find(f => f.Numero == numero);
            if (factura != null) // Si se encuentra la factura
            {
                factura.Fecha = fecha; // Modifica la fecha de la factura
                factura.Total = total; // Modifica el total de la factura
                
            }
        }

        // Método para eliminar una factura de la lista
        public void EliminarFactura(int numero)
        {
            // Busca la factura en la lista por su número
            var factura = facturas.Find(f => f.Numero == numero);
            if (factura != null) // Si se encuentra la factura
            {
                facturas.Remove(factura); // Elimina la factura de la lista
            }
        }

        // Método para listar todas las facturas
        public List<Factura> ListarFacturas()
        {
            return facturas; // Devuelve la lista de facturas
        }
    }
}
