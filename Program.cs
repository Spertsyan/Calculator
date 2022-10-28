                               // Сперцян Эрик Т50-1-21;
do
{
    Console.WriteLine("");
    Console.WriteLine("1.Перемножить 2 числа [*]");
    Console.WriteLine("2.Вычесть первое из второго[-]");
    Console.WriteLine("3.Сложить 2 числа[+]");
    Console.WriteLine("4.Разделить первое на второе[/]");
    Console.WriteLine("5.Найти факториал из числа");
    Console.WriteLine("6.Найти квадратный корень из числа");
    Console.WriteLine("7.Найти 15 процент от числа [%]");
    Console.WriteLine("8.Возвести в степень N первое число");
    Console.WriteLine("9.Выйти из программы");
    Console.WriteLine("");




    string i = Console.ReadLine();
    int j = Convert.ToInt32(i);
    if (j == 1)
    {

        Console.WriteLine("");
        Console.WriteLine("выбрано число 1:(Перемножить 2 числа)");
        Console.WriteLine("Введите число 1:");
        string e = Console.ReadLine();
        int e2 = Convert.ToInt32(e);
        Console.WriteLine("Введите число 2:");
        string e3 = Console.ReadLine();
        int e4 = Convert.ToInt32(e3);
        int e5 = e2 * e4;
        Console.WriteLine("Ответ:" + e5);
    }

    if (j == 2)
    {
        Console.WriteLine("");
        Console.WriteLine("выбрано число 2:(Вычесть первое из второго)");
        Console.WriteLine("Введите число 1:");
        string v = Console.ReadLine();
        double v2 = Convert.ToInt32(v);
        Console.WriteLine("Введите число 2:");
        string v3 = Console.ReadLine();
        double v4 = Convert.ToInt32(v3);
        double v5 = v2 - v4;
        Console.WriteLine("Ответ:" + v5);
    }

    if (j == 3)
    {

        Console.WriteLine("");
        Console.WriteLine("выбрано число 3:(Сложить 2 числа)");
        Console.WriteLine("Введите число 1:");
        string y = Console.ReadLine();
        int y2 = Convert.ToInt32(y);
        Console.WriteLine("Введите число 2:");
        string y3 = Console.ReadLine();
        int y4 = Convert.ToInt32(y3);
        int y5 = y2 + y4;
        Console.WriteLine("Ответ:" + y5);
    }

    if (j == 4)
    {
        Console.WriteLine("");
        Console.WriteLine("выбрано число 4:(Разделить первое на второе)");
        Console.WriteLine("Введите число 1:");
        string p = Console.ReadLine();
        double p2 = Convert.ToInt32(p);
        Console.WriteLine("Введите число 2:");
        string p3 = Console.ReadLine();
        double p4 = Convert.ToInt32(p3);
        double p5 = p2 / p4;
        Console.WriteLine("Ответ:" + p5);
    }

    if (j == 5)
    {
        Console.WriteLine("");
        Console.WriteLine("выбрано число 5:(Найти факториал из числа)");
        Console.WriteLine("Введите число из которого вы хотите найти факториал:");
        string f = Console.ReadLine();
        int f2 = Convert.ToInt32(f);
        int d = 1;
        for (int z = 2; f2 >= z; z++)
        {
            d = d * z;
        }
        Console.WriteLine("Ответ:" + d);
    }

    if (j == 6)
    {
        Console.WriteLine("");
        Console.WriteLine("выбрвно число 6:(Найти квадратный корень из числа)");
        Console.WriteLine("Введите число из которыго вы хотите найти квадратный корень:");
        string m = Console.ReadLine();
        double m2 = Convert.ToInt32(m);
        Math.Sqrt(m2);
        Console.WriteLine("Ответ:" + Math.Sqrt(m2));
    }

    if (j == 7)
    {
        Console.WriteLine("");
        Console.WriteLine("выбрано число 7:(Найти 1 процент от числа)");
        Console.WriteLine("Введите число из которого вы хотите найти один процент:");
        string r = Console.ReadLine();
        double r2 = Convert.ToInt32(r);
        r2 = r2 / 100 * 15;
        Console.WriteLine("Ответ:" + r2);
    }

    if (j == 8)
    {

        Console.WriteLine("");
        Console.WriteLine("выбрано число 8:(Возвести в степень N первое число)");
        Console.WriteLine("Введите число:");
        string n = Console.ReadLine();
        double n2 = Convert.ToInt32(n);
        Console.WriteLine("Введите степень N:");
        string n3 = Console.ReadLine();
        double n4 = Convert.ToInt32(n3);
        Console.WriteLine("Ответ: " + Math.Pow(n2, n4));
    }

    if (j == 9)
    {
        break;
    }
    if (j < 1)
    {
        Console.WriteLine("Ошибка. Попробуйте ещё раз.");
    }
    else if (j > 9)
    {
        Console.WriteLine("Ошибка. Попробуйте ещё раз.");
    }
}
while (true);