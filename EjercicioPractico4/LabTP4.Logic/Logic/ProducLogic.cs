using LabTP4.Entities;
using LabTP4.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
    public class ProducLogic : BaseLogic<Product>
    {
        public override void Add(Product newObj)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public override Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Product obj)
        {
            var productoUpdate = _context.Products.Find(obj.ProductID);
            productoUpdate.CategoryID = null;
            _context.SaveChanges();
        }
    }
}
