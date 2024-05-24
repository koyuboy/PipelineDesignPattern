using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline;

public class FormatTextPipelineState(string text) : IPipelineState
{
    public string Text { get; set; } = text;
    public List<string>? TextList { get; set; }
}