namespace Lessons_net9;
using Lesson_MyExtensions;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentDateTime = DateTime.Now;

        currentDateTime.Print();
        Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Monday));
        Console.WriteLine(currentDateTime.IsDayOfWeek(DayOfWeek.Wednesday));
    }
}
