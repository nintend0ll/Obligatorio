using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.UsuariosException;
using Papeleria.LogicaNegocio.InterfacesAccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF.Repositorios
{
    public class RepositorioUsuariosEF : IRepositorioUsuarios 
    {
        private PapeleriaContext _context { get; set; }

        public RepositorioUsuariosEF(PapeleriaContext context)
        {
            _context = context;
        }

        public Usuario GetById(int id)
        {
            return _context.Usuarios.Where(user => user.Id == id).FirstOrDefault();
        }

        public void Add(Usuario obj)
        {
            try
            {
                _context.Usuarios.Add(obj);
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

        public void Update(int id, Usuario obj)
        {
            try
            {
                var user = _context.Usuarios.Find(id);
                if (user == null)
                    throw new ElementoNoEncontradoException($"No existe el autor con el id {id}");
                user.modificarUsuario(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Remove(int id)
        {
            //TODO: chequear uso de dto
            Usuario userBorrar = _context.Usuarios.Find(id);
            if (userBorrar == null) 
            {
                throw new ElementoNoEncontradoException("No existe usuario con ese id");
            }
            _context.Usuarios.Remove(userBorrar);
            _context.SaveChanges();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario ObtenerXEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(user => user.Email.DireccionEmail == email);
        }
    }
}
