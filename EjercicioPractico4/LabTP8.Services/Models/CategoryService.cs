using FluentValidation;
using LabTP4.Entities;
using LabTP4.Entities.Validation;
using LabTP4.Logic;
using LabTP8.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP8.Services.Models
{
    public class CategoryService : ICategoryService
    {
        private CategoryLogic _categoria;
        public CategoryLogic CategoryLogic
        {
            get
            {
                if (_categoria == null)
                {
                    _categoria = new CategoryLogic();
                }
                return _categoria;
            }

            set { _categoria = value; }
        }

        public void AddCategory(Category category)
        {
            try
            {               
                ValidarCategory(category);
                CategoryLogic logic = new CategoryLogic();
                logic.Add(category);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category GetId(int id)
        {
            try
            {
                return this.CategoryLogic.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }  
        public List<Category> ListCategories()
        {
            CategoryLogic category = new CategoryLogic();

            try
            {
                return this.CategoryLogic.GetAll();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private static void ValidarCategory(Category category)
        {
            var validar = new CategoryValidation();
            validar.ValidateAndThrow(category);
        }
    }
}

