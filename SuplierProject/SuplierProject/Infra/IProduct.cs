using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Infra
{
    public interface IProduct
    {
        public List<Product> Getproducts();
        public Product GetProduct(int ProductId);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int product);
    }
}
