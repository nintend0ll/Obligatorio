using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class ModificarUsuario : IModificarUsuario
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public ModificarUsuario(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
        public void Ejecutar(int id, UsuarioModificacionDto usuarioModificado)
        {
            Usuario buscar = _repositorioUsuarios.GetById(id);
            usuarioModificado.Rol = buscar.Rol;
            usuarioModificado.Email = buscar.Email.DireccionEmail;
            var usuario = UsuarioMappers.FromDto(usuarioModificado);
            _repositorioUsuarios.Update(id, usuario);
        }
    }
}
