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

        public void Add(Region newRegion)
        {
            _context.Regions.Add(newRegion);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            //var regionEliminar = _context.Regions.First(r => r.RegionID == id);

            //regionEliminar = _context.Regions.FirstOrDefault(r => r.RegionID == id);

            //regionEliminar = _context.Regions.Single(r => r.RegionID == id);

            //regionEliminar = _context.Regions.SingleOrDefault(r => r.RegionID == id);

            var regionEliminar = _context.Regions.Find(id);

            _context.Regions.Remove(regionEliminar);

            _context.SaveChanges();
        }

        public void Update(Region region)
        {
            var regionUpdate = _context.Regions.Find(region.RegionID);

            regionUpdate.RegionDescription = region.RegionDescription;

            _context.SaveChanges();
        }
    }
}
