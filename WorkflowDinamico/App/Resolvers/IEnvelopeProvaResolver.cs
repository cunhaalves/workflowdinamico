using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Resolvers
{
    public interface IEnvelopeProvaResolver
    {
        IGeraEnvelopeProvaService GetService(EnumTipoEvento tipoEvento);
    }
}
