using System;
class Kuzakov {
    static void Main()
    {
        string path = "../../../nums.txt";
        string rez = "";

        string[] data = File.ReadAllLines(path);
        
        string[] nums = data[0].Split(' ').ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (int.Parse(nums[i]) % 2 != 0)
            {
                rez = rez + nums[i] + " ";
            }
        }
        File.WriteAllText(path, rez);
    }
}