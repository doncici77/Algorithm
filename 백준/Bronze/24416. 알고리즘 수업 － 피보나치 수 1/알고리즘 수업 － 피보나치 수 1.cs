class BJ24416
{
    public static int fibCount = 0;
    public static int fibonacciCount = 0;

    public static void Main(string[] args)
    {
        int inputNum = int.Parse(Console.ReadLine());

        Fib(inputNum);
        Fibonacci(inputNum);

        Console.WriteLine(fibCount + " " + fibonacciCount);
    }

    static int Fib(int n)
    {
        if(n == 1 ||  n == 2)
        {
            fibCount++;
            return 1;
        }
        else
        {
            return (Fib(n - 1) + Fib(n - 2));
        }
    }

    static int Fibonacci(int n)
    {
        int[] f = new int[n + 1];
        f[1] = 1;
        f[2] = 1;

        for(int i = 3; i < n + 1; i++)
        {
            fibonacciCount++;
            f[i] = f[i - 1] + f[i - 2];
        }

        return f[n];
    }
}