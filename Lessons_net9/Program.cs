namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Index lastIdx = new Index(1, true);
        // Index lastIdx = ^1;

        Console.WriteLine($"value: {lastIdx.Value}, isFromEnd: {lastIdx.IsFromEnd}");

        Console.WriteLine(arr[lastIdx]);

        // Range range = new Range(^4, ^1);
        // Range range = ^4..^1;

        int[] arr2 = arr[..4].Reverse().ToArray();
        // int[] arr2 = arr[1..4].Reverse().ToArray();
        // int[] arr2 = arr[1..].Reverse().ToArray();

        foreach (int i in arr2)
        {
            Console.Write(i + " ");
        }
    }
}
