using Microsoft.Extensions.Logging;
using PipelineDesignPattern.Abstract;
using PipelineDesignPattern.Pipelines.FormatTextPipeline;

namespace PipelineDesignPattern.Concrete;

public class Pipeline
{
    private List<IPipelineStep> _steps = new();

    //TODO: Rollback senaryosu düşün. Async yapılabilir

    public Pipeline AddStep(IPipelineStep step)
    {
        _steps.Add(step);
        return this;
    }

    public void ExecutePipeline(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var context = pipelineContext as FormatTextPipelineContext;
        var state = pipelineState as FormatTextPipelineState;

        context.Logger.LogInformation("Format Text Pipeline started!");
        //TODO: log, handling vs.

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Before formatting => {0}", state.Text);
        Console.ResetColor();

        foreach (var step in _steps)
        {
            context.Logger.LogWarning("{StepName} Step is running!", step.GetType().Name);

            step.Execute(pipelineContext, pipelineState);

            context.Logger.LogWarning("{StepName} Step finished!", step.GetType().Name);
        }
    }
}