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
    public class PedidoExpress : Pedido
    {
        public PedidoExpress(DateTime fecha, Cliente cliente) : base(fecha, cliente)
        {

        }

        public PedidoExpress(int id, DateTime fecha, Cliente cliente) : base(id, fecha, cliente)
        {

        }
        protected PedidoExpress() : base()
        {
            
        }

    }
}
