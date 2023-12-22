class Program{
    public static void Main(string[] args)    
    {
        string pathTask4 = "../../../numsTask4.txt";
        string [] readTask4 = File.ReadAllLines(pathTask4);
        double [] nums = new double[readTask4.Length];
        nums = readTask4[0].Split(' ').Select(Convert.ToDouble).ToArray();
        int k = 0;        
        for (int i = 1; i < nums.Length; i++)
        {            
            if (nums[i - 1] == nums[i]) 
            {               
                k += 2;
                if (i == nums.Length - 1)                
                {
                    break;                
                }
                if (nums[i] == nums[i + 1])                
                {
                    k--;                
                }
            }        
        }
        Console.WriteLine(k);
    }    
}