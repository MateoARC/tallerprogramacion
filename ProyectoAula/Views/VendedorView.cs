using System;
using System.Xml.Serialization;
using ProyectoAula.Controladores;
using ProyectoAula.Controllers;
using ProyectoAula.Models;

public class VendedorView
{
    private ControladorVendedor _controladorVendedor;

    public VendedorView(ControladorVendedor controladorVendedor)
    {
        
        _controladorVendedor = controladorVendedor;
    }

    public void MenuVendedor()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Vendedor");
            Console.WriteLine("1. Agregar Vendedor");
            Console.WriteLine("2. Modificar Vendedor");
            Console.WriteLine("3. Eliminar Vendedor");
            Console.WriteLine("4. Listar Vendedor");
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
                    Console.Write("Carne: ");
                    int carne = int.Parse(Console.ReadLine()); // Leer el carne

                    Console.Write("Dirección: ");
                    string direccion = Console.ReadLine(); // Leer la dirección

                    // Crear una nueva instancia de Vendedor
                    Vendedor vendedor = new Vendedor(carne, direccion);
                    _controladorVendedor.AgregarVendedor(vendedor); // Agregar el vendedor a la lista
                    Console.WriteLine("Vendedor agregado."); // Mensaje de confirmación    
                    break;

                case 2: 
                    Console.Write("Carne del vendedor a modificar: ");
                    int carnem = int.Parse(Console.ReadLine()); // Leer el carne del vendedor

                    Console.Write("Nueva Dirección: ");
                    string direccionm = Console.ReadLine(); // Leer la nueva dirección

                    // Modificar el vendedor en la lista
                    _controladorVendedor.ModificarVendedor(carnem, direccionm);
                    Console.WriteLine("Vendedor modificado."); // Mensaje de confirmación
                    break;

                case 3:
                    Console.Write("Carne del vendedor a eliminar: ");
                    int carnee = int.Parse(Console.ReadLine()); // Leer el carne del vendedor

                    _controladorVendedor.EliminarVendedor(carnee); // Eliminar el vendedor de la lista
                    Console.WriteLine("Vendedor eliminado."); // Mensaje de confirmación
                    break;
                case 4:
                    var vendedores = _controladorVendedor.ListarVendedores(); // Obtener la lista de vendedores
                    foreach (var vendedorl in vendedores) // Iterar sobre cada vendedor
                    {
                    // Mostrar los detalles de cada vendedor
                    Console.WriteLine($"Carne: {vendedorl.Carne}, Dirección: {vendedorl.Direccion}");
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
