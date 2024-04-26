using Papeleria.LogicaNegocio.Excepciones;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Entidades
{
    public abstract class Pedido
    {
        #region Properties
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente cliente { get; set; }
        List<Linea> Lineas { get => Lineas; }
        List<Pedido> Pedidos { get => Pedidos; }
        public decimal PrecioFinal {  get; set; }

        #endregion

        #region Constructor
        public Pedido(DateTime fecha, Cliente cliente) 
        {
            this.Fecha = fecha;
            this.cliente = cliente;
        }
        public Pedido(int id, DateTime fecha, Cliente cliente)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.cliente = cliente;
        }
        protected Pedido()
        {
            
        }
        #endregion

        public virtual int CalcularIVA()
        {
            return 1;
        }


    }
}
