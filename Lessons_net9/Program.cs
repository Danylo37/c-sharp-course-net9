namespace Lessons_net9;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ConsoleKey key = Console.ReadKey().Key;
            
            int keyCode = (int)key;
            
            Console.WriteLine($"\tEnum: {key}\tKey Code: {keyCode}");

            if (key == ConsoleKey.Enter)
            {
                Console.WriteLine("You pressed Enter.");
            }

            if (key == ConsoleKey.Q)
            {
                break;
            }
        }
    }
}
