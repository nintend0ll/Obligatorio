using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class GetAllUsuarios : IGetAllUsuarios
    {
        private IRepositorioUsuarios _repositorioUsuarios;
        public GetAllUsuarios(IRepositorioUsuarios repo)
        {
            _repositorioUsuarios = repo;
        }
        public IEnumerable<UsuarioListadoDto> Ejecutar()
        {
            return UsuarioMappers.FromList(_repositorioUsuarios.GetAll());
        }
    }
}
