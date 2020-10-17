using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TCC.Fernando.Especificacao4.Core;
using TCC.Fernando.Especificacao4.Core.Entidade;
using TCC.Fernando.Especificacao4.Models;

namespace TCC.Fernando.Especificacao4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string TituloFilme, string Genero, string Estudio, int? Ano)
        {
            var filmes = FilmeAplicacao.Obter().Filtrar(TituloFilme, Genero, Estudio, Ano);

            var model = new CadastroFilmeModel(filmes, TituloFilme, Genero, Estudio, Ano);

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult Salvar(string tituloFilme, string genero, string estudio, int? ano)
        {
            var filme = new Filme(tituloFilme, genero, estudio, ano ?? 0);

            FilmeAplicacao.Obter().Salvar(filme);

            return new JsonResult(true);
        }
    }
}
