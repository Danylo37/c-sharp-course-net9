namespace Lessons_net9;

internal interface IFirstInterface
{
    void Action();
}

internal interface ISecondInterface
{
    void Action();
}

public class MyClass : IFirstInterface, ISecondInterface
{
    public void Action()
    {
        Console.WriteLine("MyClass Action");
    }
}

public class MyOtherClass : IFirstInterface, ISecondInterface
{
    void IFirstInterface.Action()
    {
        Console.WriteLine("MyOtherClass IFirstInterface Action");
    }

    void ISecondInterface.Action()
    {
        Console.WriteLine("MyOtherClass ISecondInterface Action");
    }
}

internal static class Program
{
    private static void Foo(IFirstInterface firstInterface)
    {
        firstInterface.Action();
    }

    private static void Bar(ISecondInterface secondInterface)
    {
        secondInterface.Action();
    }

    private static void Main()
    {
        MyClass myClass = new MyClass();
        myClass.Action();

        Foo(myClass);
        Bar(myClass);

        Console.WriteLine();
        
        MyOtherClass myOtherClass = new MyOtherClass();
        // myOtherClass.Action();   // error

        Foo(myOtherClass);
        Bar(myOtherClass);

        Console.WriteLine();
        
        ((IFirstInterface)myOtherClass).Action();
        ((ISecondInterface)myOtherClass).Action();
        
        Console.WriteLine();
        
        object obj = new object();

        if (obj is IFirstInterface iFirstInterface)
        {
            Foo(iFirstInterface);
        }
        
        if (myOtherClass is IFirstInterface iFirstInterface1)
        {
            Foo(iFirstInterface1);
        }
    }
}
