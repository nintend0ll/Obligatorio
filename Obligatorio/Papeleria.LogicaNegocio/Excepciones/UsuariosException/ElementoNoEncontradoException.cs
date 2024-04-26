using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.UsuariosException
{
    public class ElementoNoEncontradoException : Exception
    {
        public ElementoNoEncontradoException()
        {
            //this.Message = "Usuario no encontrado en la base de datos";
        }

        public ElementoNoEncontradoException(string? message) : base(message)
        {
        }

        public ElementoNoEncontradoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ElementoNoEncontradoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
