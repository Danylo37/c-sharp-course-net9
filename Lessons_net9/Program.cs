namespace Lessons_net9;

class Program
{
    /// <summary>
    /// Returns the sum of two integers 
    /// </summary>
    /// <param name="a">first value</param>
    /// <param name="b">second value</param>
    /// <returns>sum of a and b</returns>
    static int Sum(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Returns the sum of three integers  
    /// </summary>
    /// <param name="a">first value</param>
    /// <param name="b">second value</param>
    /// <param name="c">third value</param>
    /// <returns>sum of a, b and c</returns>
    static int Sum(int a, int b, int c)
    {
        return a + b + c;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(10, 20));
        Console.WriteLine(Sum(10, 20, 30));
    }
}
