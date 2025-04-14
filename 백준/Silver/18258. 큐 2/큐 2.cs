internal class BJ18258
{
    public static readonly StreamReader input = new(new BufferedStream(Console.OpenStandardInput()));
    public static readonly StreamWriter output = new(new BufferedStream(Console.OpenStandardOutput()));


    static int[] queue = new int[10];
    static int R = 0;
    static int F = 0;

    static void Main(string[] args)
    {
        int commandCount = int.Parse(input.ReadLine());

        for(int i = 0;  i < commandCount; i++)
        {
            string[] inputCmd = input.ReadLine().Split();

            switch (inputCmd[0])
            {
                case "push":
                    Push(int.Parse(inputCmd[1]));
                    break;

                case "pop":
                    Pop();
                    break;

                case "size":
                    output.WriteLine((R - F).ToString());
                    break;

                case "empty":
                    output.WriteLine((R > F ? 0 : 1).ToString());
                    break;

                case "front":
                    Front();
                    break;

                case "back":
                    Back();
                    break;
            }
        }

        output.Flush();
    }

    static void Front()
    {
        if(R > F)
        {
            output.WriteLine(queue[F].ToString());
        }
        else
        {
            output.WriteLine("-1");
        }
    }

    static void Back()
    {
        if (R > F)
        {
            output.WriteLine(queue[R - 1].ToString());
        }
        else
        {
            output.WriteLine("-1");
        }
    }

    static void Push(int X)
    {
        if (R >= queue.Length)
        {
            int[] newQueue = new int[queue.Length * 2];

            for(int i = 0;i < queue.Length; i++)
            {
                newQueue[i] = queue[i];
            }
            queue = newQueue;
        }

        queue[R] = X;
        R++;
    }

    static void Pop()
    {
        if(R > F)
        {
            output.WriteLine(queue[F++].ToString());
        }
        else
        {
            output.WriteLine("-1");
        }
    }
}