using System;class Kuzakov {
    static void Main()
    {
        string path = "../../../content.txt";

        string data = File.ReadAllText(path);
        int[] height = data.Split(' ').Select(int.Parse).ToArray();
        int res1 = 0, res2 = 0, iIndex = 0, jIndex = 0, j = 0;

        for (int i = 0; i < height.Length; i++)
        {
            while (j < height.Length - 1) 
            {
                j++;
                if (i == j)
                {
                    continue;
                }
                
                if (height[i] < height[j])
                {
                    res2 = height[i] * (j - i);
                }
                else                 {
                    res2 = height[j] * (j - i);
                }

                if (res2 > res1)
                {
                    iIndex = i;
                    jIndex = j;
                    res1 = res2;
                } 
                
            }
            j = i + 1;
        }
        
        Console.WriteLine($"Первый индекс:{iIndex} Второй индекс: {jIndex}");
        Console.WriteLine($"Объём воды равен: {res1}");
    }
}