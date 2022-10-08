using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP4.Logic
{
    public class CategoryLogic : BaseLogic<Category>
    {
        public override void Add(Category newObj)
        {
            try
            {

                _context.Categories.Add(newObj);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override void Delete(int id)
        {
            try
            {
                var categoriaEliminar = _context.Categories.Find(id);
                CambiarCategoriaProducto(categoriaEliminar.CategoryID);
                _context.Categories.Remove(categoriaEliminar);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public override List<Category> GetAll()
        {
            try
            {
                return _context.Categories.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public override Category GetById(int id)
        {
            var categoriaId = _context.Categories.Find(id);
            return categoriaId;
        }

        public override void Update(Category obj)
        {
            try
            {
                var categoriaUpdate = _context.Categories.Find(obj.CategoryID);
                categoriaUpdate.CategoryName = obj.CategoryName;
                categoriaUpdate.Description = obj.Description;
                categoriaUpdate.Picture = obj.Picture;
                _context.Entry(categoriaUpdate).Property(c => c.CategoryID).IsModified = false;
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public void CambiarCategoriaProducto(int categoriaID)
        {
            ProducLogic producLogic = new ProducLogic();
            foreach (var item in producLogic.GetAll())
            {
                if (categoriaID == item.CategoryID)
                    producLogic.Update(item);
            }
        }
    }
}
