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
    public class FiltrarMonto : IFiltrarMonto
    {
        private IRepositorioClientes _repositorioClientes;
        
        public FiltrarMonto(IRepositorioClientes repo) 
        {
            _repositorioClientes = repo;
        } 
        IEnumerable<clienteDto> IFiltrarMonto.Ejecutar(decimal monto)
        {
            return ClientesMappers.FromList(_repositorioClientes.GetByMonto(monto));
        }
    }
}
