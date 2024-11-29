using WorkflowDinamico.App.Factorys;
using WorkflowDinamico.Domain;
using WorkflowDinamico.Domain.Enums;
using WorkflowDinamico.Domain.Interfaces;

namespace WorkflowDinamico.App.Pipelines
{
    public class Pipeline
    {
        private readonly List<IPipelineStep> _steps;
        private readonly EnumTipoEvento _tipoEvento;

        public Pipeline(IEnumerable<IPipelineStep> stepTypes, EnumTipoEvento tipoEvento)
        {
            _steps = stepTypes.ToList();
            _tipoEvento = tipoEvento;
        }

        public async Task ExecuteAsync(PipelineContext context)
        {
            async Task ExecuteStep(int index)
            {
                if (index < _steps.Count)
                {
                    var step = _steps[index]; 
                    await step.ExecuteAsync(context, () => ExecuteStep(index + 1));
                }
            }

            await ExecuteStep(0);
        }
    }
}
