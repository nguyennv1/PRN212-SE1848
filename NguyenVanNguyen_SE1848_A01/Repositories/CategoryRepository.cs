using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        CategoryDAO categoryDAO = new CategoryDAO();
        public void AddCategory(Categories category)
        {
            categoryDAO.AddCategory(category);
        }

        public List<Categories> GetAllCategories()
        {
            return categoryDAO.GetAllCategories();
        }

        public Categories GetCategoryById(int categoryId)
        {
            return categoryDAO.GetCategoryById(categoryId);
        }
    }
}
