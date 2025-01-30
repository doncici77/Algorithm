using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] input;
        StringBuilder output = new StringBuilder();
        int a, b, val;
        
        for(int i = 0; i < n; i++)
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