using HostelManagementSystem.Model;
using HostelManagementSystem.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdmissionController : Controller
    {
            AdmissionService _repo;
            public AdmissionController(AdmissionService repo)
            {
                _repo = repo;
            }

            [HttpGet]
            [Route("GetAdmissions")]
            public IActionResult GetAdmissions()
            {
                var alladmission = _repo.GetAdmissions();
                return Ok(alladmission);
            }

            [HttpGet]
            [Route("GetAdmissionById")]
            public IActionResult GetAdmissionById(int AdmissionId)
            {
                var result = _repo.GetAdmissionById(AdmissionId);
                return Ok(result);
            }

            [HttpPost]
            [Route("AddAdmission")]
            public IActionResult AddAdmission(Admission admission)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.AddAdmission(admission);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }

            [HttpPut]
            [Route("UpdateAdmission")]
            public IActionResult UpdateAdmission(Admission admission)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return BadRequest();
                    }
                    _repo.UpdateAdmission(admission);
                    return Ok();
                }
                catch (Exception ex)
                {
                    return NotFound(ex.Message);
                }
            }

            [HttpDelete]
            [Route("DeleteAdmission")]
            public IActionResult DeleteAdmission(int admission)
            {
                try
                {
                    _repo.DeleteAdmission(admission);
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

