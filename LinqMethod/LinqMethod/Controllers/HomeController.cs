using LinqMethod.Model;
using LinqMethod.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        EmpService _repo;
        public HomeController(EmpService repo)
        {
            _repo = repo;
        }
       
        [HttpGet]
        [Route("GetEmps")]
        public IActionResult GetEmps()
        {
            var emp = _repo.GetEmps();
            return Ok(emp);
        }
        [HttpGet]
        [Route("GetEmpbyname")]
        public IActionResult GetEmpbyname()
        {
        
            var emp = _repo.GetEmpbyname();
            return Ok(emp);
        }
        [HttpGet]
        [Route("AddEmp")]
        public IActionResult AddEmp()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AddEmp")]
        public IActionResult AddEmp(Emp emp)
        {
            _repo.AddEmp(emp);
            return Ok();

        }
       
        [HttpGet]
        [Route("UpdateEmp")]
        public IActionResult UpdateEmp()
        {
            return Ok();
        }
     
        [HttpPut]
        [Route("UpdateEmp")]

        public IActionResult UpdateEmp(Emp emp)
        {
            _repo.UpdateEmp(emp);
            return Ok();
        }
       
        [HttpGet]
        [Route("DeleteEmp")]
        public IActionResult DeleteEmp(int EmpId)
        {
            var car = _repo.GetEmp(EmpId);
            return Ok(car);
        }
  
        [HttpDelete]
        [Route("DeleteEmp")]
        public IActionResult DeleteEmp(Emp emp)
        {
            _repo.DeleteEmp(emp);
            return Ok();
        }
      
    }
}
