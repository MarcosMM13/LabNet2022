using LabTP4.Data;
using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
    public class RegionLogic : BaseLogic<Region>
    {
        public override List<Region> GetAll()
        {
            return _context.Regions.ToList();
        }

        public override void Add(Region newObj)
        {
            _context.Regions.Add(newObj);

            _context.SaveChanges();
        }

        public override void Delete(int id)
        {
            var regionEliminar = _context.Regions.Find(id);

            _context.Regions.Remove(regionEliminar);

            _context.SaveChanges();
        }

        public override void Update(Region region)
        {//revisar porque no captura la excepcion!!
            try
            {
                var regionUpdate = _context.Regions.Find(region.RegionID);
                regionUpdate.RegionDescription = region.RegionDescription;

                _context.SaveChanges();

                //if (regionUpdate != null)
                //{
                //    regionUpdate.RegionDescription = region.RegionDescription;

                //    _context.SaveChanges();
                //}
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Region GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
