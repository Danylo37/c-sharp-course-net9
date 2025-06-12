namespace Lessons_net9;

public interface IWeapon
{
    void Fire();
}

public interface IThrowingWeapon : IWeapon
{
    void Throw();
}

public class Gun : IWeapon 
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Pif paf");
    }
}

public class LaserGun : IWeapon
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Pew pew");
    }
}

public class Knife : IThrowingWeapon 
{
    public void Fire()
    {
        Console.WriteLine($"{GetType().Name} Shink shink");
    }

    public void Throw()
    {
        Console.WriteLine($"{GetType().Name} Pshiuuu");
    }
}

public class Player
{ 
    public void Fire(IWeapon weapon)
    {
        weapon.Fire();
    }

    public void Throw(IThrowingWeapon weapon)
    {
        weapon.Throw();
    }
}

internal static class Program
{
    private static void Main()
    {
        var p = new Player();

        IWeapon[] inventory = [new Gun(), new LaserGun(), new Knife()];

        foreach (var item in inventory)
        {
            p.Fire(item);
            Console.WriteLine();
        }
        
        p.Throw(new Knife());
    }
}
