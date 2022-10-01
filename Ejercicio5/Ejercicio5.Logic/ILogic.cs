using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Logic
{
    public interface ILogic <T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T newObj);
        void Delete(int id);

        void Update(T obj);

        IEnumerable<T> Listar();
    }
}
