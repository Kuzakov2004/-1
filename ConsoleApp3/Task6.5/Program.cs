using System;
using System.Security.Cryptography.X509Certificates;

class Kuzakov {
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine()); 
        int[,] arr = new int[n, m];
        int[] count = new int[n];
        int sum = 0;
        Random rnd = new Random();
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = rnd.Next(0, 2); 
                Console.Write($"{arr[i, j]} \t");
                sum += arr[i, j];
            }
            
            if (sum % 2 != 0)
            {
                count[i] = 1;
            }
            sum = 0;
            
            Console.WriteLine(count[i]);
            Console.WriteLine();
        }
    }
}