using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Domain;

namespace WebShopDemo.Abstraction
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        ICategoryService GetCategoryById(int categoryId);
        List<Product> GetProductsByCategory(int categoryId);

    }
}
