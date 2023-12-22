using System;
using System.Collections.Generic;
class Kuzakov {
    static void Main()
    {
        List<int> nums = new List<int>();
        int inp, sum = 0, prod = 1, average;
        for (;;)
        {
            inp = int.Parse(Console.ReadLine());
            
            if (inp == 0)
            {
                break;
            }
            nums.Add(inp);
        }

        foreach (int i in nums)
        {
            sum += i;
            prod *= i;
        }

        average = sum / nums.Count;
        
        Console.WriteLine($"Сумма = {sum}");
        Console.WriteLine($"Произведение = {prod}");
        Console.WriteLine($"Среднее среди всех элементов = {average}");
    }
}