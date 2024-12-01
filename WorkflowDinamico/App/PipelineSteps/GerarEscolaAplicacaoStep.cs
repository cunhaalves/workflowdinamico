using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarEscolaAplicacaoStep : IPipelineStep
    {
        private IGeraEscolaAplicacaoService _geraEscolaAplicacaoService;
        public GerarEscolaAplicacaoStep(IGeraEscolaAplicacaoService geraEscolaAplicacaoService)
        {
            _geraEscolaAplicacaoService = geraEscolaAplicacaoService;
        }

        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Escola...");

            _geraEscolaAplicacaoService.GerarEscolaAplicacao();

            context.Data["EscolaGerada"] = true;
            await next();
        }
    }
}
