using Microsoft.EntityFrameworkCore;
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
    public class Direccion : IValidable<Direccion>
    {
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string Ciudad { get; set; }
        public int Distancia { get; set; }

        public Direccion(string calle, int numero, string ciudad, int distancia) 
        {   
            this.Calle = calle;
            this.Numero = numero;
            this.Ciudad = ciudad;
            this.Distancia = distancia;
        }

        public Direccion() 
        {

        }

        public void EsValido()
        {
            throw new NotImplementedException();
        }
    }
}
