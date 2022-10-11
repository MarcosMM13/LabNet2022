using LabTP4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP8.Services.Interface
{
   public interface ICategoryService
    {
        List<Category> ListCategories();
        Category GetId(int id);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
        void AddCategory(Category category);
    }
}
