using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Resolvers
{
    public interface IMaloteResolver
    {
        IGeraMaloteService GetService(EnumTipoEvento tipoEvento);
    }
}
