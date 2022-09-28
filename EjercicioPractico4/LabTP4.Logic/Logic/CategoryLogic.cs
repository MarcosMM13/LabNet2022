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
            _context.Categories.Add(newObj);

            _context.SaveChanges();
        }

        public override void Delete(int id)
        {
            try
            {
            var categoriaEliminar = _context.Categories.Find(id);
            CambiarCategoriaProducto(categoriaEliminar.CategoryID);
            _context.Categories.Remove(categoriaEliminar);
            }
            catch (Exception ex)
            {

                throw ex;
            }

            _context.SaveChanges();
        }

        public override List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public override Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override void Update(Category obj)
        {
            try
            {
            var categoriaUpdate = _context.Categories.Find(obj.CategoryID);
            categoriaUpdate.CategoryName = categoriaUpdate.CategoryName;
            categoriaUpdate.Description = categoriaUpdate.Description;
            categoriaUpdate.Picture = categoriaUpdate.Picture;

            }
            catch (Exception ex)
            {

                throw ex;
            }

            _context.SaveChanges();
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
