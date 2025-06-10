using System.Diagnostics;

namespace Lessons_net9;

class Program
{
    struct MyStruct
    {
        public decimal a;
        public decimal b;
        public decimal c;
        public decimal d;
        public decimal e;
        public decimal f;
    }

    static void Foo(MyStruct value)
    {
        
    }

    static void Bar(in MyStruct value)
    {
        // value.a = 5;     // error, value is read-only
    }
    
    static void Main(string[] args)
    {
        MyStruct a = new MyStruct();

        Stopwatch sw = Stopwatch.StartNew();
        
        for (int i = 0; i < int.MaxValue; i++)
        {
            Foo(a);
        }
        
        sw.Stop();
        Console.WriteLine("Foo: " + sw.ElapsedMilliseconds + " milliseconds");  // Foo: 6199 milliseconds
        
        sw.Restart();
        
        for (int i = 0; i < int.MaxValue; i++)
        {
            Bar(a);
        }
        
        sw.Stop();
        Console.WriteLine("Bar: " + sw.ElapsedMilliseconds + " milliseconds");  // Bar: 3817 milliseconds
    }
}
