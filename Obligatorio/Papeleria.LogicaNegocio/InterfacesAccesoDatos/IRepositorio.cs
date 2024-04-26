using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesAccesoDatos
{
    public interface IRepositorio<T> where T : class
    {
        T GetById(int id);
        void Add(T obj);
        void Update(int id, T obj);
        void Remove(int id);
        IEnumerable<T> GetAll();
    }
}