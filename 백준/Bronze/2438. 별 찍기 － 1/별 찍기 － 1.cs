using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        
        for(int i = 1; i <= n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                output.Append("*");
            }
            output.Append("\n");
        }
        Console.Write(output);
    }
}