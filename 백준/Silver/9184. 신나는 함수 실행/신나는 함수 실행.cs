class BJ9184
{
    public static int[,,] tmp = new int[50, 50, 50];

    public static void Main(string[] args)
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            if (a == -1 && b == -1 && c == -1)
            {
                break;
            }

            int val = W(a, b, c);
            Console.WriteLine($"w({a}, {b}, {c}) = {val}");
        }
    }

    static int W(int a, int b, int c)
    {
        if(a <= 0 ||  b <= 0 || c <= 0)
        {
            return 1;
        }
        else if(a > 20 ||  b > 20 || c > 20)
        {
            return W(20, 20, 20);
        }
        else if (tmp[a, b, c] != 0)
        {
            return tmp[a, b, c];
        }
        else if(a < b &&  b < c)
        {
            return tmp[a, b, c] = W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c);
        }
        else
        {
            return tmp[a, b, c] = W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
        }
    }
}