using System;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask3.txt";
        string data = File.ReadAllText(path);
        int[] nums = data.Split(',').Select(int.Parse).ToArray();
        int max = nums[0];
        int min = nums[0];

        foreach (int i in nums)
        {
            if (i == 0)
            {
                break;
            }

            if (max < i)
            {
                max = i;
            }
            if (min > i)
            {
                min = i;
            }
            
        }
        Console.WriteLine($"Отношение равно {max / min}");
    }
}