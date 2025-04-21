using System.Text;

class BJ24479
{
    static int N;
    static int M;
    static int R;

    static List<int>[] edge = new List<int>[200_007];

    static bool[] isVisited = new bool[100_007];

    static int count = 1;
    static int[] countArr = new int[100_007];

    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        R = int.Parse(input[2]);

        for (int i = 0; i < N + 1; i++) // 리스트 초기화
        {
            edge[i] = new List<int>();
        }

        for(int i = 0; i < M; i++) // 간선 생성
        {
            string[] input2 = Console.ReadLine().Split();
            int u = int.Parse(input2[0]);
            int v = int.Parse(input2[1]);

            edge[v].Add(u);
            edge[u].Add(v);
        }

        for (int i = 0; i < N + 1; i++) // 오름차순 정렬
        {
            edge[i].Sort();
        }

        DFS(R);

        for(int i = 1; i < N + 1; i++)
        {
            sb.AppendLine(countArr[i].ToString());
        }

        Console.WriteLine(sb);
    }

    static void DFS(int vertex)
    {
        if(isVisited[vertex])
        {
            return;
        }

        isVisited[vertex] = true;
        countArr[vertex] = count++;

        foreach (int next in edge[vertex])
        {
            if(isVisited[next] == false)
            { 
                DFS(next);
            }
        }
    }
}