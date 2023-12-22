using System;

class Kuzakov
{
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, 0] = 1;
                arr[0, j] = 1;
                
            }
        }
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    arr[i, j] = arr[i - 1, j] + arr[i, j - 1];
                
                }
            }
        
        
        
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{arr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}
