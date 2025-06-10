namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        Nullable<int> a = null;
        
        int? b = null;
        
        Console.WriteLine(a);
        
        Console.WriteLine(a == null);
        
        Console.WriteLine(a.HasValue);
        
        Console.WriteLine(a.GetValueOrDefault());
        
        Console.WriteLine(a.GetValueOrDefault(5));
        
        Console.WriteLine(a ?? 10);
        
        // Console.WriteLine(i.Value);     // InvalidOperationException
        
        Console.WriteLine((a + 5).HasValue);
        
        Console.WriteLine(a == 5);
    }
}
