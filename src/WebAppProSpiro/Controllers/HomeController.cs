using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppProSpiro.Models;
//using WebAppProSpiro.Data;
using WebAppProSpiro.ViewModel.PessoaViewModel;

namespace WebAppProSpiro.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {          
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public JsonResult RetornaValor()
        {
            Random rnd = new Random();

            int retorno = rnd.Next(100);

            return Json(new { retorno = retorno}); 
        }

        public IActionResult LadingPage()
        {
            return View();
        }
    }
}
