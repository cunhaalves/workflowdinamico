using WorkflowDinamico.App.Factorys;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.App.Services
{
    public class FluxoAppService
    {
        private readonly PipelineFactory _pipelineFactory;

        public FluxoAppService(PipelineFactory pipelineFactory)
        {
            _pipelineFactory = pipelineFactory;
        }

        public async Task ExecuteFluxoAsync(EnumTipoEvento tipoEvento)
        {
            var context = new PipelineContext { TipoEvento = tipoEvento };
            var pipeline = _pipelineFactory.Create(tipoEvento);
            await pipeline.ExecuteAsync(context);
        }
    }
}
