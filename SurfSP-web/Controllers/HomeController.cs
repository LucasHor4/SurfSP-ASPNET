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
            /* List<Praias> listaDePraias = new List<Praias>
            {
                new Praias(1,"Teste","tettttttttt","~/Imagens/uba.png")
            }; */
            var Praias = new Praias
            {
                idPraia = 4,
                nomePraia = "string.Empty",
                descricaoPraia = "string.Empty",
                imgPraia = "string.Empty",
            };



            return View();
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
