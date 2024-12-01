using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;
using WorkflowDinamico.Domain.Services;

namespace WorkflowDinamico.App.Resolvers
{
    public class AlunoReservaResolver : IAlunoReservaResolver
    {
        private readonly IServiceProvider _serviceProvider;

        public AlunoReservaResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IGeracaoAlunoReservaDaTurma GetService(EnumTipoEvento tipoEvento)
        {
            return tipoEvento switch
            {
                EnumTipoEvento.Padrao => _serviceProvider.GetRequiredService<GerarReservaTurmaService>(),
                EnumTipoEvento.Saeb => _serviceProvider.GetRequiredService<GerarReservaTurmaEspecialService>(),
                EnumTipoEvento.Alfabetiza => _serviceProvider.GetRequiredService<GerarReservaTurmaService>(),
                _ => throw new ArgumentException("Tipo inválido fornecido.")
            };
        }
    }
}
