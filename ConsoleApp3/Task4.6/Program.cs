using System;
using System.Security.Cryptography;
class Kuzakov {
    static void Main()
    {
        Console.WriteLine("Введите a ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите b");
        double b = double.Parse(Console.ReadLine());
        double y1 = 2, y2 = -3, y3 = -3;
        double x1 = 0, x2 = 2, x3 = -2;
        double res1 = (x1 - a) * (y2 - y1) - (x2 - x1) * (y1 - b); 
        double res2 = (x2 - a) * (y3 - y2) - (x3 - x2) * (y2 - b); 
        double res3 = (x3 - a) * (y1 - y3) - (x1 - x3) * (y3 - b);
        
        Console.WriteLine(res1);
        Console.WriteLine(res2);
        Console.WriteLine(res3);
        
        
        if ((res1 >= 0 && res2 >= 0 && res3 >= 0) || (res1 <= 0 && res2 <= 0 && res3 <= 0))
        {
            Console.WriteLine("Принадлежит");
        }
        else        {
            Console.WriteLine("Не принадлежит");
        }
    }
}