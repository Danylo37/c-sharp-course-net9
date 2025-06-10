namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        int.TryParse(input, out int number);
        
        Console.WriteLine(number);
    }
}
