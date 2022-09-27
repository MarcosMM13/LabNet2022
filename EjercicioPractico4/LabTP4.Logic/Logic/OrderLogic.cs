using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;


namespace LabTP4.Logic.Logic
{
    public class OrderLogic : BaseLogic<Orders>
    {
        public override void Add(Orders newObj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }

        public override Orders GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Orders obj)
        {
            throw new NotImplementedException();
        }
    }
}
