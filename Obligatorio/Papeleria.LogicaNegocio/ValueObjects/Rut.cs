using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.ValueObjects
{
    [ComplexType]
    public class Rut : IValidable<Rut>
    {
        public string NroRut {  get; set; }
        public Rut(string NroRut) 
        { 
            this.NroRut = NroRut;
            this.EsValido();
        }
        public void EsValido()
        {
            ValidarRut();
        }
        public void ValidarRut()
        {
            if (this.NroRut.Length > 12)
            {
                throw new ElementoNoEncontradoException("El RUT no puede ser mayor a 12 digitos");
            }
        }
    }
}
