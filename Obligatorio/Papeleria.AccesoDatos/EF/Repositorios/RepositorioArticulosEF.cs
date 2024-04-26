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
    public class RepositorioArticulosEF : IRepositorioArticulos
    {
        private PapeleriaContext _context { get; set; }

        public RepositorioArticulosEF(PapeleriaContext context)
        {
            _context = context;
        }

        public Articulo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Articulo obj)
        {
            try
            {
                _context.Articulos.Add(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {

                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(int id, Articulo obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Articulo obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Articulo> GetAll()
        {
            return _context.Articulos.ToList();
        }


    }
}
