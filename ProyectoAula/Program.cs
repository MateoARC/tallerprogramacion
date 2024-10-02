using System;
using ProyectoAula.Models;
using ProyectoAula.Controllers;
using System.Runtime.CompilerServices;
using ProyectoAula.Controladores;
using System.Runtime;

namespace ProyectoAula

{
    class Progama
    {
        // Controladores para manejar las operaciones CRUD de cada modelo
        private static ControladorPersonas controladorPersona = new ControladorPersonas();
        private static ControladorFactura controladorFacturas = new ControladorFactura();
        private static ControladorProducto controladorProducto = new ControladorProducto();
        private static ControladorVendedor controladorVendedor = new ControladorVendedor();
        private static ControladorCliente controladorliente = new ControladorCliente();
        private static ControladorEmpresa controladorEmpresa = new ControladorEmpresa();
        private static ControladorProductosPorFactura controladorProductorPorFactura = new ControladorProductosPorFactura();
        private static PersonasView personaswiew =  new PersonasView(controladorPersona);
        private static FacturaView facturaswiew =  new FacturaView(controladorFacturas,controladorProducto);
        private static ProductoView productoView = new ProductoView(controladorProducto);
        private static VendedorView vendedorView = new VendedorView(controladorVendedor);
        
        private static ClienteView clienteView = new ClienteView(controladorliente);

        private static EmpresaView empresaView = new EmpresaView(controladorEmpresa);

        private static ProductosPorFacturaView productosPorFacturaView = new ProductosPorFacturaView(controladorProductorPorFactura,controladorFacturas,controladorProducto);

        static void Main(string[] args)
        {
                        int opcion;

            // Bucle principal para mostrar el menú
            do
            {
                // Mostrar el menú principal
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Personas");
                Console.WriteLine("2. Productos");
                Console.WriteLine("3. Vendedores");
                Console.WriteLine("4. Facturas");
                Console.WriteLine("5. Clientes");
                Console.WriteLine("6. Empresa");
                Console.WriteLine("7. Producto Por Factura");
                Console.WriteLine("0. Salir");
                Console.Write("Elige una opción: ");

                // Validar la entrada del usuario
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingresa un número válido.");
                    continue; // Volver a mostrar el menú
                }

                // Manejar la opción elegida por el usuario
                switch (opcion)
                {
                    case 1:
                    personaswiew.MenuPersonas();
                    break;
                    case 2:
                    productoView.MenuProductos();
                    break;
                    case 3:
                    vendedorView.MenuVendedor();
                    break;
                    case 4:
                    facturaswiew.MenuFacturas();
                    break;
                    case 5: 
                    clienteView.MenuCliente();
                    break;
                    case 6: 
                    empresaView.MenuEmpresa();
                    break;
                    case 7: 
                    productosPorFacturaView.MenuProductosPorFactura();
                    break;
                    

                    

                }
            } while (opcion != 0); // Continuar hasta que el usuario elija salir


            
 

        }
    }

}