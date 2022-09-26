using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabTP4.Entities;

namespace LabTP4.Logic
{
    public class TerritoriesLogic : BaseLogic, ILogic<Territory>
    {
        public void Add(Territory newTerritory)
        {
            _context.Territories.Add(newTerritory);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var territorioEliminar = _context.Territories.Find(id);

            _context.Territories.Remove(territorioEliminar);

            _context.SaveChanges();
        }

        public List<Territory> GetAll()
        {
            return _context.Territories.ToList();
        }

        public void Update(Territory territory)
        {
            var territorioUpdate = _context.Territories.Find(territory.TerritoryID);

            territory.TerritoryDescription = territory.TerritoryDescription;
            territory.RegionID = territory.RegionID;

            _context.SaveChanges();
        }
    }
}
