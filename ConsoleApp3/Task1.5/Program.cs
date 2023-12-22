using System;

class Kuzakov
{
    static void Main() {
        string str = Console.ReadLine();
        int count = 0;
        bool flag = true;
       
        for (int i = 0; i < str.Length; i++) 
        { 
            if (str[i] != ' ' && flag) 
            { 
                flag = false; 
                count++; 
            } 
            else if (str[i] != ' ' && !flag) 
            {
                continue;
            }
            else 
            {
                flag = true;
            }
        }
        Console.WriteLine("Start " + str + " End");
        Console.WriteLine($"Количество слов в строке : {count}");
        
    }
}