﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.UsuariosException
{
    public class ContraseñaNoValidaException : Exception
    {
        public ContraseñaNoValidaException()
        {
        }

        public ContraseñaNoValidaException(string? message) : base(message)
        {
        }

        public ContraseñaNoValidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ContraseñaNoValidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
