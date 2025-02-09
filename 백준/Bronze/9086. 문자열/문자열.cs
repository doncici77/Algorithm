using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        
        for(int i = 0; i < inputNum; i++)
        {
            string input = Console.ReadLine();
            output.Append(input[0]);
            output.AppendLine(input[input.Length - 1].ToString());
        }
        
        Console.Write(output.ToString());
    }
}