using Microsoft.AspNetCore.Mvc;
using SurfSP_web.Models;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

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
            Praias praiaGuaruja = new Praias()
            {
                idPraia = 2,
                nomePraia = "Guaruja",
                descricaoPraia = "Um destino imperdível para surfistas de todos os níveis é Praia Grande, em Ubatuba." +
                       "É reconhecido por suas ondas consistentes e acessíveis. É uma excelente área para surfe," +
                       "principalmente de setembro a fevereiro, quando as ondas são mais suaves e ideais para " +
                    "iniciantes e intermediários.  Além de ser um local popular para o surf, a Praia Grande também " +
                    "é conhecida por sua atmosfera animada e paisagens de tirar o fôlego, o que a torna uma das praias " +
                    "mais populares de Ubatuba. Ideal para exercícios como caminhadas e corridas na areia, é também um ótimo " +
                    "lugar para desfrutar e admirar o sol.",
                imgPraia = "~/Imagens/uba.png"
            };
            return View(praiaGuaruja);
        }
        [HttpPost]
        public IActionResult Praias()
        { 
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
