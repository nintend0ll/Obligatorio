using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios
{
    public class AltaUsuarioDto
    {
        public string Id { get; set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Rol {  get; set; }

        public AltaUsuarioDto() 
        { 

        }
       

    }
}
