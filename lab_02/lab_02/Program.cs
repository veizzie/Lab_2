class Ar
{
    private int n;
    private int[] a;
    private int k;

    public int K
    {
        get { return k; }
    }
    public int N
    {
        get { return n; }
    }

    public Ar(int a, int b, int x)
    {
        if (b < a)
        {
            throw new Exception ("b ПОВИННО БУТИ БІЛЬШЕ АБО РІВНЕ a.");
        }

        n = b - a + 1;
        this.a = new int[n];
        for (int i = 0; i < n; i++)
        {
            this.a[i] = (a + i) * x;
            if (this.a[i] > 50)
                k++;
        }
    }

    public Ar(string fileName)
    {
        string[] text = File.ReadAllText(fileName).Split(';');
        n = text.Length;
        a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(text[i]);
            if (a[i] > 50)
                k++;
        }
    }

    public void Print()
    {
        Console.Write("Масив: ");
        foreach (int element in a)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public int P()
    {
        for (int i = n - 1; i >= 0; i--)
        {
            if (a[i] % 2 == 0)
                return i;
        }
        return -1;
    }


    public int Sum(int i1, int i2) 
    {
        int sum = 0;
        for (int i = i1; i <= i2; i++)
        {
            sum += a[i];
        }
        return sum;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Виберіть конструктор: 1 - за введенням a,b,x; 2 - за допомогою назві файлу");
        int choise = Convert.ToInt32(Console.ReadLine());

        Ar ar;
        if (choise == 1)
        {
            Console.Write("Введіть a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть x: ");
            int x = Convert.ToInt32(Console.ReadLine());

            ar = new Ar(a, b, x);
        }
        else if (choise == 2)
        {
            Console.WriteLine("Введіть ім'я файлу:");
            string fileName = Console.ReadLine();

            ar = new Ar(fileName);
        }
        else
        {
            Console.WriteLine("Невірно вибрано конструктор.");
            return;
        }

        ar.Print();

        Console.WriteLine($"Кількість елементів більше 50: {ar.K}");

        int lastIndex = ar.P();
        if (lastIndex != -1)
        {
            Console.WriteLine($"Індекс останнього парного елемента: {lastIndex}");
            int sum = ar.Sum(0, lastIndex);
            Console.WriteLine($"Сума елементів ліворуч від останнього парного елемента: {sum}");
        }
        else
        {
            Console.WriteLine("Парних елементів в масиві немає.");
        }

    }
}