using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input = new string[100];
        StringBuilder output = new StringBuilder();
        
        for(int i = 0; i < 100; i++)
        {
            input[i] = Console.ReadLine();
            
            if(input[i] == "")
            {
                break;
            }
            
            output.AppendLine(input[i]);
        }
        
        Console.Write(output);
    }
}