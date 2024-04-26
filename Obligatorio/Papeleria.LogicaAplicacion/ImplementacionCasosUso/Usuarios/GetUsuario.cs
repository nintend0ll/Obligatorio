using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class GetUsuario : IGetUsuario
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public GetUsuario(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
     
        public UsuarioListadoDto GetById(int id)
        {
            var user = _repositorioUsuarios.GetById(id);
            if (user == null)
            {
                throw new ElementoNoEncontradoException("No hay usuarios con ese id");
            }
            var userdto = UsuarioMappers.ToDto(user);
            return userdto;
        }
    }
}
