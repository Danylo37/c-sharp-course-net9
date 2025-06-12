namespace Lessons_net9;

internal static class Program
{
    private static void Main()
    {
        ILogger consoleLogger = new ConsoleLogger();

        consoleLogger.Log(LogLevel.Debug, "some event");
        consoleLogger.Log(LogLevel.Warning, "some warning");
        consoleLogger.Log(LogLevel.Fatal, "some fatal error");
        consoleLogger.LogError("some error");
    }
}
