using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using livro_receitas.ReceitasContext;
using livro_receitas.Models;

namespace livro_receitas.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly ReceitaContext _context;
        public ReceitasController(ReceitaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var receitas = _context.receitas.ToList();
            return View (receitas);
        }
        
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar (Receitas receitas)
        {
            if(ModelState.IsValid)
            {
                _context.receitas.Add(receitas);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(receitas);
        }
        public IActionResult Editar (int id)
        {
            var receitas = _context.receitas.Find(id);

            if (receitas == null)
            {
                return NotFound();
            }
            return View (receitas);
        }
        
        [HttpPost]
        public IActionResult Editar (Receitas receitas)
        {
            var receitaCadastrada = _context.receitas.Find(receitas.Id);

            receitaCadastrada.Nome = receitas.Nome;
            receitaCadastrada.Descrição = receitas.Descrição;
            receitaCadastrada.Igredientes = receitas.Igredientes;
            receitaCadastrada.Tipo = receitas.Tipo;
            receitaCadastrada.ModoDePreparo = receitas.ModoDePreparo;
            receitaCadastrada.LinkYoutube = receitas.LinkYoutube;

            _context.receitas.Update(receitaCadastrada);
            _context.SaveChanges();

            return RedirectToAction (nameof(Index));
        }

        public IActionResult Ver (int id)
        {
            var receitas = _context.receitas.Find(id);

            if(receitas == null)
            {
                return NotFound();
            }
            return View(receitas);
        }

        public IActionResult Deletar (int id)
        {
            var receitas = _context.receitas.Find(id);

            if(receitas == null)
            {
                return NotFound();
            }
            return View(receitas);
        }

        [HttpPost]
        public IActionResult Deletar (Receitas receitas)
        {
            var receitaCadastrada = _context.receitas.Find(receitas.Id);

            _context.receitas.Remove(receitaCadastrada);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}