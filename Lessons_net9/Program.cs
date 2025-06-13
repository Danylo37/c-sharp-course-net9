namespace Lessons_net9;

internal static class Program 
{
    private static void Main()
    {
        MyList<int> list = new MyList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        var enumerator = list.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.Write(enumerator.Current + " ");
        }
        
        Console.WriteLine();

        foreach (var number in NumberGenerator().Where(x => x % 2 == 0).Take(10))
        {
            Console.WriteLine(number);
        }
    }

    private static IEnumerable<int> NumberGenerator()
    {
        for (int i = 0;; i++)
        {
            yield return i;
        }
    }
}
