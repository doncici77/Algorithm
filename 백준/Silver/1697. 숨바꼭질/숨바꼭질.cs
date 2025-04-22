class BJ1697
{
    static int N; // 언니
    static int K; // 동생

    static Queue<int> queue = new Queue<int>();
    static bool[] isVisited = new bool[100_007];
    static int[] wayDistance = new int[100_007];

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        K = int.Parse(input[1]);

        queue.Enqueue(N);
        wayDistance[N] = 0;
        isVisited[N] = true;

        while (queue.Count > 0)
        {
            int currentPos = queue.Dequeue();

            int[] move = { +1, -1, +currentPos };

            if (currentPos == K)
            {
                break;
            }

            for(int i = 0; i < move.Length; i++)
            {
                if (currentPos + move[i] >= 0 && currentPos + move[i] < 100_007)
                {
                    if (isVisited[currentPos + move[i]] == false)
                    {
                        isVisited[currentPos + move[i]] = true;
                        queue.Enqueue((currentPos + move[i]));
                        wayDistance[(currentPos + move[i])] = wayDistance[currentPos] + 1;
                    }
                }
            }
        }

        Console.WriteLine(wayDistance[K].ToString());
    }
}