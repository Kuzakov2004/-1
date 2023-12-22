using System;using System.Security.Cryptography.X509Certificates;class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask5.txt";
        string data = File.ReadAllText(path);
        int[] nums = data.Split(' ').Select(int.Parse).ToArray();
        
        int max = nums[0];
        int maxIndx = 0;
        int min = nums[0];
        int minIndx = 0;
        int sr = 0;
        
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
                maxIndx = i;
            } 
            else if (nums[i] < min)
            {
                min = nums[i];
                minIndx = i;
            }
        }

        if (minIndx > maxIndx)
        {
            (maxIndx, minIndx) = (minIndx, maxIndx);
        }
        
        for (int i = minIndx + 1; i < maxIndx; i++)
        {
            sr += nums[i];
            Console.WriteLine(nums[i]);
        }
        Console.WriteLine("Среднее арифметическое: ");
        Console.WriteLine(sr / (maxIndx - minIndx - 1)); 
    }
}