using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline.PipelineSteps;

public class WriteToConsole : IPipelineStep
{
    public void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        var state = pipelineState as FormatTextPipelineState;

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("After formatting =>");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;

        foreach (var word in state.TextList)
        {
            Console.WriteLine(word);
        }
        Console.ResetColor();
    }
}