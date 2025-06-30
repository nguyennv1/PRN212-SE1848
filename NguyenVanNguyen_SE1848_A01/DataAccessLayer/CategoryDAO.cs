using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class CategoryDAO
    {
        private DataContextSingleton context = DataContextSingleton.Instance;
        public List<Categories> GetAllCategories()
        {
            return context.Categories;
        }
        public void AddCategory(Categories category)
        {
            category.CategoryID = context.Categories.Count > 0 ? context.Categories.Max(c => c.CategoryID) + 1 : 1;
            context.Categories.Add(category);
        }
        public Categories GetCategoryById(int categoryId)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryID == categoryId);
        }
    }
}
