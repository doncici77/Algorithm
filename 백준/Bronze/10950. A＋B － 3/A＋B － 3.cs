using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        string[] input;
        int a, b, val;
        StringBuilder output = new StringBuilder();
            
        for(int i = 0; i < t; i++)
        {
            input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            
            val = a + b;
            
            output.AppendLine(val.ToString());
        }
        
        Console.Write(output);
    }
}
