using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos
{
    public class GetAllArticulos : IGetAllArticulos
    {
        private IRepositorioArticulos _repositorioArticulos;
        public GetAllArticulos(IRepositorioArticulos repo) 
        {
            _repositorioArticulos = repo;
        }
        public IEnumerable<ArticulosListadoDto> Ejecutar()
        {
            return ArticulosMappers.FromList(_repositorioArticulos.GetAll());
        }
    }
}
