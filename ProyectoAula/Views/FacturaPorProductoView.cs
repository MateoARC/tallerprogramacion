using System;
using ProyectoAula.Controladores;
using ProyectoAula.Models;

public class ProductosPorFacturaView
{
    private ControladorProductosPorFactura _controladorProductosPorFactura;
    private ControladorFactura _controladorFactura;
    private ControladorProducto _controladorProducto;

    public ProductosPorFacturaView(ControladorProductosPorFactura controladorProductosPorFactura, ControladorFactura controladorFactura, ControladorProducto controladorProducto)
    {
        _controladorProductosPorFactura = controladorProductosPorFactura;
        _controladorFactura = controladorFactura;
        _controladorProducto = controladorProducto;
    }

    public void MenuProductosPorFactura()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Productos por Factura");
            Console.WriteLine("1. Agregar Producto a Factura");
            Console.WriteLine("2. Modificar Producto de Factura");
            Console.WriteLine("3. Eliminar Producto de Factura");
            Console.WriteLine("4. Listar Productos por Factura");
            Console.WriteLine("0. Salir");
            Console.WriteLine("");

            if (!int.TryParse(Console.ReadLine(), out seleccion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue;
            }

            switch (seleccion)
            {
                case 1:
                    // Agregar producto a una factura
                    Console.Write("Número de la factura: ");
                    int numeroFactura = int.Parse(Console.ReadLine());

                    // Verificar si la factura existe
                    var factura = _controladorFactura.ListarFacturas().Find(f => f.Numero == numeroFactura);
                    if (factura == null)
                    {
                        Console.WriteLine("Factura no encontrada.");
                        break;
                    }

                    Console.Write("Código del producto: ");
                    int codigoProducto = int.Parse(Console.ReadLine());

                    // Verificar si el producto existe
                    var producto = _controladorProducto.ListarProductos().Find(p => p.Codigo == codigoProducto);
                    if (producto == null)
                    {
                        Console.WriteLine("Producto no encontrado.");
                        break;
                    }

                    Console.Write("Cantidad: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Subtotal: ");
                    decimal subtotal = decimal.Parse(Console.ReadLine());

                    // Crear y agregar el producto por factura, ahora incluyendo la factura
                    var productoPorFactura = new ProductosPorFactura(cantidad, subtotal, producto, factura);
                    _controladorProductosPorFactura.AgregarProductoPorFactura(productoPorFactura);

                    Console.WriteLine("Producto agregado a la factura.");
                    break;

                case 2:
                    // Modificar producto de una factura
                    Console.Write("Número de la factura a modificar: ");
                    int numeroFacturaM = int.Parse(Console.ReadLine());

                    Console.Write("Código del producto a modificar: ");
                    int codigoProductoM = int.Parse(Console.ReadLine());

                    Console.Write("Nueva cantidad: ");
                    int nuevaCantidad = int.Parse(Console.ReadLine());

                    Console.Write("Nuevo subtotal: ");
                    decimal nuevoSubtotal = decimal.Parse(Console.ReadLine());

                    _controladorProductosPorFactura.ModificarProductoPorFactura(numeroFacturaM, codigoProductoM, nuevaCantidad, nuevoSubtotal);

                    Console.WriteLine("Producto modificado en la factura.");
                    break;

                case 3:
                    // Eliminar producto de una factura
                    Console.Write("Número de la factura: ");
                    int numeroFacturaE = int.Parse(Console.ReadLine());

                    Console.Write("Código del producto a eliminar: ");
                    int codigoProductoE = int.Parse(Console.ReadLine());

                    _controladorProductosPorFactura.EliminarProductoPorFactura(numeroFacturaE, codigoProductoE);

                    Console.WriteLine("Producto eliminado de la factura.");
                    break;

                case 4:
                    // Listar productos por factura
                    Console.Write("Número de la factura para listar los productos: ");
                    int numeroFacturaL = int.Parse(Console.ReadLine());

                    var productos = _controladorProductosPorFactura.ListarProductosPorFactura(numeroFacturaL);
                    if (productos.Count == 0)
                    {
                        Console.WriteLine("No hay productos en esta factura.");
                    }
                    else
                    {
                        foreach (var prod in productos)
                        {
                            Console.WriteLine($"Producto: {prod.Producto.Nombre}, Cantidad: {prod.Cantidad}, Subtotal: {prod.Subtotal}");
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Saliendo del menú.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        } while (seleccion != 0);
    }
}
