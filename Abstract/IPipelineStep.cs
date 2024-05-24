namespace PipelineDesignPattern.Abstract;

public interface IPipelineStep
{
    void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState);
}