using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int val;
        StringBuilder output = new StringBuilder();
        
        for(int i = 1; i < 10; i++)
        {
            val = n * i;
            output.AppendLine($"{n} * {i} = {val}");
        }
        
        Console.Write(output);
    }
}