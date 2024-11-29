using WorkflowDinamico.App.Pipelines;
using WorkflowDinamico.App.PipelineSteps;
using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Factorys
{
    public class PipelineFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PipelineFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public Pipeline Create(EnumTipoEvento tipoEvento)
        {
            var steps = tipoEvento switch
            {
                EnumTipoEvento.Padrao => new List<IPipelineStep>
            {
                    _serviceProvider.GetService<GerarPoloAplicacaoStep>(),
                    _serviceProvider.GetService<GerarEscolaAplicacaoStep>(),
                    _serviceProvider.GetService<GerarTurmaAplicacaoStep>(),
                    _serviceProvider.GetService<GerarEnvelopeProvaStep>()

            },
                EnumTipoEvento.Saeb => new List<IPipelineStep>
            {
                _serviceProvider.GetService<GerarPoloAplicacaoEspecialStep>(),
                _serviceProvider.GetService<GerarEscolaAplicacaoStep>(),
                _serviceProvider.GetService<GerarTurmaAplicacaoStep>(),
                _serviceProvider.GetService<GerarEnvelopeProvaStep>()
            },
                EnumTipoEvento.Alfabetiza => new List<IPipelineStep>
            {
                _serviceProvider.GetService<GerarPoloAplicacaoEspecialStep>(),
                _serviceProvider.GetService<GerarEscolaAplicacaoStep>(),
                _serviceProvider.GetService<GerarTurmaAplicacaoStep>(),
                _serviceProvider.GetService<GerarEnvelopeProvaStep>()
            },
                _ => throw new ArgumentException("Tipo de fluxo inválido.")
            };

            return new Pipeline(steps, tipoEvento);
        }
    }

}
