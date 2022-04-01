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
    public class BillingAddressController : Controller
    {
        BillingAddressService _repo;
        public BillingAddressController(BillingAddressService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetBillingbysuplierId")]
        public IActionResult GetBillingbysuplierId(int suplierid)
        {
            var billings = _repo.GetBillingbysuplierId(suplierid);
            return Ok(billings);
        }

        [HttpPost]
        [Route("AddBillingAddress")]
        public IActionResult AddBillingAddress(BillingAddress billingAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddBillingAddress(billingAddress);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateBillingAddress")]
        public IActionResult UpdateBillingAddress(BillingAddress billingAddress)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateBillingAddress(billingAddress);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteBillingAddress")]
        public IActionResult DeleteBillingAddress(int suplier)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.DeleteBillingAddress(suplier);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        /* public IActionResult Index()
         {
             return View();
         }*/
    }
}
