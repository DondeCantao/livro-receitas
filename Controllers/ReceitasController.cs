using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using livro_receitas.ReceitasContext;

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
            return View ();
        }
        
    }
}