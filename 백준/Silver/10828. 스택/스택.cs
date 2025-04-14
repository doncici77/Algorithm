internal class BJ10828
{
    static int[] stackArray = new int[10];
    static int top = 0;

    static void Main(string[] args)
    {
        int commandCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandCount; i++)
        {
            string[] input = Console.ReadLine().Split();

            switch (input[0])
            {
                case "push":
                    int X = int.Parse(input[1]);
                    Push(X);
                    break;
                case "pop":
                    Pop();
                    break;
                case "size":
                    Console.WriteLine(top.ToString());
                    break;
                case "empty":
                    Enpty();
                    break;
                case "top":
                    Top();
                    break;
            }
        }
    }

    static void Top()
    {
        if (top <= 0)
        {
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(stackArray[top - 1].ToString()); ;
        }
    }

    static void Enpty()
    {
        if (top == 0)
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }

    static void Pop()
    {
        top--;
        if(top < 0)
        {
            top = 0;
            Console.WriteLine("-1");
        }
        else
        {
            Console.WriteLine(stackArray[top].ToString());
            stackArray[top] = 0;
        }
    }

    static void Push(int X)
    {
        if(stackArray.Length <= top)
        {
            int[] newStackArray = new int[stackArray.Length * 2];
            for (int i = 0; i < stackArray.Length; i++)
            {
                newStackArray[i] = stackArray[i];
            }
            stackArray = newStackArray;
        }

        stackArray[top] = X;
        top++;
    }
}