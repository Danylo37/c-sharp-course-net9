namespace Lessons_net9;

class Program
{
    static Program()
    {
        Console.WriteLine("Static constructor");
    }

    public Program()
    {
        Console.WriteLine("Constructor");
    }

    static void Foo()
    {
        Console.WriteLine("Foo");
    }
    
    static void Main(string[] args)
    {
        Foo();

        new Program();
        new Program();
        new Program();
    }
}
