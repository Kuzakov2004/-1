using System;class Kuzakov {
    static void Main()
    {
        Console.WriteLine("Введите a ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b = double.Parse(Console.ReadLine());

        if ((a <= 3 && a >= -1) && (b <= 4 && b >= -2))
        {
            Console.WriteLine("Принадлежит");
        }
        else        {
            Console.WriteLine("Не принадлежит");
        }
    }
}