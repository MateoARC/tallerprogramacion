using System;
using System.Xml.Serialization;
using ProyectoAula.Controladores;
using ProyectoAula.Controllers;
using ProyectoAula.Models;

public class FacturaView
{
    private ControladorFactura _controladorFactura;
    private ControladorProducto _controladorProducto;

    public FacturaView(ControladorFactura controladorFactura,ControladorProducto controladorProducto)
    {
        _controladorFactura = controladorFactura;
        _controladorProducto = controladorProducto;
    }

    public void MenuFacturas()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Facturas");
            Console.WriteLine("1. Agregar Facturas");
            Console.WriteLine("2. Modificar Facturas");
            Console.WriteLine("3. Eliminar Facturas");
            Console.WriteLine("4. Listar Facturas");
            Console.WriteLine("0. Salir");
            Console.WriteLine("");

            if (!int.TryParse(Console.ReadLine(), out seleccion))
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                continue; // Volver a mostrar el menú
            }

            switch (seleccion)
            {
                case 1:
                    Console.Write("Fecha (dd/MM/yyyy): ");
                    DateTime fecha = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null); // Leer la fecha

                    Console.Write("Número: ");
                    int numero = int.Parse(Console.ReadLine()); // Leer el número de la factura

                    Console.Write("Total: ");
                    decimal total = decimal.Parse(Console.ReadLine()); // Leer el total de la factura

                    Console.Write("Código del producto: ");
                    int codigoProducto = int.Parse(Console.ReadLine()); // Leer el código del producto

                    // Buscando el producto por código
                    Producto producto = _controladorProducto.ListarProductos().Find(p => p.Codigo == codigoProducto);
                    if (producto == null)
                    {
                    Console.WriteLine("Producto no encontrado."); // Mensaje de error si no se encuentra el producto
                    return;
                    }

                    // Crear una nueva instancia de Factura
                    Factura factura = new Factura(fecha, numero, total, producto);
                    _controladorFactura.AgregarFactura(factura); // Agregar la factura a la lista
                    Console.WriteLine("Factura agregada."); // Mensaje de confirmación
                    break;

                case 2: 
                    Console.Write("Número de la factura a modificar: ");
                    int numeroM = int.Parse(Console.ReadLine()); // Leer el número de la factura

                    Console.Write("Nueva Fecha (dd/MM/yyyy): ");
                    DateTime fechaM = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null); // Leer la nueva fecha

                    Console.Write("Nuevo Total: ");
                    decimal totalM = decimal.Parse(Console.ReadLine()); // Leer el nuevo total

                    Console.Write("Código del nuevo producto: ");
                    int codigoProductoM = int.Parse(Console.ReadLine()); // Leer el código del nuevo producto

                    // Buscando el producto por código
                    Producto productom = _controladorProducto.ListarProductos().Find(p => p.Codigo == codigoProductoM);
                    if (productom == null)
                    {
                    Console.WriteLine("Producto no encontrado."); // Mensaje de error si no se encuentra el producto
                    return;
                    }

                    // Modificar la factura en la lista
                    _controladorFactura.ModificarFactura(numeroM, fechaM, totalM, productom);
                    Console.WriteLine("Factura modificada."); // Mensaje de confirmación
                    break;

                case 3:
                    Console.Write("Número de la factura a eliminar: ");
                    int numeroe = int.Parse(Console.ReadLine()); // Leer el número de la factura

                    _controladorFactura.EliminarFactura(numeroe); // Eliminar la factura de la lista
                    Console.WriteLine("Factura eliminada."); // Mensaje de confirmación
                    break;
                case 4:
                     var facturas = _controladorFactura.ListarFacturas(); // Obtener la lista de facturas
                    foreach (var facturad in facturas) // Iterar sobre cada factura
                    {
                    // Mostrar los detalles de cada factura
                    Console.WriteLine($"Fecha: {facturad.Fecha}, Número: {facturad.Numero}, Total: {facturad.Total}");
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
