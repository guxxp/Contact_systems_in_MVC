using Contact_systems_in_MVC.Models;
using Contact_systems_in_MVC.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace Contact_systems_in_MVC.Controllers
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
            var contato = _contatoRepositorio.BuscarContatos();
            return View(contato);
        }
        public IActionResult CriarContato()
        {
            return View();
        }
        public IActionResult EditarContato(int id)
        {
           ContatoModel contato = _contatoRepositorio.ProcurarContatoPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ProcurarContatoPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar (ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");

        }
        public IActionResult Alterar (ContatoModel contato)
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");

        }
    }
}
