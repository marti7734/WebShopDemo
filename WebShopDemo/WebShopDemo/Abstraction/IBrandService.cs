using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Domain;

namespace WebShopDemo.Abstraction
{
    public interface IBrandService
    {
        List<Brand> GetBrands();
        IBrandService GetBrandById(int brandId);
        List<Product> GetProductByBrand(int brandId);
    }
}
