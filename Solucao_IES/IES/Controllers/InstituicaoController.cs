using IES.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IES.Controllers
{
    public class InstituicaoController : Controller
    {
        private static IList<Instituicao> instituicoes = new List<Instituicao>()
        {
            new Instituicao()
            {
                InstituicaoId = 1,
                Nome =  "UniParana",
                Endereco = "Parana"
            },


        new Instituicao()
        {
                InstituicaoId = 2,
                Nome = "UniSanta",
                Endereco = "SantaCatarina"
            },

        new Instituicao()
        {
                InstituicaoId = 3,
                Nome = "UniSaoPaulo",
                Endereco = "Parana"
            },

        new Instituicao()
        {
                InstituicaoId = 4,
                Nome = "UniSulGrandense",
                Endereco = "Parana"
            },

            new Instituicao()
            {
                InstituicaoId = 5,
                Nome =  "UniCarioca",
                Endereco = "Rio de Janeiro"
            },
    };

        public IActionResult Index()
        {
            return View(instituicoes.OrderBy(i=>i.Nome));
        }
        
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Instituicao instituicao)
        {
            instituicoes.Add(instituicao);
            instituicao.InstituicaoId = instituicoes.Select(i => i.InstituicaoId).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i=>i.InstituicaoId == instituicao.InstituicaoId).First());
            instituicoes.Add(instituicao);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoId == id).First());
        }

        public ActionResult Delete(long id)
        {
            return View(instituicoes.Where(i => i.InstituicaoId == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Instituicao instituicao)
        {
            instituicoes.Remove(instituicoes.Where(i => i.InstituicaoId == instituicao.InstituicaoId).First());
            
            return RedirectToAction("Index");
        }
    }
}
