using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline.PipelineSteps;

public class SplitTextByComma : IPipelineStep
{//"text1,text2" => ["text1", "text2"]
    public void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var state = pipelineState as FormatTextPipelineState;

        state.TextList = state.Text.Split(",").ToList();
    }
}