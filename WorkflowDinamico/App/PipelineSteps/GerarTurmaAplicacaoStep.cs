using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarTurmaAplicacaoStep : IPipelineStep
    {
        IGeraTurmaAplicacaoService _service;
        public GerarTurmaAplicacaoStep(IGeraTurmaAplicacaoService service)
        {
            _service = service;
        }
        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Turma...");

            _service.GerarTurmaAplicacao();

            context.Data["TurmaGerada"] = true;
            await next();
        }
    }
}
