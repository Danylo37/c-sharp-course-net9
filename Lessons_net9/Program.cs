namespace Lessons_net9;

class Point2D
{
    public Point2D(int x, int y)
    {
        Console.WriteLine("Point2D constructor");

        X = x;
        Y = y;
    }

    public int X { get; set; }
    public int Y { get; set; }

    public void Print()
    {
        Console.WriteLine("X:\t" + X);
        Console.WriteLine("Y:\t" + Y);
    }
}

class Point3D : Point2D
{
    public Point3D(int x, int y, int z) : base(x,y)
    {
        Console.WriteLine("Point3D constructor without name");

        Z = z;
    }

    public Point3D(int x, int y, int z, string name) : this(x, y, z)
    {
        Console.WriteLine("Point3D constructor with name");

        Name = name;
    }

    public string Name { get; set; }

    public int Z { get; set; }

    public void Print()
    {
        Console.WriteLine("Name:\t" + (Name ?? "Unknown"));
        base.Print();
        Console.WriteLine("Z:\t" + Z);
    }
}

class Program
{
    static void Main(string[] args)
    {
        object obj = new Point3D(1, 2, 3);

        Point3D point = (Point3D)obj;

        point.Print();

        Console.WriteLine();

        // obj = "string";
        Point2D point2 = obj as Point2D;

        if (point2 != null)
        {
            point2.Print();
        }

        Console.WriteLine();

        if (obj is Point2D)
        {
            Point2D point3 = (Point2D)obj;
            point3.Print();
        }

        Console.WriteLine();

        if (obj is Point2D point4)
        {
            point4.Print();
        }
    }
}
