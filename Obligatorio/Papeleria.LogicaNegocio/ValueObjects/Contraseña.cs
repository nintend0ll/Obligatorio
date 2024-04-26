using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Contraseña : IValidable<Contraseña>
    {
        public string Password { get; set; }

        public Contraseña (string password)
        {
            Password = password;
            EsValido(); 
        }

        public void EsValido()
        {
            if (String.IsNullOrEmpty(Password))
            {
                throw new ContraseñaNoValidaException("La contraseña no puede ser nula");
            }
            //La contraseña debe tener un largo minimo de 6 caracteres
            if (Password.Length < 6)
            {
                throw new ContraseñaNoValidaException("La contraseña debe tener mas de 6 caracteres");
            }

            //La contraseña debe tener al menos una mayuscula
            if (!Regex.IsMatch(Password, "[A-Z]"))
            {
                throw new ContraseñaNoValidaException("La contraseña debe contener al menos una letra mayúscula.");
            }

            //La contraseña debe tener al menos una minuscula
            if (!Regex.IsMatch(Password, "[a-z]"))
            {
                throw new ContraseñaNoValidaException("La contraseña debe contener al menos una letra minúscula.");
            }

            //La contraseña debe tener al menos un digito
            if (!Regex.IsMatch(Password, "\\d"))
            {
                throw new ContraseñaNoValidaException("La contraseña debe contener al menos un dígito.");
            }

            //La contrasñea debe tener al menos un caracter de puntuacion
            if (!Regex.IsMatch(Password, "[.,;:!]"))
            {
                throw new ContraseñaNoValidaException("La contraseña debe contener al menos uno de los siguientes caracteres: . , ; : !");
            }

        }
    }
}
