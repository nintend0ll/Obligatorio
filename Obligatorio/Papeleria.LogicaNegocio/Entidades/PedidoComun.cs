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
    public class PedidoComun : Pedido
    {
        public PedidoComun(DateTime fecha, Cliente cliente) : base(fecha, cliente)
        {

        }

        public PedidoComun(int id, DateTime fecha, Cliente cliente) : base(id, fecha, cliente)
        {

        }
        protected PedidoComun() : base () 
        {
            
        }
    }
}
