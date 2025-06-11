namespace Lessons_net9;

class Program
{
    private string test;

    public void SetTest(string test)
    {
        this.test = test;
    }

    public string GetTest()
    {
        return test;
    }

    private string test1;

    public string Test1
    {
        get
        {
            return test1;
        }
        set
        {
            test1 = value;
        }
    }

    public string Test2 { get; set; }

    static void Main(string[] args)
    {
        var p = new Program();

        p.Test1 = "test1";

        Console.WriteLine(p.Test1);

        p.Test2 = "test2";

        Console.WriteLine(p.Test2);
    }
}
