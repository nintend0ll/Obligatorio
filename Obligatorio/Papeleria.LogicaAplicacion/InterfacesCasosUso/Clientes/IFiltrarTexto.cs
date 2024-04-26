﻿using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Clientes;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes
{
    public interface IFiltrarTexto
    {
        public IEnumerable<clienteDto> Ejecutar(string text);
    }
}
