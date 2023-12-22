using System;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask2.txt";
        double sum = 0;
        string data = File.ReadAllText(path);
        double[] nums = data.Split(';').Select(double.Parse).ToArray();

        foreach (double i in nums)
        {
            if (i == 0)
            {
                break;
            }

            if (i > 0)
            {
                sum += i;
            }
            
        }
        Console.WriteLine($"Сумма равна {sum}");
    }
}