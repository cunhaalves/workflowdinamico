using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarEscolaAplicacaoStep : IPipelineStep
    {
        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Escola...");
            context.Data["EscolaGerada"] = true;
            await next();
        }
    }
}
