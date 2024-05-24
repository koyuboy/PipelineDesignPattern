using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

public class CustomConsoleFormatter : ConsoleFormatter, IDisposable
{
    private readonly IDisposable _optionsReloadToken;
    private CustomConsoleFormatterOptions _formatterOptions;

    public CustomConsoleFormatter(IOptionsMonitor<CustomConsoleFormatterOptions> options)
        : base(nameof(CustomConsoleFormatter))
    {
        _optionsReloadToken = options.OnChange(ReloadLoggerOptions);
        _formatterOptions = options.CurrentValue;
    }

    private void ReloadLoggerOptions(CustomConsoleFormatterOptions options)
    {
        _formatterOptions = options;
    }

    public void Dispose()
    {
        _optionsReloadToken?.Dispose();
    }

    public override void Write<TState>(in LogEntry<TState> logEntry, IExternalScopeProvider scopeProvider, TextWriter textWriter)
    {
        var logLevel = logEntry.LogLevel;
        var message = logEntry.Formatter(logEntry.State, logEntry.Exception);
        if (message == null)
        {
            return;
        }

        textWriter.WriteLine($"{logLevel}: {message}");
    }
}