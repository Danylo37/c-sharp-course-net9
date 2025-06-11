namespace Lessons_net9;

class Program
{
    enum DayOfWeek : byte
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static DayOfWeek GetNextDay(DayOfWeek day)
    {
        if (day < DayOfWeek.Sunday)
        {
            return day + 1;
        }

        return DayOfWeek.Monday;
    }

    static void Main(string[] args)
    {
        var mon = DayOfWeek.Monday;

        Console.WriteLine(mon);
        Console.WriteLine((DayOfWeek)1);
        Console.WriteLine((int)mon);
        Console.WriteLine(mon.GetType());
        Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));

        Console.WriteLine(GetNextDay(mon));

        DayOfWeek day;
        byte value = 55;

        // if (Enum.IsDefined(typeof(DayOfWeek), value))
        // {
        //     day = (DayOfWeek)value;
        // }
        // else
        // {
        //     throw new Exception("Invalid DayOfWeek value");
        // }

        var values = Enum.GetValues(typeof(DayOfWeek));

        Console.WriteLine();

        foreach (DayOfWeek dayOfWeek in values)
        {
            Console.WriteLine(dayOfWeek);
        }

        string str = Console.ReadLine();
        DayOfWeek d = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase: true);
        Console.WriteLine(d);
    }
}
