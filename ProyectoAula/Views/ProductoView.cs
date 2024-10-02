using System;
using System.Xml.Serialization;
using ProyectoAula.Controladores;
using ProyectoAula.Controllers;
using ProyectoAula.Models;

public class ProductoView
{
    private ControladorProducto _controladorProducto;

    public ProductoView(ControladorProducto controladorProducto)
    {
        
        _controladorProducto = controladorProducto;
    }

    public void MenuProductos()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Productos");
            Console.WriteLine("1. Agregar Productos");
            Console.WriteLine("2. Modificar Productos");
            Console.WriteLine("3. Eliminar Productos");
            Console.WriteLine("4. Listar Productos");
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
                    Console.Write("Código: ");
                    int codigo = int.Parse(Console.ReadLine()); // Leer el código

                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine(); // Leer el nombre

                    Console.Write("Stock: ");
                    int stock = int.Parse(Console.ReadLine()); // Leer el stock

                    Console.Write("Valor Unitario: ");
                    decimal valorUnitario = decimal.Parse(Console.ReadLine()); // Leer el valor unitario


                    // Crear una nueva instancia de Producto
                    Producto producto = new Producto(codigo, nombre, stock, valorUnitario);
                    _controladorProducto.AgregarProducto(producto); // Agregar el producto a la lista
                    Console.WriteLine("Producto agregado."); // Mensaje de confirmación         
                    break;

                case 2: 
                     Console.Write("Código del producto a modificar: ");
                    int codigom = int.Parse(Console.ReadLine()); // Leer el código del producto

                    Console.Write("Nuevo Nombre: ");
                    string nombrem = Console.ReadLine(); // Leer el nuevo nombre

                    Console.Write("Nuevo Stock: ");
                    int stockm = int.Parse(Console.ReadLine()); // Leer el nuevo stock

                    Console.Write("Nuevo Valor Unitario: ");
                    decimal valorUnitariom = decimal.Parse(Console.ReadLine()); // Leer el nuevo valor unitario

                    Console.WriteLine("Nueva Descripcion: ");
                    string Descripcion = Console.ReadLine();

                    // Modificar el producto en la lista
                    _controladorProducto.ModificarProducto(codigom, nombrem, stockm, valorUnitariom,Descripcion);
                    Console.WriteLine("Producto modificado."); // Mensaje de confirmación
                    break;

                case 3:
                    Console.Write("Código del producto a eliminar: ");
                    int codigoe = int.Parse(Console.ReadLine()); // Leer el código del producto

                    _controladorProducto.EliminarProducto(codigoe); // Eliminar el producto de la lista
                    Console.WriteLine("Producto eliminado."); // Mensaje de confirmación
                    break;
                case 4:
                     var productos = _controladorProducto.ListarProductos(); // Obtener la lista de productos
                    foreach (var productol in productos) // Iterar sobre cada producto
                    {
                    // Mostrar los detalles de cada producto
                    Console.WriteLine($"Código: {productol.Codigo}, Nombre: {productol.Nombre}, Stock: {productol.Stock}, Valor Unitario: {productol.ValorUnitario}");
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
