using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos
{
    public class ArticulosMappers
    {
        public static Articulo FromDto(ArticulosDto dto) 
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));
            return new Articulo(dto.Nombre, dto.Descripcion, dto.Codigo, dto.PrecioVenta, dto.Stock);
        }
        
        public static ArticulosListadoDto ToDto(Articulo art) 
        {
            return new ArticulosListadoDto()
            {
                Nombre = art.Nombre,
                Descripcion = art.Descripcion,
                Codigo = art.Codigo,
                PrecioVenta = art.PrecioVenta,
                Stock = art.Stock
            };
        }

        public static IEnumerable<ArticulosListadoDto> FromList(IEnumerable<Articulo> arts) 
        {
            return arts.Select(x => ToDto(x));
        }
    }
}
