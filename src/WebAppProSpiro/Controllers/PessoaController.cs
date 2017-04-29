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
    //[Authorize]
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
        //public IActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    NivelAcessoViewModel nivelAcessoViewModel = _context.NivelAcessoViewModel.Single(m => m.IdNivelAcesso == id);
        //    if (nivelAcessoViewModel == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(nivelAcessoViewModel);
        //}

        //// POST: NivelAcessoViewModels/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(NivelAcessoViewModel nivelAcessoViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Update(nivelAcessoViewModel);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(nivelAcessoViewModel);
        //}

        //// GET: NivelAcessoViewModels/Delete/5
        //[ActionName("Delete")]
        //public IActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    NivelAcessoViewModel nivelAcessoViewModel = _context.NivelAcessoViewModel.Single(m => m.IdNivelAcesso == id);
        //    if (nivelAcessoViewModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(nivelAcessoViewModel);
        //}

        //// POST: NivelAcessoViewModels/Delete/5
        //[ActionName("DeleteConfirmed")]
        //public IActionResult DeleteConfirmed(int id)
        //{
        //    try
        //    {
        //        NivelAcessoViewModel nivelAcessoViewModel = _context.NivelAcessoViewModel.Single(m => m.IdNivelAcesso == id);
        //        _context.NivelAcessoViewModel.Remove(nivelAcessoViewModel);
        //        _context.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    catch (System.Exception)
        //    {

        //        return RedirectToAction("Index");
        //    }

        //}

        //public IActionResult SearchProject(string filtro)
        //{
        //    var search = _context.NivelAcessoViewModel.ToList();

        //    if (!string.IsNullOrEmpty(filtro))
        //    {
        //        search = _context.NivelAcessoViewModel.Where(a => a.DescricaoNivelAcesso.Contains(filtro)).ToList();
        //    }

        //    return PartialView(search);
        //}

    }
}