using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Excepciones.Articulos;
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
    public class DescripcionArticulo : IValidable<DescripcionArticulo>
    {
        public string DescripcionArticuloValor { get; private set; }

        public DescripcionArticulo (string descripcionArticulovalor)
        {
            DescripcionArticuloValor = descripcionArticulovalor;
            EsValido();
        }

        public void EsValido()
        {
            ValidarDescripcion();
        }

        private void ValidarDescripcion()
        {
            if(DescripcionArticuloValor.Length < 5)
                throw new ArticuloNoValidoException("La descripción del artículo debe contener al menso 5 caracteres");
        }
    }
}
