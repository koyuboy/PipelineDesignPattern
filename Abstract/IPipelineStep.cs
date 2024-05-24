namespace PipelineDesignPattern.Abstract;

public interface IPipelineStep
{
    //IPipelineStep NextStep { get; set; }
    //void Next(TState state);
    void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState);
}