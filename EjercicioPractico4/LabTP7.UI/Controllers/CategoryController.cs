using LabTP4.Entities;
using LabTP4.Logic;
using LabTP7.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTP7.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryLogic logic = new CategoryLogic();

        // GET: Category
        public ActionResult Index()
        {
            List<Category> categorias = logic.GetAll();

            List<CategoryView> categoriaViews = categorias.Select(c => new CategoryView
            {
                CategoryID = c.CategoryID,
                Nombre = c.CategoryName,
                Descripcion = c.Description
            }).ToList();

            return View(categoriaViews);
        }
        public ActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(CategoryView categoriaViews)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(categoriaViews);
                }

                var categoriaEntity = new Category
                {
                    CategoryName = categoriaViews.Nombre,
                    Description = categoriaViews.Descripcion
                };
                logic.Add(categoriaEntity);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index", "Error");
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            List<Category> categorias = logic.GetAll();
            var categoriaView = categorias.Where(c => c.CategoryID == id).FirstOrDefault();
            CategoryView modelCategoria = new CategoryView()
            {
                CategoryID = categoriaView.CategoryID,
                Nombre = categoriaView.CategoryName,
                Descripcion = categoriaView.Description
            };

            return View(modelCategoria);            
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoryView categoriaViews)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(categoriaViews);
                }
               
                    List<Category> categorias = logic.GetAll();
                    var categoriaView = categorias.Where(c => c.CategoryID == categoriaViews.CategoryID).FirstOrDefault();
                    Category modelCategoria = new Category()
                    {
                        CategoryID = categoriaViews.CategoryID,
                        CategoryName = categoriaViews.Nombre,
                        Description = categoriaViews.Descripcion
                    };
                    logic.Update(modelCategoria);
                
                    return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index","Error");
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
