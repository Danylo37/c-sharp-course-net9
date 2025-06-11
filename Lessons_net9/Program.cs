namespace Lessons_net9;

class Program
{
    // class Test
    // {
    //     public var a;    // error
    // }

    // static var Foo()     // error
    // {
    //
    // }

    // static void Foo(var a)   // error
    // {
    //
    // }

    static void Main(string[] args)
    {
        var dict = new Dictionary<int, string>();
        var anonType = new { Name = "name", Age = 0 };
        var result = from i in new[] { 1, 2, 3, 4, 5 } where i % 2 == 0 orderby i select i;
        
        Console.WriteLine(dict.GetType());
        Console.WriteLine(anonType.GetType());
        Console.WriteLine(result.GetType());
    }
}
