using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarCDLStep : IPipelineStep
    {
        IEnvelopeProvaResolver _EnvelopeProvaResolver;
        IGeraCDLService _GeraCDLService;

        public GerarCDLStep(IEnvelopeProvaResolver envelopeProvaResolver, IGeraCDLService geraCDLService)
        {
            _EnvelopeProvaResolver = envelopeProvaResolver;
            _GeraCDLService = geraCDLService;
        }

        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando CDL...");

            _GeraCDLService.GerarCDL();

            context.Data["TurmaGerada"] = true;
            await next();
        }
    }
}
