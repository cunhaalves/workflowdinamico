using WorkflowDinamico.App.Factorys;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Enums;

namespace WorkflowDinamico.App.Services
{
    public class GeracaoMaterialAppService
    {
        private readonly PipelineGeracaoMaterialFactory _pipelineFactory;

        public GeracaoMaterialAppService(PipelineGeracaoMaterialFactory pipelineFactory)
        {
            _pipelineFactory = pipelineFactory;
        }

        public async Task ExecuteFluxoAsync(EnumTipoEvento tipoEvento)
        {
            var context = new PipelineContext { TipoEvento = tipoEvento };
            var pipelineGeracaoMaterial = _pipelineFactory.Create(tipoEvento);
            await pipelineGeracaoMaterial.ExecuteAsync(context);
        }
    }
}
