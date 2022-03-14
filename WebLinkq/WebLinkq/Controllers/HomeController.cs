using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLinkq.Models;

namespace WebLinkq.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    public class HomeController : Controller
    {

        //DI Constructor DI
        private IEmpRepository diRepository { get; set; }
        public HomeController(IEmpRepository diRepository)
        {
            this.diRepository = diRepository;
        }
        [HttpGet]
        public ActionResult GetAllEmp()
        {
          
            TestEmpRespository repository = new TestEmpRespository();
            List<Emp> allempdetails = repository.GetAllEmp();
            return Ok(allempdetails);
        }
        [HttpGet]
        public ActionResult GetEmpDetails(int Id)
        {
            
            
                TestEmpRespository repository = new TestEmpRespository();
                Emp empDetails = repository.GetEmpById(Id);
                return Ok(empDetails);
            }
           
        
       /* public IActionResult Index()
        {
            return View();
        }*/
    }
}
