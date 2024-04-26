using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios
{
    public interface IAltaUsuario
    {
        void Ejecutar(AltaUsuarioDto dto);
    }
}
