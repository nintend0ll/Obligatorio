using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos
{
    public class UsuarioMappers
    {
        public static Usuario FromDto(AltaUsuarioDto dto) 
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            return new Usuario(dto.Email, dto.Nombre, dto.Apellido, dto.Password, dto.Rol);
        }
        public static Usuario FromDto(UsuarioModificacionDto dto) 
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            var usuario = new Usuario(dto.Email, dto.Nombre, dto.Apellido, dto.Password, dto.Rol);
            usuario.Id = dto.Id;
            return usuario;
        }

        public static UsuarioListadoDto ToDto(Usuario user) 
        {
            return new UsuarioListadoDto()
            {
                Email = user.Email.DireccionEmail,
                Password = user.Password.Password,
                Rol = user.Rol,
                Nombre = user.NombreCompleto.Nombre,
                Apellido = user.NombreCompleto.Apellido,
                Id = user.Id
            };
        }

        public static IEnumerable<UsuarioListadoDto> FromList(IEnumerable<Usuario> users) 
        {
            return users.Select(x => ToDto(x));
        }
    }
}
