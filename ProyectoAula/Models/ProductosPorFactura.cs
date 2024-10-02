namespace ProyectoAula.Models
{
    // Clase que representa los productos en una factura
    public class ProductosPorFactura
    {
        // Propiedad que almacena la cantidad de productos
        public int Cantidad { get; set; }

        // Propiedad que almacena el subtotal de los productos
        public decimal Subtotal { get; set; }

        // Propiedad que almacena el producto asociado
        public Producto Producto { get; set; }

        // Propiedad que almacena la factura asociada
        public Factura Factura { get; set; }

        // Constructor de la clase ProductosPorFactura
        public ProductosPorFactura(int cantidad, decimal subtotal, Producto producto, Factura factura)
        {
            Cantidad = cantidad; // Asigna la cantidad proporcionada al atributo Cantidad
            Subtotal = subtotal; // Asigna el subtotal proporcionado al atributo Subtotal
            Producto = producto; // Asigna el producto proporcionado al atributo Producto
            Factura = factura; // Asigna la factura proporcionada al atributo Factura
        }
    }
}
