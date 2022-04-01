using Microsoft.AspNetCore.Mvc;
using SuplierProject.Model;
using SuplierProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductService _repo;
        public ProductController(ProductService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("Getproducts")]
        public IActionResult Getproducts()
        {
            var product = _repo.Getproducts();
            return Ok(product);
        }

        [HttpGet]
        [Route("GetProduct")]
        public IActionResult GetProduct(int productid)
        {
            var result = _repo.GetProduct(productid);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(int product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.DeleteProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
