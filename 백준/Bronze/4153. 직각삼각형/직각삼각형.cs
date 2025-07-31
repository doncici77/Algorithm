using System.Text;

public class BJ4153
{
    static void Main(string[] args)
    {
        int[] N = new int[3];
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string[] input = new string[3];
            int longNum = 0;
            int longCount = 0;

            input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                N[i] = int.Parse(input[i]);

                if (longNum < N[i])
                {
                    longNum = N[i];
                    longCount = i;
                }
            }

            if (longNum == 0)
            {
                Console.WriteLine(sb.ToString());
                return;
            }

            N[longCount] = 0;

            if ((longNum * longNum) == ((N[0] * N[0]) + (N[1] * N[1]) + (N[2] * N[2])))
            {
                sb.AppendLine("right");
            }
            else
            {
                sb.AppendLine("wrong");
            }
        }
    }
}