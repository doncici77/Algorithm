class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            string inputText = Console.ReadLine();
            bool value = true;
            int stackCount = 0;
            int[] stack = new int[100];

            if (inputText == ".")
            {
                break;
            }

            for(int i = 0; i < inputText.Length; i++)
            {
                if(inputText[i] == '(')
                {
                    stack[stackCount] = 1;
                    stackCount++;
                }
                else if(inputText[i] == ')')
                {
                    if (stackCount > 0 && stack[stackCount - 1] == 1)
                    {
                        stackCount--;
                        stack[stackCount] = 0;
                    }
                    else
                    {
                        value = false;
                        break;
                    }
                }
                else if(inputText[i] == '[')
                {
                    stack[stackCount] = 2;
                    stackCount++;
                }
                else if(inputText[i] == ']')
                {
                    if (stackCount > 0 && stack[stackCount - 1] == 2)
                    {
                        stackCount--;
                        stack[stackCount] = 0;
                    }
                    else
                    {
                        value = false;
                        break;
                    }
                }
            }

            if(!value || stackCount != 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("yes");
            }
        }
    }
}