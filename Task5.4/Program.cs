using System;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask4.txt";
        string data = File.ReadAllText(path);
        int[] nums = data.Split(' ').Select(int.Parse).ToArray();
        
        int max = nums[0];
        int sum = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }
        }

        foreach (int i in nums)
        {
            if (i == max - 1)
            {
                sum += i;
            }
        }
        
        Console.WriteLine(sum);
    }
}