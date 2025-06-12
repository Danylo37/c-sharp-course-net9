namespace Lessons_net9;

class Player
{
    public void Fire(Weapon weapon)
    {
        weapon.Fire();
    }

    public void CheckInfo(Weapon weapon)
    {
        weapon.ShowInfo();
    }
}

abstract class Weapon
{
    public abstract int Damage { get; }
    public abstract void Fire();

    public void ShowInfo()
    {
        Console.WriteLine($"{GetType().Name} Damage: {Damage}");
    }
}

class Gun : Weapon
{
    public override int Damage => 10;
    public override void Fire()
    {
        Console.WriteLine("Pew pew");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player p = new Player();

        Weapon[] inventory = { new Gun() };

        foreach (var item in inventory)
        {
            p.CheckInfo(item);
            p.Fire(item);
            Console.WriteLine();
        }
    }
}
