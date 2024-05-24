using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Concrete;

public class PipelineStep : IPipelineStep
{
    //public IPipelineStep NextStep { get; set; }
    //public void Next(TState state)
    //{
    //    throw new NotImplementedException();
    //}

    public void Execute(IPipelineContext pipelineContext, IPipelineState pipelineState)
    {
        throw new NotImplementedException();
    }
}