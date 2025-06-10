namespace Lessons_net9;

class Program
{
    static void PrintArray(in int[] arr, in int index = 0)
    {
        if (index < arr.Length)
        {
            Console.WriteLine(arr[index]);
            PrintArray(arr, index+1);
        }
    }

    static int Sum(in int[] arr, in int index = 0)
    {
        if (index >= arr.Length)
            return 0;
        
        return arr[index] + Sum(arr, index + 1);
    }

    static int SumNum(in int num)
    {
        if (num == 0)
            return 0;
        
        return num%10 + SumNum(num/10);
    }
    
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintArray(arr);
        
        Console.WriteLine(Sum(arr));
        Console.WriteLine(SumNum(123456789));
    }
}
