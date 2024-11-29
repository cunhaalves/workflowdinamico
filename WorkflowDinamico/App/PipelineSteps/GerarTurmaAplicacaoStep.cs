using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarTurmaAplicacaoStep : IPipelineStep
    {

        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Turma...");
            context.Data["TurmaGerada"] = true;
            await next();
        }
    }
}
