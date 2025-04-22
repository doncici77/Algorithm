class BJ2178
{
    static int N;
    static int M;
    static string[] maze = new string[107];

    static Queue<(int, int)> queue = new Queue<(int, int)>();
    static bool[,] isVisited = new bool[107, 107];
    static int[,] beforePos = new int[107, 107];
    static int x = 0;
    static int y = 0;

    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);

        for(int i = 0; i < N; i++) // 미로 생성
        {
            maze[i] = Console.ReadLine();
        }
        
        queue.Enqueue((x, y));
        beforePos[x, y] = 1;

        while(queue.Count > 0)
        {
            (x, y) = queue.Dequeue();

            if ((x - 1) >= 0 && isVisited[x - 1, y] == false && maze[x - 1][y] == '1')
            {
                isVisited[x - 1, y] = true;
                queue.Enqueue((x - 1, y)); // 상
                beforePos[x - 1, y] = beforePos[x, y] + 1;
            }

            if ((x + 1) < N && isVisited[x + 1, y] == false && maze[x + 1][y] == '1')
            {
                isVisited[x + 1, y] = true;
                queue.Enqueue((x + 1, y)); // 하
                beforePos[x + 1, y] = beforePos[x, y] + 1;
            }

            if ((y - 1) >= 0 && isVisited[x, y - 1] == false && maze[x][y - 1] == '1')
            {
                isVisited[x, y - 1] = true;
                queue.Enqueue((x, y - 1)); // 좌
                beforePos[x, y - 1] = beforePos[x, y] + 1;
            }

            if ((y + 1) < M && isVisited[x, y + 1] == false && maze[x][y + 1] == '1')
            {
                isVisited[x, y + 1] = true;
                queue.Enqueue((x, y + 1)); // 우
                beforePos[x, y + 1] = beforePos[x, y] + 1;
            }
        }

        Console.WriteLine(beforePos[N - 1, M - 1]);
    }
}