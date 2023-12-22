using System;
class Kuzakov{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());        
        int prod = 1;
            
        for (int i = 3; i <= n; i += 3)
        {        
            prod *= i;
            
        }        
        if (n < 3)        
        {
                Console.WriteLine("Число n меньше трёх");
                
        }
        else        
        {
                Console.WriteLine(prod);
                
        }
    
    }
}
