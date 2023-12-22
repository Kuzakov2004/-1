using System;
using System.Security.Cryptography.X509Certificates;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask1.txt";
        string data = File.ReadAllText(path);
        string[] nums = data.Split(' ').ToArray();

        foreach (string i in nums)
        {
            if (i.Length % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}