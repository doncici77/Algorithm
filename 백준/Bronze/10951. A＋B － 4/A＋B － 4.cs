using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string[] num;
        int a, b;
        
        for( ; ; )
        {
            input = Console.ReadLine();
            
            if(input == null)
            {
                break;
            }
            
            num = input.Split();
            
            a = int.Parse(num[0]);
            b = int.Parse(num[1]);
            
            Console.WriteLine(a + b);
        }
    }
}
