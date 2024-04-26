using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.UsuariosException
{
    public class MailNoValidoException : Exception
    {
        public MailNoValidoException()
        {
        }

        public MailNoValidoException(string? message) : base(message)
        {
        }

        public MailNoValidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected MailNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

    }
}
