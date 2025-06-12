namespace Lessons_net9;

class Person
{
    public Person()
    {
        Console.WriteLine("Person constructor");
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void PrintName()
    {
        Console.WriteLine(FirstName);
    }
}

class Student : Person
{
    public Student()
    {
        Console.WriteLine("Student constructor");
    }

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}


class Program
{
    static void Main(string[] args)
    {
        var st = new Student
        {
            FirstName = "John",
            LastName = "Doe"
        };

        st.PrintName();
        st.PrintFullName();
    }
}
