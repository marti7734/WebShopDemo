using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopDemo.Abstraction;
using WebShopDemo.Data;
using WebShopDemo.Domain;

namespace WebShopDemo.Services
{
    public class BrandService : IBrandService
    {
        private readonly ApplicationDbContext _context;

        public BrandService(ApplicationDbContext context)
        {
            _context = context;
        }
        public Brand GetBrandById(int brandId)
        {
            return _context.Brands.Find(brandId);
        }

        public List<Brand> GetBrands()
        {
            List<Brand> brands = _context.Brands.ToList();
            return brands;
        }

        public List<Product> GetProductByBrand(int brandId)
        {
            return _context.Products
                  .Where(x => x.BrandId == brandId)
                  .ToList();
        }

        IBrandService IBrandService.GetBrandById(int brandId)
        {
            throw new NotImplementedException();
        }
    }
}
