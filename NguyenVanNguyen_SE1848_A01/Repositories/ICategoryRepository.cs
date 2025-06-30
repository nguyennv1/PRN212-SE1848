using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface ICategoryRepository
    {
        public List<Categories> GetAllCategories();
        public void AddCategory(Categories category);
        public Categories GetCategoryById(int categoryId);

    }
}
