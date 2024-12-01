using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarMaloteStep : IPipelineStep
    {
        IMaloteResolver _maloteResolver;

        public GerarMaloteStep(IMaloteResolver maloteResolver)
        {
            _maloteResolver = maloteResolver;
        }

        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Malote...");

            var gerarMalote = _maloteResolver.GetService(context.TipoEvento);
            gerarMalote.GerarMalote();
            
            context.Data["TurmaGerada"] = true;
            await next();
        }
    }
}
