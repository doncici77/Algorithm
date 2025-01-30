using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int val = 1;
        
        if(n > 0)
        {
            for(int i = 1; i <= n; i++)
            {
                val = val * i;
            }
            
            Console.Write(val);
        }
        else
        {
            Console.Write(val);
        }
    }
}