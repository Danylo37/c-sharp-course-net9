namespace Lessons_net9;

class MyList<T>
{
    private T[] _array = Array.Empty<T>();

    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
    
    public int Count => _array.Length;

    public void Add(T value)
    {
        var newArray = new T[_array.Length + 1];

        for (int i = 0; i < _array.Length; i++)
        {
            newArray[i] = _array[i];
        }
        newArray[_array.Length] = value;
        
        _array = newArray;
    }
}

internal static class Program 
{
    private static void Main()
    {
        int a = 1, b = 5;
        Console.WriteLine($"a = {a}\tb = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a = {a}\tb = {b}\n");


        string str1 = "Hello", str2 = "World";
        Console.WriteLine($"str1 = {str1}\tstr2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"str1 = {str1}\tstr2 = {str2}\n");


        int result = Foo<int>();
        Console.WriteLine($"result = {result}\n");
        
        
        MyList<int> myList = new MyList<int>();
        myList.Add(1);
        myList.Add(2);
        Console.WriteLine(myList.Count);
        Console.WriteLine(myList[1]);
    }

    private static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }

    private static T Foo<T>()
    {
        return default(T);
    }
}
