﻿using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesAccesoDatos
{
    public interface IRepositorioUsuarios : IRepositorio<Usuario>
    {
        public Usuario ObtenerXEmail(string email);
    }
}