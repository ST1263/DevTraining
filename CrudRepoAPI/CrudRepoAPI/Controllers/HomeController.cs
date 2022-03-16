using CrudRepoAPI.Infra;
using CrudRepoAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepoAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[Action]")]
    [Route("Home")]
    public class HomeController : Controller
    {
        /*  private readonly ILogger<HomeController> _logger;*/
        private readonly ICustomer _repo;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public HomeController(ICustomer repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            var clist = _repo.GetCustomers();
            return Ok(clist);
        }
        [HttpGet]

        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _repo.Create(customer);
            return Ok();
        }

        /*[HttpGet]
        public IActionResult Edit(int CustId)
        {
            var book = _repo.GetCustomer(CustId);
            return View(book);
        }*/
        /*[HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _repo.Update(customer);
            return View();
        }*/
        /*[HttpGet]
        public IActionResult Delete(int CustId)
        {
           *//* _repo.DeleteCustomer(custpomer);*//*
            return View();
        }*/
       /* [HttpPost]
        public IActionResult Delete(int CustId)
        {
            *//*return RedirectToActionPermanent("Delete");*//*
            _repo.DeleteCustomer(CustId);
            return View();


        }*/

        /* public IActionResult Privacy()
         {
             return View();
         }

         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
         public IActionResult Error()
         {
             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }*/
    }
}
