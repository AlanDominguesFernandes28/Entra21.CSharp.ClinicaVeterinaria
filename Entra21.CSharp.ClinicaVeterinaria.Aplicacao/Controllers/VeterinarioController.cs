using Entra21.CSharp.ClinicaVeterinaria.Servico;
using Entra21.CSharp.ClinicaVeterinaria.Servico.ViewModels.Veterinarios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.CSharp.ClinicaVeterinaria.Aplicacao.Controllers
{
    [Route("/veterinario")]
    public class VeterinarioController : Controller
    {
        private readonly IVeterinarioServico _veterinarioServico;

        public VeterinarioController(IVeterinarioServico veterinarioServico)
        {
            _veterinarioServico = veterinarioServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/cadastrar")]
        public IActionResult Cadastrar(VeterinarioCadastrarViewModel veterinarioCadastrarViewModel)
        {
            if (!ModelState.IsValid)
                return View(veterinarioCadastrarViewModel);

            //criar o registro chamado o serviço
            _veterinarioServico.Cadastrar(veterinarioCadastrarViewModel);

            //redirecionar para Index
            //return RedirectToAction("Index");
            return RedirectToAction(nameof(Index));
        }
    }
}
