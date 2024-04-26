using Papeleria.LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using System.Text.RegularExpressions;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class NombreCompleto : IValidable<NombreCompleto>
    {
        #region Properties
            public string Nombre { get; private set; }
            public string Apellido { get; private set; }
        #endregion

        #region Constructor
        public NombreCompleto(string nombre, string apellido)
        {
                this.Nombre = nombre;
                this.Apellido = apellido;
                this.EsValido();
                
        }
        #endregion


        public void EsValido()
        {
            ValidarNombre();
            ValidarApellido();

        }  

        public void ValidarNombre()
        {
            string patron = @"^[A-Za-z]+(?:[' -][A-Za-z]+)*$";
            if (!Regex.IsMatch(Nombre.Trim(), patron))
            {
                throw new NombreNoValidoException("El nombre no es valido");
            }
        }

        public void ValidarApellido()
        {
            string patron = @"^[A-Za-z]+(?:[' -][A-Za-z]+)*$";
            if (!Regex.IsMatch(Apellido.Trim(), patron))
            {
                throw new NombreNoValidoException("El apellido no es valido");
            }
        }

    }
}

