using System;
using System.Security.Cryptography.X509Certificates;

class Kuzakov {
    static void Main()    {
        Random rnd = new Random();        
        double[] arr = new double[rnd.Next(5, 12)];
        int countPos = 0;        
        int countNeg = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {            
            arr[i] = rnd.NextDouble() * ((10.0) - (-10.0)) + (-10.0);
            arr[i] = Math.Round(arr[i], 2);            
            Console.WriteLine(arr[i]);
            
            if (arr[i] < 0)            
            {
                countNeg++;            
            }
            else if (arr[i] > 0)            
            {
                countPos++;            
            }
        }        
        double[] positive = new double[countPos];        
        double[] negative = new double[countNeg];
        countPos = 0;        
        countNeg = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {            
            if (arr[i] < 0)
            {                
                negative[countNeg] = arr[i];
                countNeg++;            }
            else if (arr[i] > 0)           
            {
                positive[countPos] = arr[i];                
                countPos++;
            }        
        }
        
        Console.WriteLine("Отрицательные ");   
        
        foreach (double i in negative)
        {            
            Console.WriteLine(i);
        }        
        Console.WriteLine("Положительные ");
        
        foreach (double i in positive)        
        {
            Console.WriteLine(i);        
        }
    }
}