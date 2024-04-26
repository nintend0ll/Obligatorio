using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Articulos
{
    public class AltaArticulos : IAltaArticulos
    {
        private IRepositorioArticulos _repositorioArticulos;
        public AltaArticulos(IRepositorioArticulos repo)
        {
            _repositorioArticulos = repo;
        }
        public void Ejecutar(ArticulosDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto));
            }
            Articulo art = ArticulosMappers.FromDto(dto);
            _repositorioArticulos.Add(art);
        }

    }
}
