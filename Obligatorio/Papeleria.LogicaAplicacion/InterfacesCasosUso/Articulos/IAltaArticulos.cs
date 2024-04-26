using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos
{
    public interface IAltaArticulos
    {
        void Ejecutar(ArticulosDto dto);
    }
}
