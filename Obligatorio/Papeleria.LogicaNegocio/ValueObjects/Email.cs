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
    public class Email : IValidable<Email>
    {
        public string DireccionEmail { get; set; }

        public Email(string direccionEmail)
        {
            DireccionEmail = direccionEmail;
            EsValido();
        }

        public void EsValido() 
        {
            if (String.IsNullOrEmpty(DireccionEmail))
            {
                throw new MailNoValidoException("El email no puede ser nulo");
            }

            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if(!Regex.IsMatch(DireccionEmail, patron)) 
            {
                throw new MailNoValidoException("Mail no valido");
            }
        }
    }
}
