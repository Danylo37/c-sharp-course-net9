namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix =
        {
            {132, 24, 3},
            {4, 532, 63},
            {721, 82, 912}
        };

        foreach (var item in matrix)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(" \t0\t1\t2");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            Console.Write($"{row}\t");
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Dimensions: " + matrix.Rank);
        Console.WriteLine("Length: " + matrix.Length);
    }
}
