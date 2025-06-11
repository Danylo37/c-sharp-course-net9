namespace Lessons_net9;

static class StaticClass
{
    private static string variable;

    static StaticClass()
    {
        Console.WriteLine("Static constructor");
    }

    public static void Foo()
    {
        Console.WriteLine("Foo");
    }

    public static string Variable
    {
        get
        {
            return variable;
        }
        set
        {
            variable = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        StaticClass.Foo();

        StaticClass.Variable = "Hello World!";

        Console.WriteLine(StaticClass.Variable);
    }
}
