using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SuplierProject.Model;
using SuplierProject.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SuplierController : Controller
    {
        SuplierService _repo;
        public SuplierController(SuplierService repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [Route("GetSupliers")]
        public IActionResult GetSupliers()
        {
            var supliers = _repo.GetSupliers();
            return Ok(supliers);
        }

        [HttpGet]
        [Route("GetSuplier")]
        public IActionResult GetSuplier(int suplierid)
        {
            var result = _repo.GetSuplier(suplierid);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddSuplier")]
        public IActionResult AddSuplier(Suplier suplier)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.AddSuplier(suplier);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateSuplier")]
        public IActionResult UpdateSuplier(Suplier suplier)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.UpdateSuplier(suplier);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpDelete]
        [Route("DeleteSuplier")]
        public IActionResult DeleteSuplier(int suplier)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest();
                }
                _repo.DeleteSuplier(suplier);
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
