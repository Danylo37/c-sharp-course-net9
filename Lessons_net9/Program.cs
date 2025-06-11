namespace Lessons_net9;

class Program
{
    private string test1;
    private string test2;
    private string test3;

    public Program(string test1, string test2)
    {
        this.test1 = test1;
        this.test2 = test2;
    }

    public Program(string test1, string test2, string test3) : this(test1, test2)
    {
        this.test3 = test3;
    }

    static void Main(string[] args)
    {
        var p1 = new Program("test1", "test2");
        var p2 = new Program("test1", "test2", "test3");
    }
}
