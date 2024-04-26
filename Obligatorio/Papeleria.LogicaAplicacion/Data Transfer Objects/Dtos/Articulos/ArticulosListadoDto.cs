using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos
{
    public class ArticulosListadoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long Codigo { get; set; }
        public int PrecioVenta { get; set; }
        public int Stock { get; set; }

        public ArticulosListadoDto() { }
    }
}
