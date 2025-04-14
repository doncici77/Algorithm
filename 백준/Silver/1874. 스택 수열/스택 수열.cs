using System.Text;

class Program
{
    static int[] stack = new int[100_000];
    static int top = -1;

    public static void Main(string[] args)
    {
        int inputCount = int.Parse(Console.ReadLine());
        int[] arr = new int[inputCount];
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < inputCount; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int targetIndex = 0;
        int nextPushNum = 1;

        while (targetIndex < inputCount)
        {
            if (top >= 0 && stack[top] == arr[targetIndex])
            {
                Pop();
                sb.AppendLine("-");
                targetIndex++;
            }
            else if (nextPushNum <= inputCount)
            {
                Push(nextPushNum++);
                sb.AppendLine("+");
            }
            else
            {
                Console.WriteLine("NO");
                return;
            }
        }

        Console.WriteLine(sb);
    }

    static void Push(int num)
    {
        top++;
        stack[top] = num;
    }

    static void Pop()
    {
        if (top >= 0)
        {
            stack[top] = 0;
            top--;
        }
    }
}