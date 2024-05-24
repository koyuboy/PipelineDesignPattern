using Microsoft.Extensions.Logging;
using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline;

public class FormatTextPipeline : Pipeline
{
    public override void ExecutePipeline(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var context = pipelineContext as FormatTextPipelineContext;
        var state = pipelineState as FormatTextPipelineState;

        context.Logger.LogInformation("Pipeline started!");

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