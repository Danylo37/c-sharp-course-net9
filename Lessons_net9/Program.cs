namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        string str = null;
        
        string result = str ?? "Null value";
        
        Console.WriteLine($"str is: {str}");
        Console.WriteLine($"Result is: {result}");

        string str2 = null;
        // string str2 = "Not null value";

        str2 ??= "Null value";
        
        Console.WriteLine(str2);

        int[] array = null;

        Console.WriteLine("Sum: " + (array?.Sum() ?? 0));
    }
}
