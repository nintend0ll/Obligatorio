using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
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
    public class LoginUsuario : ILoginUsuario
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public LoginUsuario(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
        public Usuario Ejecutar(string email, string contraseña)
        {
            Usuario buscado = _repositorioUsuarios.ObtenerXEmail(email);
            if(buscado.Password.Password == contraseña) 
            {
                return buscado;
            }
            return null;
        }

       
    }
}
