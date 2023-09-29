using Microsoft.Extensions.Logging;

namespace NotionSDK.logging;

internal static class Log
{
    internal static ILogger Logger;

    internal static void Trace(string message, params object[] args)
    {
        Logger?.LogTrace(message, args);
    }

    internal static void Information(string message, params object[] args)
    {
        Logger?.LogInformation(message, args);
    }

    internal static void Error(Exception ex, string message, params object[] args)
    {
        Logger?.LogError(ex, message, args);
    }
}