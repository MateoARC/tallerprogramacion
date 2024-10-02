using System;
using System.Collections.Generic;
using ProyectoAula.Models;

namespace ProyectoAula.Controladores
{
    // Clase que controla las operaciones relacionadas con las empresas
    public class ControladorEmpresa
    {
        // Lista que almacena las empresas
        private List<Empresa> empresas = new List<Empresa>();


        // Método para agregar una nueva empresa a la lista
        public void AgregarEmpresa(Empresa empresa)
        {
            empresas.Add(empresa); // Añade la empresa proporcionada a la lista
        }

        // Método para modificar las propiedades de una empresa existente
        public void ModificarEmpresa(int codigo, string nombre)
        {
            // Busca la empresa en la lista por su código
            var empresa = empresas.Find(e => e.Codigo == codigo);
            if (empresa != null) // Si se encuentra la empresa
            {
                empresa.Nombre = nombre; // Modifica el nombre de la empresa
            }
        }

        // Método para eliminar una empresa de la lista
        public void EliminarEmpresa(int codigo)
        {
            // Busca la empresa en la lista por su código
            var empresa = empresas.Find(e => e.Codigo == codigo);
            if (empresa != null) // Si se encuentra la empresa
            {
                empresas.Remove(empresa); // Elimina la empresa de la lista
            }
        }

        // Método para listar todas las empresas
        public List<Empresa> ListarEmpresas()
        {
            return empresas; // Devuelve la lista de empresas
        }
    }
}
