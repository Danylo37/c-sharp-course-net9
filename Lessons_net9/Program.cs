namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        var t = new Test(test: "test");

        t.PrintTest();
    }
}

partial class Test
{
    public string test;

    public Test(string test)
    {
        this.test = test;
    }
}

partial class Test
{
    public void PrintTest()
    {
        Console.WriteLine(test);
    }
}
