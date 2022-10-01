using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio5.Entities;

namespace Ejercicio5.Logic
{
    public class OrderLogic : BaseLogic<Order>
    {
        public override void Add(Order newObj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public override Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Order> Listar()
        {
            return _context.Orders;
        }

        public override void Update(Order obj)
        {
            throw new NotImplementedException();
        }
    }
}
