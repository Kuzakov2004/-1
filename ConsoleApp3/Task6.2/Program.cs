using System;
using System.Security.Cryptography.X509Certificates;
class Kuzakov {
    static void Main()
    {
        string path = "../../../numsTask2.txt";
        string[] data = File.ReadAllLines(path);
        string str = "";

        foreach (string i in data)
        {
            str += i + " ";
        }
        Console.WriteLine(str);
    }
}