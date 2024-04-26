using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Usuario : IValidable<Usuario>
    {
        #region Properties
        public int Id { get; set; }
        public Email Email { get; set; }
        public NombreCompleto NombreCompleto { get; set; }
        public Contraseña Password { get; set; }
        public string Rol { get; set; }
        #endregion

        #region Constructor
        public Usuario(string email, string nombre, string apellido, string password, string rol)
        {
            this.Email = new Email(email);
            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.Password = new Contraseña(password);
            this.Rol = rol; 
        }

        public Usuario(int id, string email, string nombre, string apellido, string password, string rol) 
        {
            this.Id = id;
            this.Email = new Email(email);
            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.Password = new Contraseña(password);
            this.Rol = rol;
            this.EsValido();
        }
        
        #endregion
        public Usuario() { }    


        public void modificarUsuario(Usuario obj) 
        {
            this.Email = obj.Email;
            this.Password = obj.Password;
            this.Rol = obj.Rol;
            this.NombreCompleto = obj.NombreCompleto;

        } 
        
        public void EsValido() 
        {
            if (Rol != "admin") throw new ElementoNoEncontradoException("Rol inexistente");

        }
    }
}
