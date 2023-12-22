using System;
using System.Security.Cryptography.X509Certificates;

class Kuzakov {
    static void Main()
    {
        int x = 0;
        Console.WriteLine("Введите а");
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine("Вводите числа");
        for (;;)
        {
            x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                break;
            }

            if (x % a == 0)
            {
                sum += x;
            }
        }
        Console.WriteLine($"Сумма равна {sum}");
    }
}