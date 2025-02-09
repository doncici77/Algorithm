using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] ascii = new char[input.Length];
        int[] asciiNum = new int[input.Length];
        StringBuilder output = new StringBuilder();
        
        for(int i = 0; i < input.Length; i++)
        {
            ascii[i] = (char)input[i];
            
            if((int)ascii[i] < 96)
            {
                asciiNum[i] = (int)ascii[i] + 32;
            }
            else
            {
                asciiNum[i] = (int)ascii[i] - 32;
            }
            
            output.Append((char)asciiNum[i]);
        }
        
        Console.Write(output);
    }
}