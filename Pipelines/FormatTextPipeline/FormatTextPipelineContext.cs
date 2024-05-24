using Microsoft.Extensions.Logging;
using PipelineDesignPattern.Abstract;

namespace PipelineDesignPattern.Pipelines.FormatTextPipeline;

public class FormatTextPipelineContext : IPipelineContext
{
    public ILogger<FormatTextPipelineContext> Logger { get; set; }

    public FormatTextPipelineContext()
    {
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsoleFormatter<CustomConsoleFormatter, CustomConsoleFormatterOptions>()
                .AddConsole(options =>
                {
                    options.FormatterName = nameof(CustomConsoleFormatter);
                });
        });
        Logger = loggerFactory.CreateLogger<FormatTextPipelineContext>();
    }
}