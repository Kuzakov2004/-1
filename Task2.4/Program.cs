using System;using System.Collections.Generic;
class Kuzakov {
    static void Main()
    {
        int[,] temp = new int[12, 30];
        Random rnd = new Random();
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temp[i, j] = rnd.Next(-15, 20);

            }
        }
        
        double[] averageTemperature(int[,] temperature)
        {
            double[] res = new double[12];
            double sumVal = 0;
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    sumVal += temperature[i, j];
                }
                res[i] = Math.Round(sumVal / 30.0, 1, MidpointRounding.AwayFromZero);
                sumVal = 0;
            }

            return res;
        }
        
        double[] answer = averageTemperature(temp);
        Array.Sort(answer);
        
        Console.WriteLine("Средняя температура за год: ");
        foreach (double i in answer)
        {
            Console.Write($"{i} ");
        }

    }
}