using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        string input;
        string[] num;
        int a, b, val;
        StringBuilder output = new StringBuilder();
            
        for(int i = 0; i < t; i++)
        {
            input = Console.ReadLine();
            num = input.Split(' ');
            a = int.Parse(num[0]);
            b = int.Parse(num[1]);
            
            val = a + b;
            
            output.AppendLine(val.ToString());
        }
        
        Console.Write(output);
    }
}