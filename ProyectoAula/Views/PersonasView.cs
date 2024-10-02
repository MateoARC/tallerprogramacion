using System;
using System.Xml.Serialization;
using ProyectoAula.Controllers;
using ProyectoAula.Models;

public class PersonasView
{
    private ControladorPersonas _controladorPersonas;

    public PersonasView(ControladorPersonas controladorPersonas)
    {
        _controladorPersonas = controladorPersonas;
    }

    public void MenuPersonas()
    {
        int seleccion;
        do
        {
            Console.WriteLine("\nMenú Personas");
            Console.WriteLine("1. Agregar Personas");
            Console.WriteLine("2. Modificar Personas");
            Console.WriteLine("3. Eliminar Personas");
            Console.WriteLine("4. Listar Personas");
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
                    // Solicitar información para la nueva persona
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el email: ");
                    string email = Console.ReadLine();

                    Console.Write("Ingrese el teléfono: ");
                    string telefono = Console.ReadLine();

                    Console.Write("Ingrese el codigo: ");
                    string codigo = Console.ReadLine();

                    // creas una nueva instancia 

                    Personas nuevapersona = new Personas
                    {
                        Codigo = int.Parse(codigo),
                        Nombre = nombre,
                        Email = email,
                        Telefono = telefono,

                    };


                    // Llamar al método AgregarPersona del controlador
                    _controladorPersonas.AgregarPersona(nuevapersona);
                    Console.WriteLine("Persona agregada con éxito.");
                    break;

                case 2: 

                    Console.Write("Código de la persona a modificar: ");
                    int codigom = int.Parse(Console.ReadLine()); // Leer el código de la persona

                    Console.Write("Nuevo Email: ");
                    string emailm = Console.ReadLine(); // Leer el nuevo email

                    Console.Write("Nuevo Nombre: ");
                    string nombrem = Console.ReadLine(); // Leer el nuevo nombre

                    Console.Write("Nuevo Teléfono: ");
                    string telefonom = Console.ReadLine(); // Leer el nuevo teléfono


                    // Modificar la persona en la lista
                    _controladorPersonas.ModificarPersona(codigom, emailm, nombrem, telefonom);
                    Console.WriteLine("Persona modificada."); // Mensaje de confirmación
                    break;

                case 3:
                    Console.Write("Código de la persona a eliminar: ");
                    int codigoe = int.Parse(Console.ReadLine()); // Leer el código de la persona

                    _controladorPersonas.EliminarPersona(codigoe); // Eliminar la persona de la lista
                    Console.WriteLine("Persona eliminada."); // Mensaje de confirmación
                    break;
                case 4:
                    var personas = _controladorPersonas.ListarPersonas(); // Obtener la lista de personas
                    foreach (var persona in personas) // Iterar sobre cada persona
                    {
                    // Mostrar los detalles de cada persona
                    Console.WriteLine($"Código: {persona.Codigo}, Email: {persona.Email}, Nombre: {persona.Nombre}, Teléfono: {persona.Telefono}");
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
