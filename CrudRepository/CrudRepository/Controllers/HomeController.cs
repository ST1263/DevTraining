using CrudRepository.Infra;
using CrudRepository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace CrudRepository.Controllers
{
    public class HomeController : Controller
    {
      /*  private readonly ILogger<HomeController> _logger;*/
        private readonly IBook _repo;

        /*public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/

        public HomeController(IBook repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var booklist = _repo.GetBooks();
            return View(booklist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Book book)
        {
            _repo.Create(book);
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int BookId)
        {
            var book = _repo.GetBook(BookId);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            _repo.Update(book);
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int BookId)
        {
           *//* _repo.DeleteBook(book);*//*
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int BookId)
        {
            /*return RedirectToActionPermanent("Delete");*/
            _repo.DeleteBook(BookId);
            return View();

            
        }
        
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
