using System;using System.Collections.Generic;class Kuzakov {
    static void Main()
    {
        List<string> arr = new List<string>();
        string inp, lng = " ", shrt = " ";
        for (;;)
        {
            inp = Console.ReadLine();

            if (inp == "")
            {
                break;
            }
            arr.Add(inp);
        }

        lng = arr[0];
        shrt = arr[0];

        foreach (string i in arr)
        {
            if (lng.Length < i.Length)
            {
                lng = i;
            }

            if (shrt.Length > i.Length)
            {
                shrt = i;
            }
        }
        Console.WriteLine($"Самый длинный - {lng}");
        Console.WriteLine($"Самый коротий - {shrt}");
    }
}