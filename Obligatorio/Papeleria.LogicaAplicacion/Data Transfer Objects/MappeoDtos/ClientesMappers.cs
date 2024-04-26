using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.Data_Transfer_Objects.Dtos.Usuarios;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.Data_Transfer_Objects.MappeoDtos
{
    public class ClientesMappers
    {
        public static clienteDto toDto(Cliente client) 
        {
            return new clienteDto()
            {
                Id = client.Id,
                Nombre = client.NombreCompleto.Nombre,
                Apellido = client.NombreCompleto.Apellido,
                RazonSocial = client.RazonSocial,
                Rut = client.NroRut.NroRut,
                Calle = client.Direccion.Calle,
                Numero = client.Direccion.Numero,
                Ciudad = client.Direccion.Ciudad,
                Distancia = client.Direccion.Distancia
            };
        }
        public static IEnumerable<clienteDto> FromList(IEnumerable<Cliente> clients)
        {
            return clients.Select(x => toDto(x));
        }
    }
}
