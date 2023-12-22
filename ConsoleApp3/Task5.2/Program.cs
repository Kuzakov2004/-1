using System;class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask2.txt";
        string data = File.ReadAllText(path);
        double[] nums = data.Split(';').Select(double.Parse).ToArray();
        Array.Sort(nums);
        File.AppendAllText(path, "\n");
        foreach (double i in nums)
        {
            File.AppendAllText(path,$"{i};");
        }
    }
}