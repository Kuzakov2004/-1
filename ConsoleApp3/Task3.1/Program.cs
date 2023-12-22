using System;
class Kuzakov {
    static void Main()
    {
        string pathInput = "../../../input.txt";
        string pathOutput = "../../../output.txt";
        
        string[] data = File.ReadAllLines(pathInput);
        
        int[] combination = new int[10];
        int[] ticket = new int[6];
        int n, res = 0;
        IEnumerable<int> k = new int[6];
        
        combination = data[0].Split(' ').Select(int.Parse).ToArray();
        n = int.Parse(data[1]);
        
        for (int i = 2; i < n + 2; i++)
        {
            ticket =  data[i].Split(' ').Select(int.Parse).ToArray();
            k = ticket.Intersect(combination);
            if (k.Count() >= 3)
            {
                File.AppendAllText(pathOutput, "Lucky\n");
            }
            else            {
                File.AppendAllText(pathOutput, "Unlucky\n"); 
            }
        }
    }
}