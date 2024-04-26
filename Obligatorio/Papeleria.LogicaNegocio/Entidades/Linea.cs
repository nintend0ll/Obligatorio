using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class Linea
    {
        public int unidades { get; set; }
        public decimal precioUnitario { get; set;}
        public List<Articulo> articulos = new List<Articulo>();
        public Linea()
        {
            
        }
        
    }

    
}
