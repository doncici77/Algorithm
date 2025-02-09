class Program
{
    static void Main(string[] Main)
    {
        string input = Console.ReadLine();
        int inputNum = int.Parse(Console.ReadLine());
        
        Console.Write(input[inputNum - 1]);
    }
}