class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 10, b;
        int[] mas = new int[a];
        for (int i = 0; i < a; i++)
        {
            mas[i] = r.Next(0, 20);
            Console.Write("{0,3}", mas[i]);
        }
        Console.WriteLine();
        b = mas[0];
        mas[0] = mas[a - 1];
        mas[a - 1] = b;
        for (int i = 1; i < a - 2; i++)
        {
            b = mas[i];
            mas[i] = mas[i + 1];
            mas[i + 1] = b;
            i++;
        }
        for (int i = 0; i < a; i++)
            Console.Write("{0,3}", mas[i]);
        Console.WriteLine();
        Console.WriteLine("");
        Console.Write("Повтор?( enter - да; люб.др.клавиша - нет )");
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}