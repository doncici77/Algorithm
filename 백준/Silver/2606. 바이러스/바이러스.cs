class Program
{
    static int computerCount; // 컴퓨터의 수
    static int edgeCount; // 간선의 수
    static int startVertex = 1; // 감염 시작 정점(컴퓨터)
    static int virusCount = -1; // 바이러스에 감염된 컴퓨터의 수

    static List<int>[] edgeData = new List<int>[107]; // 인접 리스트

    static bool[] isVisited = new bool[107]; // 방문 여부


    public static void Main(string[] args)
    {
        computerCount = int.Parse(Console.ReadLine());
        edgeCount = int.Parse(Console.ReadLine());

        #region 그래프 생성
        for(int i = 0; i < edgeData.Length; i++) // 리스트 초기화
        {
            edgeData[i] = new List<int>();
        }

        for(int i = 0; i < edgeCount; i++) // 그래프 생성
        {
            string[] input = Console.ReadLine().Split();
            int ver1 = int.Parse(input[0]);
            int ver2 = int.Parse(input[1]);

            edgeData[ver1].Add(ver2);
            edgeData[ver2].Add(ver1);
        }
        #endregion

        DFS(startVertex);

        Console.WriteLine(virusCount.ToString());
    }

    static void DFS(int currentVisit)
    {
        if (isVisited[currentVisit])
        {
            return;
        }

        isVisited[currentVisit] = true;
        virusCount++;

        for (int i = 0; i < edgeData[currentVisit].Count; i++)
        {
            int checkVisit = edgeData[currentVisit][i];

            if (!isVisited[checkVisit])
            {
                DFS(checkVisit);
            }
        }
    }
}