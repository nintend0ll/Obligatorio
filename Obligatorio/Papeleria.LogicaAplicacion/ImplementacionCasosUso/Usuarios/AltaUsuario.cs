using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class AltaUsuario : IAltaUsuario
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public AltaUsuario(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
        public void Ejecutar(AltaUsuarioDto dto)
        {
            if (dto  == null) 
            {
                throw new ArgumentNullException(nameof(dto));
            }
            Usuario user = UsuarioMappers.FromDto(dto);
            _repositorioUsuarios.Add(user);
        }

    }
}
