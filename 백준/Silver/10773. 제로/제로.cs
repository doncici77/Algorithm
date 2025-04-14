internal class BJ10773
{
    static int[] arr = new int[100_000];
    static int top = 0;

    static void Main(string[] args)
    {
        int commmandCount = int.Parse(Console.ReadLine());
        int total = 0;

        for(int i = 0; i < commmandCount; i++)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if(inputNum == 0)
            {
                top--;
                if(top >= 0)
                {
                    arr[top] = 0;
                }
                else
                {
                    top = 0;
                }
            }
            else
            {
                arr[top] = inputNum;
                top++;
            }
        }

        for(int i = 0; i < top; i++)
        {
            total += arr[i];
        }

        Console.WriteLine(total.ToString());
    }
}