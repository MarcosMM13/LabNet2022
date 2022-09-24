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
    }
}
