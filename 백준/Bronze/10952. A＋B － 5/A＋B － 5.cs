using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input;
        StringBuilder output = new StringBuilder();
        int a, b, val;
        
        for( ; ; )
        {
            input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
                      
            if(a == 0 && b == 0)
            {
                Console.Write(output);
                break;
            }
            
            val = a + b;
            output.AppendLine(val.ToString());
        }      
    }
}