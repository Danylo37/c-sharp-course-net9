namespace Lessons_net9;

class Program
{
    static void Resize(ref int[] arr, int newLength)
    {
        int[] newArr = new int[newLength];
        
        int itemsToAdd = newLength < arr.Length ? newLength : arr.Length;
        
        for (int i = 0; i < itemsToAdd; i++)
        {
            newArr[i] = arr[i];
        }
        
        arr = newArr;
    }
    
    static void Main(string[] args)
    {
        int[] arr = { 6, 23, 534, 22, 76, 12, 55, 123, 37, 88 };
        Resize(ref arr, 6);

        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
