class BJ1260
{
    static int N;
    static int M;
    static int V;

    static List<int>[] edges = new List<int>[10_007];

    static Queue<int> queue = new Queue<int>();
    static bool[] isVisitedDFS = new bool[10_007];

    static Stack<int> stack = new Stack<int>();
    static bool[] isVisitedBFS = new bool[10_007];

    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        V = int.Parse(input[2]);

        for (int i = 0; i < N + 1; i++) // 리스트 초기화 (정점 수만큼)
        {
            edges[i] = new List<int>();
        }

        for (int i = 0; i < M; i++) // 간선 생성
        {
            string[] input2 = Console.ReadLine().Split();
            int one = int.Parse(input2[0]);
            int two = int.Parse(input2[1]);

            edges[one].Add(two);
            edges[two].Add(one);
        }

        for (int i = 0; i < N + 1; i++)
        {
            edges[i].Sort();
        }

        DFS();
        Console.WriteLine();
        BFS();
    }

    public static void DFS()
    {
        stack.Push(V);

        while (stack.Count > 0)
        {
            int current = stack.Pop();

            if (isVisitedDFS[current])
            {
                continue;
            }

            isVisitedDFS[current] = true;
            Console.Write(current + " ");

            for (int i = edges[current].Count - 1; i >= 0; i--)
            {
                int next = edges[current][i];
                if (!isVisitedDFS[next])
                {
                    stack.Push(next);
                }
            }
        }
    }

    public static void BFS()
    {
        queue.Enqueue(V);

        while (queue.Count > 0)
        {
            int current = queue.Dequeue();

            if (isVisitedBFS[current])
            {
                continue;
            }

            isVisitedBFS[current] = true;
            Console.Write(current + " ");

            foreach (int next in edges[current])
            {
                if (isVisitedBFS[next] == false)
                {
                    queue.Enqueue(next);
                }
            }
        }
    }
}