using Microsoft.AspNetCore.Mvc;
using WorkflowDinamico.App.Services;
using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.Controllers
{

    public class GeracaoMaterialController : Controller
    {
        private readonly GeracaoMaterialAppService _geracaoMaterialAppService;
        private readonly GeracaoAlunoReservaDaTurmaAppService _geracaoAlunoReservaAppService;

        public GeracaoMaterialController(GeracaoMaterialAppService fluxoAppService, GeracaoAlunoReservaDaTurmaAppService geracaoAlunoReservaAppService)
        {
            _geracaoMaterialAppService = fluxoAppService;
            _geracaoAlunoReservaAppService = geracaoAlunoReservaAppService;
        }

        [HttpPost("api/gerar-material")]
        public async Task<IActionResult> GerarMaterial()
        {
            await _geracaoMaterialAppService.ExecuteFluxoAsync(EnumTipoEvento.Alfabetiza);

            return Ok("Geração de material finalizada.");
        }

        [HttpPost("api/gerar-aluno-reserva")]
        public async Task<IActionResult> GerarAlunoReserva()
        {
            await _geracaoAlunoReservaAppService.Gerar(EnumTipoEvento.Saeb);

            return Ok("Aluno reserva gerado.");
        }
    }
}
