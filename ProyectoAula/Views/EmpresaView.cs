using System;
using ProyectoAula.Controladores;
using ProyectoAula.Models;

public class EmpresaView
{
    private ControladorEmpresa _controladorEmpresa;

    public EmpresaView(ControladorEmpresa controladorEmpresa)
    {
        _controladorEmpresa = controladorEmpresa;
    }

    public void MenuEmpresa()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Empresa");
            Console.WriteLine("1. Agregar Empresa");
            Console.WriteLine("2. Modificar Empresa");
            Console.WriteLine("3. Eliminar Empresa");
            Console.WriteLine("4. Listar Empresas");
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
                    // Lógica para agregar una nueva empresa
                    Console.Write("Ingrese el código de la empresa: ");
                    int codigo = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nombre de la empresa: ");
                    string nombre = Console.ReadLine();

                    // Crear una nueva empresa y agregarla
                    var empresa = new Empresa(nombre,codigo); // Usar el constructor que acepta parámetros
                    _controladorEmpresa.AgregarEmpresa(empresa);
                    Console.WriteLine("Empresa agregada.");
                    break;

                case 2:
                    // Lógica para modificar una empresa existente
                    Console.Write("Ingrese el código de la empresa a modificar: ");
                    int codigoMod = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el nuevo nombre de la empresa: ");
                    string nuevoNombre = Console.ReadLine();

                    _controladorEmpresa.ModificarEmpresa(codigoMod, nuevoNombre);
                    Console.WriteLine("Empresa modificada.");
                    break;

                case 3:
                    // Lógica para eliminar una empresa
                    Console.Write("Ingrese el código de la empresa a eliminar: ");
                    int codigoEliminar = int.Parse(Console.ReadLine());

                    _controladorEmpresa.EliminarEmpresa(codigoEliminar);
                    Console.WriteLine("Empresa eliminada.");
                    break;

                case 4:
                    // Lógica para listar todas las empresas
                    var listaEmpresas = _controladorEmpresa.ListarEmpresas();
                    if (listaEmpresas.Count == 0)
                    {
                        Console.WriteLine("No hay empresas registradas.");
                        return;
                    }

                    foreach (var empresaItem in listaEmpresas)
                    {
                        Console.WriteLine($"Código: {empresaItem.Codigo}, Nombre: {empresaItem.Nombre}");
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
