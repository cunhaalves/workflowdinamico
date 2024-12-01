using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarPoloAplicacaoSaebStep : IPipelineStep
    {
        private IGeraPoloAplicacaoService _service;
        public GerarPoloAplicacaoSaebStep(IGeraPoloAplicacaoService geraPoloAplicacaoService)
        {
            _service = geraPoloAplicacaoService;
        }
        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Polo Saeb...");

            //Outra necessidade dessa geração do SAEB

            _service.GerarPoloAplicacao();

            context.Data["PoloGerado"] = true;
            await next();
        }
    }
}
