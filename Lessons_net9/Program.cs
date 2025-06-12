namespace Lessons_net9;

interface IDataProvider
{
    string GetData();
}

interface IDataProcessor
{
    void ProcessData(IDataProvider dataProvider);
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dataProvider)
    {
        Console.WriteLine(dataProvider.GetData());
    }
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from DB";
    }
}

class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from File";
    }
}

class ApiDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Data from API";
    }
}

internal static class Program
{
    private static void Main()
    {
        IDataProcessor dataProcessor = new ConsoleDataProcessor();

        dataProcessor.ProcessData(new DbDataProvider());
        dataProcessor.ProcessData(new FileDataProvider());
        dataProcessor.ProcessData(new ApiDataProvider());
    }
}
