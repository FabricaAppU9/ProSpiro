using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using WebAppProSpiro.Models;
using WebAppProSpiro.ViewModel.PessoaViewModel;
using WebAppProSpiro.Enuns;

namespace WebAppProSpiro.Controllers
{
    [Authorize]
    public class PessoaController : Controller
    {

        private ApplicationDbContext _context;

        public PessoaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var ListPessoas = _context.PessoaViewModel.ToList();

            //return View(ListPessoas);

            var ListaPessoas = _context.PessoaViewModel.ToList();

            return View(ListaPessoas);
        }

        public IActionResult Create()
        {
            ViewBag.SimNao = ListEnum.ListEnum.ListSimNao();
            ViewBag.Genero = ListEnum.ListEnum.ListGenero();

            return View();
        }

        public async Task<IActionResult> CreatePessoa(PessoaViewModel pessoaViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.PessoaViewModel.Add(pessoaViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Create", pessoaViewModel);
        }

        
        public IActionResult Edit(int id)
        {
            ViewBag.SimNao = ListEnum.ListEnum.ListSimNao();
            ViewBag.Genero = ListEnum.ListEnum.ListGenero();

            var pessoa = _context.PessoaViewModel.FirstOrDefault(a => a.Id == id);

            return View(pessoa);
        }

        public async Task<IActionResult> EditPessoa(PessoaViewModel pessoaViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.PessoaViewModel.Update(pessoaViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View("Edit", pessoaViewModel);
        }

        [ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pessoa = _context.PessoaViewModel.FirstOrDefault(a => a.Id == id);
            _context.PessoaViewModel.Remove(pessoa);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult testeSteps()
        {
            return View();
        }
        
    }
}