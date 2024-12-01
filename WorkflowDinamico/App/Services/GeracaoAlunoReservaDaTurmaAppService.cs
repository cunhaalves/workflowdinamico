using WorkflowDinamico.App.Resolvers;
using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.App.Services
{
    public class GeracaoAlunoReservaDaTurmaAppService
    {
        private IAlunoReservaResolver _alunoReservaResolver;
        public GeracaoAlunoReservaDaTurmaAppService(IAlunoReservaResolver alunoReservaResolver)
        {
            _alunoReservaResolver = alunoReservaResolver;
        }
        public async Task Gerar(EnumTipoEvento tipoEvento)
        {
            var gerarAlunoReserva = _alunoReservaResolver.GetService(tipoEvento);
            gerarAlunoReserva.GerarReserva();
        }
    }
}
