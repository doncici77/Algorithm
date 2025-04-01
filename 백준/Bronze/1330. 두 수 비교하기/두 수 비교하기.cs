class Program
{
    static void Main(string[] args)
    {
        int a,b;
        string[] input = Console.ReadLine().Split();
        
        a = int.Parse(input[0]);
        b = int.Parse(input[1]);
        
        if(a == b)
        {
            Console.Write("==");
        }
        else if(a > b)
        {
            Console.Write(">");
        }
        else
        {
            Console.Write("<");
        }
    }
}