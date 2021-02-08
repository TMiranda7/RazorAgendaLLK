using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WEB_agendaLanlink.Models;
using WEB_agendaLanlink.Repositories.Contractors;

namespace WEB_agendaLanlink.Controllers
{
    public class HomeController : Controller
    {
        public readonly IPessoaRepository pessoaRepository;
        public readonly IEnderecoRepository enderecoRepository;

        public HomeController(IPessoaRepository _pessoaRepository, IEnderecoRepository _enderecoRepository)
        {
            this.pessoaRepository = _pessoaRepository;
            this.enderecoRepository = _enderecoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contato()
        {
            return View(pessoaRepository.ObterTodos());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
