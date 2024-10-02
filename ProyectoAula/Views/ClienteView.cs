using System;
using System.Xml.Serialization;
using ProyectoAula.Controladores;
using ProyectoAula.Controllers;
using ProyectoAula.Models;

public class ClienteView
{
    private ControladorCliente _controladorCliente;

    public ClienteView(ControladorCliente controladorCliente)
    {
        _controladorCliente = controladorCliente;
    }

    public void MenuCliente()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Cliente");
            Console.WriteLine("1. Agregar Cliente");
            Console.WriteLine("2. Modificar Cliente");
            Console.WriteLine("3. Eliminar Cliente");
            Console.WriteLine("4. Listar Cliente");
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
                    // Aquí deberías implementar la lógica para agregar un cliente
                    Console.Write("Ingrese el código del cliente: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el crédito del cliente: ");
                    decimal credito = decimal.Parse(Console.ReadLine());

                    // Crear un nuevo cliente y agregarlo
                    var cliente = new Cliente(codigo, credito); // Usar el constructor que acepta parámetros
                    _controladorCliente.AgregarCliente(cliente);
                    Console.WriteLine("Cliente agregado.");
                    break;

                case 2: 

                    Console.Write("Ingrese el código del cliente a modificar: ");
                    int codigom = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo crédito: ");
                    decimal creditom = decimal.Parse(Console.ReadLine());

                    _controladorCliente.ModificarCliente(codigom, creditom);
                    Console.WriteLine("Cliente modificado.");
                    break;

                case 3:
                    Console.Write("Ingrese el código del cliente a eliminar: ");
                    int codigoe = int.Parse(Console.ReadLine());

                    _controladorCliente.EliminarCliente(codigoe);
                    Console.WriteLine("Cliente eliminado.");
                    break;
                case 4:
                    var listaClientes = _controladorCliente.ListarClientes();
                    if (listaClientes.Count == 0)
                    {
                    Console.WriteLine("No hay clientes registrados.");
                    return;
                    }

                    foreach (var clientel in listaClientes)
                    {
                    Console.WriteLine($"Código: {clientel.Codigo}, Crédito: {clientel.Credito}");
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
