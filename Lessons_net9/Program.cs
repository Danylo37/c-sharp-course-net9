namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        byte agression = 1;

        byte democracyModifier = 2;

        try
        {
            agression = checked((byte)(agression - democracyModifier));
            Console.WriteLine(agression);
        }
        catch (Exception)
        {
            Console.WriteLine("Arithmetic overflow");
        }

        double a = 1.0 / 0.0;
        double b = 0.0 / 0.0;
        double c = Double.MaxValue + Double.MaxValue;
        
        Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        
        Console.WriteLine("a is infinity? " + double.IsInfinity(a));
        Console.WriteLine("b is NaN? " + double.IsNaN(b));
        Console.WriteLine("c is infinity? " + double.IsInfinity(c));

        decimal x = decimal.MaxValue;
        decimal y = decimal.MaxValue;
        decimal z = unchecked(x + y);   // still error
        
        Console.WriteLine(z);
    }
}
