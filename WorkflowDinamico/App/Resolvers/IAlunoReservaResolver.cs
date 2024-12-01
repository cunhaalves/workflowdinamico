using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Resolvers
{
    public interface IAlunoReservaResolver
    {
        IGeracaoAlunoReservaDaTurma GetService(EnumTipoEvento tipoEvento);
    }
}
