using Microsoft.AspNetCore.Mvc;
using WorkflowDinamico.App.Services;
using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.Controllers
{

    public class FluxoController : Controller
    {
        private readonly FluxoAppService _fluxoAppService;
        public FluxoController(FluxoAppService fluxoAppService)
        {
            _fluxoAppService = fluxoAppService;
        }

        [HttpPost("api/start-fluxo")]
        public async Task<IActionResult> StartWorkflow()
        {
            await _fluxoAppService.ExecuteFluxoAsync(EnumTipoEvento.Saeb);

            return Ok("Workflow executado com sucesso.");
        }
    }
}
