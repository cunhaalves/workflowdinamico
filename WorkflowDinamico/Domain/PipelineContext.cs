using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.Domain
{
    public class PipelineContext
    {
        public Dictionary<string, object> Data { get; set; } = new Dictionary<string, object>();
        
        // Define qual fluxo será executado
        public EnumTipoEvento TipoEvento { get; set; } 
    }
}
