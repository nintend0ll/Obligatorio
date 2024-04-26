using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;

namespace Papeleria_Obligatorio.Models
{
    public class ViewModelUsuario
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public AltaUsuarioDto GetUsuarioDto() 
        {
            AltaUsuarioDto usuarioDto = new AltaUsuarioDto()
            {
                Email = Email,
                Password = Password
            };
            return usuarioDto;
        }

        public ViewModelUsuario() { }

        public ViewModelUsuario(AltaUsuarioDto usuarioDto) 
        {
            Email = usuarioDto.Email;
            Password = usuarioDto.Password;
        }

    }
}
