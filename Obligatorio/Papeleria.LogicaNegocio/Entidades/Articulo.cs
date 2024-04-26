using Papeleria.LogicaNegocio.Excepciones;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Entidades
{
    //Hola
    public class Articulo : IValidable<Articulo>
    {
        #region Properties
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long Codigo { get; set; }
        public int PrecioVenta {  get; set; }
        public int Stock { get; set; }
        #endregion

        #region Constructor
        public Articulo(string nombre, string descripcion, long codigo, int precioVenta, int stock) 
        {
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Codigo = codigo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
        }

        public Articulo(int id, string nombre, string descripcion, long codigo, int precioVenta, int stock)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.Codigo = codigo;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
            this.EsValido();
        }
        public Articulo() { }
        #endregion

        public void EsValido() 
        {
            if (Nombre == null) throw new NombreNoValidoException("Nombre del articulo no puede ser vacio");
            if (Nombre.Length > 10 && Nombre.Length < 200) throw new NombreNoValidoException("Nombre debe contener entre 10 y 200 caracteres");
            if (Descripcion.Length < 5) throw new ElementoNoEncontradoException("La descripcion debe de contener al menos 5 caracteres");
            if (Codigo.ToString().Length > 13) throw new ElementoNoEncontradoException("El codigo tiene maximo 13 digitos");
            if (Codigo == null) throw new ElementoNoEncontradoException("Codigo del articulo no puede ser vacio");
        }

    }
}
