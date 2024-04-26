using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class BorrarUsuario : IBorrarUsuario
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public BorrarUsuario(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
        public void borrarUsuario(int id)
        {
            _repositorioUsuarios.Remove(id);
        }
    }
}
