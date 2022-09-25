using LabTP4.Entities;
using LabTP4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
    public class ProducLogic : BaseLogic, ILogic<Product>
    {
        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public void Add(Product newContext)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
