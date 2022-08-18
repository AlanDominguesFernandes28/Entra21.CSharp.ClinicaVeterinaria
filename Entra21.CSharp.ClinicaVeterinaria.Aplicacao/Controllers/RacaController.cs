using Entra21.CSharp.ClinicaVeterinaria.Repositorio.BancoDados;
using Entra21.CSharp.ClinicaVeterinaria.Repositorio.Enuns;
using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    // Dois pontos Herança(mais para frente)
    public class RacaController : Controller
    {
        private readonly IRacaServico _racaServico;

        // Construtor: objetivo contruir o objeto de RacaController,
        // com o minimo necessario para o funcionamento correto
        public RacaController(ClinicaVeterinariaContexto contexto)
        {
            _racaServico = new RacaServico(contexto);
        }

        /// <summary>
        /// Endpoint que permite listar todas as raças
        /// </summary>
        /// <returns>Retorna a página html com as raças</returns>
        [HttpGet("/raca")]
        public IActionResult ObterTodos()
        {
            var racas = _racaServico.ObterTodos();

            //Passar informação do C# para HTML
            ViewBag.Racas = racas;

            return View("Index");
        }
        [HttpGet("/raca/cadastrar")]

        public IActionResult Cadastrar()
        {
            var especies = ObterEspecies();
            ViewBag.Especies = especies;
            return View();
        }
        [HttpPost("/raca/cadastrar")]
        public IActionResult Cadastrar(
            [FromForm] RacaCadastrarViewModel racaCadastrarViewModel)
        {

            _racaServico.Cadastrar(racaCadastrarViewModel);

            return RedirectToAction("Index");
        }
       
        [HttpGet("/raca/apagar/")]
        // https://localhost:porta/raca/apagar?id=4
        public IActionResult Apagar([FromQuery]int id)
        {
            _racaServico.Apagar(id);

            return RedirectToAction("Index");
        }
        [HttpGet("/raca/editar")]

        public  IActionResult Editar([FromForm]  RacaEditarViewModel racaEditarViewModel )
        {
            _racaServico.Editar(racaEditarViewModel);
            return RedirectToAction("Index");


            

        }
        [HttpPost("/raca/editar")]
       

        public IActionResult Editar( ///todo ver depois
            [FromForm] RacaEditarViewModel racaEditarViewModel)
        {
            _racaServico.Editar(racaEditarViewModel);

            return RedirectToAction("Index");
        }

        private static List<string> ObterEspecies()
        {
            return Enum.GetNames<Especie>().OrderBy(x => x).ToList();
        }
    }
}
