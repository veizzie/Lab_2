class Parallelepiped
{
    private double a;
    private double b;
    private double c;

    public double A
    {
        get { return a; }
        set
        {
            if (value > 0)
                a = value;
            else
                Console.WriteLine("Сторона повинна бути додатньою.");
        }
    }

    public double B
    {
        get { return b; }
        set
        {
            if (value > 0)
                b = value;
            else
                Console.WriteLine("Сторона повинна бути додатньою.");
        }
    }

    public double C
    {
        get { return c; }
        set
        {
            if (value > 0)
                c = value;
            else
                Console.WriteLine("Сторона c повинна бути додатньою.");
        }
    }

    public Parallelepiped()
    {
        a = 0; b = 0; c = 0;
    }

    public bool Correct()
    {
        return (a > 0 && b > 0 && c > 0);
    }

    public double Area()
    {
        if (Correct())
            return 2 * (a * b + b * c + a * c);
        else
            return -1;
    }

    public double Volume ()
    {
        if (Correct())
            return a * b * c;
        else 
            return -1;
    }

    public void Print()
    {
        Console.WriteLine($"Сторона a: {a}");
        Console.WriteLine($"Сторона b: {b}");
        Console.WriteLine($"Сторона c: {c}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        try
        {
            Parallelepiped parallelepiped = new Parallelepiped();

            Console.Write("Введіть сторону a: ");
            parallelepiped.A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть сторону b: ");
            parallelepiped.B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введіть сторону c: ");
            parallelepiped.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nЗначення полів класу: ");
            parallelepiped.Print();

            if (parallelepiped.Correct())
            {
                Console.WriteLine($"\nПлоща поверхні: {parallelepiped.Area()}");
                Console.WriteLine($"Об'єм: {parallelepiped.Volume()}");
            }
            else
            {
                Console.WriteLine("\nПаралелепіпед не існує так як одна зі сторін не додатня.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}