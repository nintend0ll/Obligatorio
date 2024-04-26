using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF.Repositorios
{
    public class RepositorioClientesEF : IRepositorioClientes
    {
        private PapeleriaContext _context { get; set; }

        public RepositorioClientesEF(PapeleriaContext context)
        {
            _context = context;
        }

        public Cliente GetById(int id) 
        {
            return _context.Clientes.Where(user => user.Id == id).FirstOrDefault();
        }

        public void Add(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll() 
        {
            return _context.Clientes.ToList();
        }

        public IEnumerable<Cliente> GetByText(string texto) 
        {
            var clientes = _context.Clientes.Where(cli => cli.NombreCompleto.Nombre.Contains(texto) || cli.NombreCompleto.Apellido.Contains(texto));
            return clientes;
        }

        public IEnumerable<Cliente> GetByMonto(decimal monto) 
        {
            var clientes = _context.Pedidos.Include(pedido => pedido.cliente)
                .Where(pedido => pedido.PrecioFinal > monto)
                .Select(pedido => pedido.cliente)
                .ToList();
            return clientes;
        }
    }
}
