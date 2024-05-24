using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines;

public class Pipeline
{
    protected List<IPipelineStep> _steps = new();

    public Pipeline AddStep(IPipelineStep step)
    {
        _steps.Add(step);
        return this;
    }

    public virtual void ExecutePipeline(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        foreach (var step in _steps)
        {
            step.Execute(pipelineContext, pipelineState);
        }
    }
}