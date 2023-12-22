using System;

class Kuzakov
{
    static void Main() {
        int[] nums = new int[100];
        int count = 0;
        for (int i = 100; count < 100; i -= 3)
        {
            nums[count] = i;
            count++;
        }
        foreach(int i in nums)
        {
            Console.WriteLine(i);
        }
    }
}