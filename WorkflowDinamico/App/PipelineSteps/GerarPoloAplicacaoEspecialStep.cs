using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarPoloAplicacaoEspecialStep : IPipelineStep
    {
        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Polo Especial...");
            context.Data["PoloGerado"] = true;
            await next();
        }
    }
}
