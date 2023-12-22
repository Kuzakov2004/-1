using System;
using System.Security.Cryptography.X509Certificates;
class Kuzakov {
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        if (x % 10 == 0)
        {
            Console.WriteLine("Является");
        }
        else        {
            Console.WriteLine("Не является");
        }
    }
}