using Microsoft.AspNetCore.Mvc;
using SurfSP_web.Models;
using System.Diagnostics;

namespace SurfSP_web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Praias()
        {
            List<Praias> listaDePraias = new List<Praias>
            {
                // new Praias{idPraia = 1, nomePraia = "teste", descricaoPraia = "testandooo", imgPraia = "~/Imagens/uba.png"},
                new Praias(2,"nome","desc","~/Imagens/uba.png"),
                new Praias(3,"nome","desc","~/Imagens/uba.png"),

            };

            return View(listaDePraias);
        }

		public IActionResult Ondas()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
