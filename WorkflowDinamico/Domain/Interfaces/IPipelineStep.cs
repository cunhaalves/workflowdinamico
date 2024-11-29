namespace WorkflowDinamico.Domain.Interfaces
{
    public interface IPipelineStep
    {
        Task ExecuteAsync(PipelineContext context, Func<Task> next);
    }
}
