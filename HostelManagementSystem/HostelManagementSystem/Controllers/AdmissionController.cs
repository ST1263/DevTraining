﻿using HostelManagementSystem.Model;
using HostelManagementSystem.Service;
using HostelManagementSystem.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Controllers
{
    [Authorize]
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
            try
            {
                var alladmission = _repo.GetAdmissions();
                return Ok(alladmission);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("GetAdmissionById")]
        public IActionResult GetAdmissionById(int AdmissionId)
        {
            try
            {
                var result = _repo.GetAdmissionById(AdmissionId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddAdmission")]
        public IActionResult AddAdmission(AdmissionVM admission)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Admission Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.AddAdmission(admission);
                //return Ok();
                return Ok(new Response { Status = "Success", Message = "Admission successfully!" });
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPut]
        [Route("UpdateAdmission")]
        public IActionResult UpdateAdmission(AdmissionVM admission)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Update Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.UpdateAdmission(admission);
                return Ok(new Response { Status = "Success", Message = "Update successfully!" });
                //return Ok();
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
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "Delete Failed! Please check your details and try again." });
                    //return BadRequest();
                }
                _repo.DeleteAdmission(admission);
                return Ok(new Response { Status = "Success", Message = "Delete successfully!" });
                //return Ok();
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

