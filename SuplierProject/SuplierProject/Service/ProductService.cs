using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Service
{
    public class ProductService
    {
        IProduct _service;
        public ProductService(IProduct service)
        {
            _service = service;
        }

        public List<Product> Getproducts()
        {
            return _service.Getproducts().ToList();
        }

        public Product GetProduct(int productid)
        {
            return _service.GetProduct(productid);
        }

        public void AddProduct(Product product)
        {
            _service.AddProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            _service.UpdateProduct(product);
        }

        public void DeleteProduct(int product)
        {
            _service.DeleteProduct(product);
        }
    }
}
