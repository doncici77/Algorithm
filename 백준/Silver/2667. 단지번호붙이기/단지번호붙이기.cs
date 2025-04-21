class BJ2667
{
    static int N;
    static string[] Map = new string[25];
    static bool[,] isVisited = new bool[25, 25];
    static int count1 = 0;
    static List<int> townData = new List<int>();

    static void DFS(int x, int y)
    {
        if( x < 0 || x >= N || // 방문 했거나, 좌표가 유효하지 않거나, 1이 아니라면
            y < 0 || y >= N )
        {
            return;
        }

        if(isVisited[x, y])
        {
            return;
        }

        if(Map[x][y] != '1')
        {
            return;
        }

        isVisited[x, y] = true;
        count1++;

        DFS(x - 1, y); // 위

        DFS(x + 1, y); // 아래

        DFS(x, y - 1); // 왼쪽

        DFS(x, y + 1); // 오른쪽
    }

    public static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N; i++)
        {
            Map[i] = Console.ReadLine();
        }

        int townCount = 0;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if (Map[i][j] == '1' && isVisited[i, j] == false)
                {
                    count1 = 0;

                    DFS(i, j);

                    townData.Add(count1);

                    townCount++;
                }
            }
        }

        Console.WriteLine(townCount.ToString());
        townData.Sort();

        for(int i = 0; i < townCount; i++)
        {
            Console.WriteLine(townData[i].ToString());
        }
    }
}