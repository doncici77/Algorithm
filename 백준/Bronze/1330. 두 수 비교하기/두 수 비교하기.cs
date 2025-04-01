class Program
{
    static void Main(string[] args)
{
    string[] line = Console.ReadLine().Split();

    int A = int.Parse(line[0]);
    int B = int.Parse(line[1]);

    if (A < B)
    {
        Console.WriteLine("<");
    }
    else if(A > B)
    {
        Console.WriteLine(">");
    }
    else
    {
        Console.WriteLine("==");
    }
}
}