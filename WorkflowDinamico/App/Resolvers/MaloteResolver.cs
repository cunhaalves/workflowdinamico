using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

namespace WorkflowDinamico.App.Resolvers
{
    public class MaloteResolver : IMaloteResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public MaloteResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IGeraMaloteService GetService(EnumTipoEvento tipoEvento)
        {
            return tipoEvento switch
            {
                EnumTipoEvento.Padrao => _serviceProvider.GetRequiredService<GeraMaloteService>(),
                EnumTipoEvento.Saeb => _serviceProvider.GetRequiredService<GeraMaloteService>(),
                EnumTipoEvento.Alfabetiza => _serviceProvider.GetRequiredService<GeraMaloteAlfabetizaService>(),
                _ => throw new ArgumentException("Tipo inválido fornecido.")
            };
        }
    }
}
