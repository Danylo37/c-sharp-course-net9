namespace Lessons_net9;

class A
{
    public int publicField;
    private int privateField;
    protected int protectedField;
}

class B : A
{
    public B ()
    {
        publicField = 1;
        // privateField = 1;
        protectedField = 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        new A().publicField = 1;
        // new A().privateField = 1;
        // new A().protectedField = 1;
    }
}
