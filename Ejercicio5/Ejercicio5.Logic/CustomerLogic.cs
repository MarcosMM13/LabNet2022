using Ejercicio5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Logic
{
    public class CustomerLogic : BaseLogic<Customer>
    {
        public override void Add(Customer newObj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
        
        public override Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customer> Listar()
        {
            return _context.Customers;
        }
    }
}
