using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline.PipelineSteps;

public class RemoveWhiteSpaces : IPipelineStep
{//" te xt " => "text"
    public void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var state = pipelineState as FormatTextPipelineState;

        state.Text = state.Text.Replace(" ", string.Empty);
    }
}