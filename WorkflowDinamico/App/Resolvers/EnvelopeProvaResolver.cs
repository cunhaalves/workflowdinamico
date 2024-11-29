using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

namespace WorkflowDinamico.App.Resolvers
{
    public class EnvelopeProvaResolver : IEnvelopeProvaResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public EnvelopeProvaResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IGeraEnvelopeProvaService GetService(EnumTipoEvento tipoEvento)
        {
            return tipoEvento switch
            {
                EnumTipoEvento.Padrao => _serviceProvider.GetRequiredService<GeraEnvelopeProvaAlfabetizaService>(),
                EnumTipoEvento.Saeb => _serviceProvider.GetRequiredService<GeraEnvelopeProvaSaebService>(),
                EnumTipoEvento.Alfabetiza => _serviceProvider.GetRequiredService<GeraEnvelopeProvaAlfabetizaService>(),
                _ => throw new ArgumentException("Tipo inválido fornecido.")
            };
        }
    }
}
