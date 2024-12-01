using WorkflowDinamico.App.Pipelines;
using WorkflowDinamico.App.PipelineSteps;
using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Factorys
{
    public class PipelineGeracaoMaterialFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public PipelineGeracaoMaterialFactory(IServiceProvider serviceProvider)
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
                    _serviceProvider.GetService<GerarEnvelopeProvaStep>(),
                    _serviceProvider.GetService<GerarMaloteStep>(),
                    _serviceProvider.GetService<GerarCDLStep>(),

            },
                EnumTipoEvento.Saeb => new List<IPipelineStep>
            {
                _serviceProvider.GetService<GerarPoloAplicacaoSaebStep>(),
                _serviceProvider.GetService<GerarEscolaAplicacaoStep>(),
                _serviceProvider.GetService<GerarTurmaAplicacaoStep>(),
                _serviceProvider.GetService<GerarEnvelopeProvaStep>(),
                _serviceProvider.GetService<GerarMaloteStep>(),
                _serviceProvider.GetService<GerarCDLStep>()
            },
                EnumTipoEvento.Alfabetiza => new List<IPipelineStep>
            {
                _serviceProvider.GetService<GerarPoloAplicacaoStep>(),
                _serviceProvider.GetService<GerarEscolaAplicacaoStep>(),
                _serviceProvider.GetService<GerarTurmaAplicacaoStep>(),
                _serviceProvider.GetService<GerarEnvelopeProvaStep>(),
                _serviceProvider.GetService<GerarMaloteStep>(),
            },
                _ => throw new ArgumentException("Tipo de fluxo inválido.")
            };

            return new Pipeline(steps, tipoEvento);
        }
    }

}
