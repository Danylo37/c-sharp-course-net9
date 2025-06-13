namespace Lessons_net9;

interface IPrintable
{
    void Print();
}

struct Point : IPrintable
{
    public int X { get; set; }
    public int Y { get; set; }
    
    public void Print()
    {
        Console.WriteLine($"X: {X}\tY: {Y}");
    }
}

internal static class Program
{
    private static void Test(IPrintable printable)
    {
        printable.Print();
    }
    
    private static void Main()
    {
        int a = 1;
        a.GetType();        // boxing
        object b = a;       // boxing
        int c = (int)b;     // unboxing
        
        Test(new Point());  // boxing
    }
}
