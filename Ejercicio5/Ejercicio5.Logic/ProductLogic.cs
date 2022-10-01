using Ejercicio5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5.Logic
{
    public class ProductLogic : BaseLogic<Product>
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

        public override IEnumerable<Product> Listar()
        {
            return _context.Products;
        }

        public override void Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
