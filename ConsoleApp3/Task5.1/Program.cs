using System;
using System.Security.Cryptography;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask1.txt";
        string data = File.ReadAllText(path);
        int[] nums = data.Split(' ').Select(int.Parse).ToArray();
        int min = nums[0];
        int minIndx = 0;
        int prod = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
                minIndx = i;
            }
        }

        for (int i = minIndx + 1; i < nums.Length; i++)
        {
            prod *= nums[i];
        }
        Console.WriteLine(prod);
    }
}