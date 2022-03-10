using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMvc.Controllers
{
    [Route("View")]
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            return Content("Welcome To Web MVC");
        }
        [HttpPost]
        [Route("Post")]
        public IActionResult Post()
        {
            return Content("Welcome to Post");
        }
    }
}
