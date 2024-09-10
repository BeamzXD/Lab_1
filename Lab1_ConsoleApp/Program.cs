namespace Lab1_ConsoleApp;
public class Rectangle{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB){
        this.sideA = sideA;
        this.sideB = sideB;
    }

    private double CalculateArea(){
        return sideA * sideB;
    }

    private double CalculatePerimeter(){
        return 2 * (sideA + sideB);
    }

    public double Area{
        get { return CalculateArea(); }
    }

    public double Perimeter{
        get { return CalculatePerimeter(); }
    }
}

public class Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
}

public class Figure
{
    private Point[] points;
    public string Name { get; set; }

    public Figure(string name, params Point[] points)
    {
        this.points = points;
        Name = name;
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
        }
        return perimeter;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Задание №1");

        Console.WriteLine("Минимальные и максимальные значения для предопределенных типов данных CTS:");
        Console.WriteLine($"byte: {byte.MinValue}, {byte.MaxValue}");
        Console.WriteLine($"sbyte: {sbyte.MinValue}, {sbyte.MaxValue}");
        Console.WriteLine($"short: {short.MinValue}, {short.MaxValue}");
        Console.WriteLine($"ushort: {ushort.MinValue}, {ushort.MaxValue}");
        Console.WriteLine($"int: {int.MinValue}, {int.MaxValue}");
        Console.WriteLine($"uint: {uint.MinValue}, {uint.MaxValue}");
        Console.WriteLine($"long: {long.MinValue}, {long.MaxValue}");


        Console.WriteLine("Задание №2");

        Console.Write("Введите длину стороны A: ");
        double sideA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину стороны B: ");
        double sideB = Convert.ToDouble(Console.ReadLine());

        Rectangle rect = new Rectangle(sideA, sideB);

        Console.WriteLine($"Area: {rect.Area}");
        Console.WriteLine($"Perimeter: {rect.Perimeter}");


        Console.WriteLine("Задание №3");

        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);

        Figure triangle = new Figure("Треугольник", p1, p2, p3);
        Console.WriteLine($"Фигура: {triangle.Name}");
        Console.WriteLine($"Периметр: {triangle.PerimeterCalculator()}");
    }
}