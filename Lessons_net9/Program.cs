using System.Diagnostics;

namespace Lessons_net9;

internal static class Program 
{
    private static IEnumerable<int> GetNumbersWithTimer(TimeSpan timeout)
    {
        var stopwatch = Stopwatch.StartNew();

        for (int i = 0;; i++)
        {
            if (stopwatch.Elapsed >= timeout)
            {
                Console.WriteLine("Timeout reached. Stopping iteration...");
                yield break;
            }
            yield return i;
        }
    }
    
    private static void Main()
    {
        foreach (var number in GetNumbersWithTimer(TimeSpan.FromSeconds(3)))
        {
            Console.WriteLine(number);
        }
    }
}
