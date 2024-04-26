using Papeleria.LogicaNegocio.ValueObjects;
using Papeleria.LogicaNegocio.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Cliente
    {
        #region Properties
        public int Id { get; set; }
        public NombreCompleto NombreCompleto { get; set; }
        public string RazonSocial { get; set; }
        public Rut NroRut {  get; set; }
        public Direccion Direccion { get; set; }
        #endregion

        #region Constructor
        public Cliente(string razonSocial, string nombre, string apellido, string NroRut, string calle, int numero, string ciudad, int distancia) 
        {
            this.RazonSocial = razonSocial;
            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.NroRut = new Rut(NroRut);
            this.Direccion = new Direccion(calle, numero, ciudad, distancia);
        }
        public Cliente(int id, string razonSocial, string nombre, string apellido, string NroRut, string calle, int numero, string ciudad, int distancia)
        {
            this.Id = id;
            this.RazonSocial = razonSocial;
            this.NombreCompleto = new NombreCompleto(nombre, apellido);
            this.NroRut = new Rut(NroRut);
            this.Direccion = new Direccion(calle, numero, ciudad, distancia);
        }
        public Cliente() { }
        #endregion

        
    }
}
