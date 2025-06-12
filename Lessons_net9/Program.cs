namespace Lessons_net9;

class Car
{
    protected void StartEngine()
    {
        Console.WriteLine("Starting engine");
    }

    public virtual void Drive()
    {
        StartEngine();
        Console.WriteLine("Driving");
    }
}

class SportCar : Car
{
    public override void Drive()
    {
        StartEngine();
        Console.WriteLine("Driving fast");
    }
}

class Person
{
    public void Drive(Car car)
    {
        car.Drive();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        person.Drive(new SportCar());
    }
}
