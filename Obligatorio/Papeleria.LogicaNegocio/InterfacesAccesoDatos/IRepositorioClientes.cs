using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesAccesoDatos
{
    public interface IRepositorioClientes : IRepositorio<Cliente>
    {
        public IEnumerable<Cliente> GetByText(string texto);
        public IEnumerable<Cliente> GetByMonto(decimal monto);
    }
}
