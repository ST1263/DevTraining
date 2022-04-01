using SuplierProject.Data;
using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Repo
{
    public class ProductRepo:IProduct
    {
        ProductDbContext _context;
        public ProductRepo(ProductDbContext context)
        {
            _context = context;
        }

        public List<Product> Getproducts()
        {
            return _context.Product.ToList();
        }

        public Product GetProduct(int productid)
        {
            return _context.Product.FirstOrDefault(e => e.productid == productid);
        }

        public void AddProduct(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productid)
        {
            var product = _context.Product.Where(s => s.productid == productid).FirstOrDefault();
            if (product != null)
            {
                _context.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
