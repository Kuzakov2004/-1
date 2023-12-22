using System;
using System.IO;
using System.Linq;

class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask3.txt";
        string data = File.ReadAllText(path);
        int[] nums = data.Split(' ').Select(int.Parse).ToArray();
        
        int min = nums[0];
        int minIndx = 0;
        int sr = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                minIndx = i;
            }
        }

        for (int i = 0; i < minIndx; i++)
        {
            sr += nums[i];
        }

        if (minIndx == 0)
        {
            Console.WriteLine("До минимального значения нет элементов");
        }
        else        {
            Console.WriteLine(sr / minIndx);
        }
        
    }
}