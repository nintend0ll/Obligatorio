using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes
{
    public class FiltrarTexto : IFiltrarTexto
    {
        private IRepositorioClientes _repositorioClientes;

        public FiltrarTexto(IRepositorioClientes repo)
        {
            _repositorioClientes = repo;
        }
        public IEnumerable<clienteDto> Ejecutar(string text)
        {
            return ClientesMappers.FromList(_repositorioClientes.GetByText(text));
        }

    }
}
