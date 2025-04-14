internal class BJ9012
{
    static bool YN = true;
    static int top = 0;

    static void Main(string[] args)
    {
        int commandCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandCount; i++)
        {
            string input = Console.ReadLine();

            top = 0;
            YN = true;
            
            for(int j = 0; j < input.Length; j++)
            { 
                if(input[j] == ')')
                {
                    top--;

                    if(top < 0)
                    {
                        YN = false;
                    }
                }
                else if(input[j] == '(')
                {
                    top++;
                }
            }

            if(top != 0 || YN == false)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}