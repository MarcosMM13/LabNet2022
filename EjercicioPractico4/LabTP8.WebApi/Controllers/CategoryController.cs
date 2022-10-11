using LabTP4.Entities;
using LabTP4.Logic;
using LabTP8.Services.Models;
using LabTP8.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpPutAttribute = System.Web.Http.HttpPutAttribute;

namespace LabTP8.WebApi.Controllers
{
    public class CategoryController : ApiController
    {
        private CategoryService _categoryService;

        public CategoryService CategoryService
        {
            get
            {
                if (_categoryService == null)
                {
                    return new CategoryService();
                }
                return _categoryService;
            }
            set { _categoryService = value; }
        }

        // GET api/Category
        public IHttpActionResult GetCategory()
        {
            try
            {
                var listaCategoria = this.CategoryService.ListCategories();
                List<CategoryRequest> categoria = listaCategoria.Select(c => new CategoryRequest
                {
                    Id = c.CategoryID,
                    Nombre = c.CategoryName,
                    Descripcion = c.Description
                }).ToList();
                return Ok(categoria);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // GET api/Category/{id}
        public IHttpActionResult GetCategoryId(int id)
        {
            try
            {               
                var listaCategoria = this.CategoryService.ListCategories();
                var categoria = listaCategoria.Where(c => c.CategoryID == id).FirstOrDefault();
                var categoriaRequest = new CategoryRequest
                {
                    Id = categoria.CategoryID,
                    Nombre = categoria.CategoryName,
                    Descripcion = categoria.Description
                };
                return Ok(categoriaRequest);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        //POST api/Category
        public IHttpActionResult AddCategory([FromBody] CategoryRequest category)
        {
            try
            {
                Category cat = new Category
                {
                    CategoryID = category.Id,
                    CategoryName = category.Nombre,
                    Description = category.Descripcion
                };
                this.CategoryService.AddCategory(cat);
                return Content(HttpStatusCode.Created, cat);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        // PUT api/Category
        [HttpPut]
        public IHttpActionResult Put([FromBody] CategoryRequest category)
        {
            try
            {
                Category cat = new Category
                {
                    CategoryID = category.Id,
                    CategoryName = category.Nombre,
                    Description = category.Descripcion
                };
                CategoryService.UpdateCategory(cat);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {

                return Content(HttpStatusCode.NotFound, ex.Message);
            }
        }

        // DELETE api/Category/{id}
        public IHttpActionResult Delete(int id)
        {
            try
            {
                CategoryService.DeleteCategory(id);
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                 return Content(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}