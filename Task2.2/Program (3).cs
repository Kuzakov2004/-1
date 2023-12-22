using System;

class Kuzakov
{
    static void Main() {
        int[] nums = new int[100];
        int count = 1;
        for (int i = 0; i < 100; i++)
        {
            nums[i] = count;
            count += 2;
        }
        foreach(int i in nums)
        {
            Console.WriteLine($"{i} ");
        }
    }
}