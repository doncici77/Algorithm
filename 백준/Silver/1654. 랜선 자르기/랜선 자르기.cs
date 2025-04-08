internal class BJ1654
{
    static void Main(string[] args)
    {
        long K;
        long N;

        string[] input = Console.ReadLine().Split();
        K = long.Parse(input[0]);
        N = long.Parse(input[1]);

        long[] lineLength = new long[N];
        long maxLength = 0;

        for(int i = 0; i < K; i++)
        {
            lineLength[i] = int.Parse(Console.ReadLine());
            maxLength = Math.Max(maxLength, lineLength[i]);
        }

        long s = 1;
        long e = maxLength + 1;

        while(s < e)
        {
            long m = (s + e) / 2;
            long sum = 0;

            for (int i = 0; i < K; i++)
            {
                sum += lineLength[i] / m;
            }

            if(sum < N)
            {
                e = m;
            }
            else
            {
                s = m + 1;
            }
        }

        Console.WriteLine(s - 1);
    }
}