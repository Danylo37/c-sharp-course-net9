using System.Diagnostics;

namespace Lessons_net9;

class Program
{
    static int Sum(params int[] numbers)
    {
        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }

        return sum;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(3, 7));
        Console.WriteLine(Sum(5, 7, 3));
        Console.WriteLine(Sum(5, 7, 12, 11));
    }
}
