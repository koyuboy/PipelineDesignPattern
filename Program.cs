using PipelineDesignPattern.Concrete;
using PipelineDesignPattern.Pipelines.FormatTextPipeline;
using PipelineDesignPattern.Pipelines.FormatTextPipeline.PipelineSteps;



var formatTextPipeline = new Pipeline();
formatTextPipeline.AddStep(new RemoveWhiteSpaces())
    .AddStep(new SplitTextByComma())
    .AddStep(new CapitalizeInitialLetters())
    .AddStep(new WriteToConsole());


var formatTextPipelineContext = new FormatTextPipelineContext();
var formatTextPipelineState = new FormatTextPipelineState("   heLl o, FRIEND, ho   W  , a  r e, you");

formatTextPipeline.ExecutePipeline(formatTextPipelineContext, formatTextPipelineState);