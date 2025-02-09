class Program
{
    static void Main(string[] args)
    {
        string[] inuputNum = Console.ReadLine().Split();
        int a = int.Parse(inuputNum[0]);
        int b = int.Parse(inuputNum[1]);
        
        Console.Write(Calculate(a, b));
        
    }
    
    static int Calculate(int a, int b)
    {
        return (a + b) * (a - b);
    }
}