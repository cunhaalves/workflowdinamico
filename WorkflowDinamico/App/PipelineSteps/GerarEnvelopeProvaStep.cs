using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.PipelineSteps
{
    public class GerarEnvelopeProvaStep : IPipelineStep
    {
        IEnvelopeProvaResolver _EnvelopeProvaResolver;

        public GerarEnvelopeProvaStep(IEnvelopeProvaResolver envelopeProvaResolver)
        {
            _EnvelopeProvaResolver = envelopeProvaResolver;
        }

        public async Task ExecuteAsync(PipelineContext context, Func<Task> next)
        {
            Console.WriteLine("Gerando Envelope Prova...");

            var gerarEnvelopeProva = _EnvelopeProvaResolver.GetService(context.TipoEvento);
            gerarEnvelopeProva.GeraEnvelopeProva();
            
            context.Data["TurmaGerada"] = true;
            await next();
        }
    }
}
