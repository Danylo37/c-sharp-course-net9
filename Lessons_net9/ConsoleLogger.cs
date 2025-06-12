namespace Lessons_net9;

public class ConsoleLogger : ILogger
{
    public void Log(LogLevel logLevel, string message)
    {
        Console.ForegroundColor = logLevel switch
        {
            LogLevel.Debug => ConsoleColor.Green,
            LogLevel.Info => ConsoleColor.Blue,
            LogLevel.Warning => ConsoleColor.Yellow,
            LogLevel.Error or LogLevel.Fatal => ConsoleColor.Red,
            _ => throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null)
        };
        Console.WriteLine($"{DateTime.Now}: {message}");
        Console.ResetColor();
    }
}