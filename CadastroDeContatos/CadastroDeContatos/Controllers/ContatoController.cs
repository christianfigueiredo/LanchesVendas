using CadastroDeContatos.Models;
using CadastroDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CadastroDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<Contato> contatos = _contatoRepositorio.BuscarTodos();

            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
           Contato contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            Contato contato = _contatoRepositorio.ListaPorId(id);
            return View(contato);
        }

        public IActionResult Apague(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }
       
        //public IActionResult Apagar(int id)
        //{
        //    _contatoRepositorio.Apagar(id);
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }

            return View(contato);
           
        }
        public IActionResult Alterar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                return RedirectToAction("Index");
            }
            return View("Editar", contato) ;
           
        }
    }
}
