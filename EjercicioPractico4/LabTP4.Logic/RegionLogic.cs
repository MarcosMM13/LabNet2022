using LabTP4.Data;
using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
    public class RegionLogic : BaseLogic, ILogic<Region>
    {     
        public List<Region> GetAll()
        {
            return _context.Regions.ToList();
        }
    }
}
