using System;
class Kuzakov {
    static void Main()
    {
        Random rnd = new Random();
        int[] arr = new int[10];
        int num;
        int answer = 0;
        
        for (int i = 0; i < 10; i++)
        {
            arr[i] = rnd.Next();
        }

        
        num = arr[0];

        for (int i = 0; i < 10; i++)
        {
            if (arr[i] < num)
            {
                num = arr[i];
                answer = i;
            }
        }
        Console.WriteLine($"Индекс минимального элемента {answer}");
    }
}