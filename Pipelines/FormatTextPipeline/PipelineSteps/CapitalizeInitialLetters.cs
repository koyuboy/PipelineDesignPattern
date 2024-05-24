using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline.PipelineSteps;

public class CapitalizeInitialLetters : IPipelineStep
{//"text" => "Text"
    public void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var state = pipelineState as FormatTextPipelineState;

        for (int i = 0; i < state.TextList.Count; i++)
        {
            var word = state.TextList[i];
            word = word.ToLower();
            state.TextList[i] = word[0].ToString().ToUpper() + word.Substring(1);
        }
    }
}