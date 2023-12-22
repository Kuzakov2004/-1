using System;
class Kuzakov
{
    static void Main() {
        int[] rand () {
            int[] arr = new int[10];
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            string res = "";
            
            for(int i = 0; i < arr.Length; i++){
                arr[i] = rnd.Next(start, end);
            }
            return arr;
        }
        
        int[] arrey = rand();
        foreach (int i in arrey) {
            Console.Write($"{i} ");
        }
    }
}