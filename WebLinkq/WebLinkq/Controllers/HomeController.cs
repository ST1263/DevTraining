using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLinkq.Models;
using WebLinkq.Services;

namespace WebLinkq.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class HomeController : Controller
    {

       
        /*private IEmpRepository diRepository { get; set; }
        public HomeController(IEmpRepository diRepository)
        {
            this.diRepository = diRepository;
        }*/

        //Use DI Avoid new Keyword 
        private readonly EmpService _EmpService = null;
        private readonly EmpServicetwo _EmpServicetwo = null;

        public HomeController(EmpService empService, EmpServicetwo empServicetwo)
        {
            _EmpService = empService;
            _EmpServicetwo = empServicetwo;
        }
        [HttpGet]
        public ActionResult GetAllEmp()
        {
            try
            {
                //TestEmpRespository repository = new TestEmpRespository();
                List<Emp> allempdetails = _EmpService.GetEmps();
                List<Emp> allempdetails1 = _EmpServicetwo.GetEmps();
                return Ok(allempdetails);
               
                /*var emp = _EmpService.GetEmps();
                var emp1 = _EmpServicetwo.GetEmps();*/
                // return Ok();
            }
            catch
            {
                // 204 code
                return NoContent();
            }
        }
        [HttpGet]
        public ActionResult GetEmpDetails(int Id)
        {

            try {
               // TestEmpRespository repository = new TestEmpRespository();
                Emp empDetails = _EmpService.GetEmpById(Id);
                Emp empDetails1 = _EmpServicetwo.GetEmpById(Id);
                return Ok(empDetails);
                //var emp = _EmpService.GetEmpById(Id);
                //var emp1 = _EmpServicetwo.GetEmpById(Id);
                //return Ok();
            }
            catch
            {
                return NoContent();
            }



        }   
        
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
