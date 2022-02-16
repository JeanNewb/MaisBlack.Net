using MaisBlack.Data.Repositories;
using MaisBlack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaisBlack.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClienteRepository _clienteRepository;

        public HomeController(ILogger<HomeController> logger, ClienteRepository clienteRepository)
        {
            _logger = logger;
            _clienteRepository = clienteRepository;
        }

        public IActionResult Index()
        {
            var cliente = _clienteRepository.GetAll();
            return View();
        }

        public IActionResult NossosServicos()
        {
            return View();
        }

        public IActionResult QuemSomos()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contato(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}