class Program
{
    static void Main(string[] args)
    {
        string[] inuputNum = Console.ReadLine().Split();
        long a = int.Parse(inuputNum[0]);
        long b = int.Parse(inuputNum[1]);
        
        Console.Write(Calculate(a, b));
        
    }
    
    static long Calculate(long a, long b)
    {
        return (a + b) * (a - b);
    }
}