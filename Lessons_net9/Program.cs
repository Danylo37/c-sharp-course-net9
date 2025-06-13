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

        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}
