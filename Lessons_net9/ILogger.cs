namespace Lessons_net9;

public interface ILogger
{
    void Log(LogLevel logLevel, string message);

    void LogError(string message)
    {
        Log(LogLevel.Error, message);
    }
}