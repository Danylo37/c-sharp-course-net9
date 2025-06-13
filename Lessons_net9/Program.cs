namespace Lessons_net9;

internal static class Program 
{
    private static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        
        var result = numbers.Where(num => num % 2 == 0);

        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
}
