using System.Text;

class BJ24444
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        string[] inputs = Console.ReadLine().Split();
        int vertexCount = int.Parse(inputs[0]); // 정점의 수
        int edgeCount = int.Parse(inputs[1]); // 간선의 수
        int startVer = int.Parse(inputs[2]); // 탐색 시작 정점

        int[] order = new int[vertexCount + 1]; // 방문 순서 기록
        int orderCount = 1;

        List<int>[] edge = new List<int>[vertexCount + 1];
        bool[] isVisited = new bool[vertexCount + 1];

        for (int i = 0; i < edge.Length; i++) // 리스트 초기화
        {
            edge[i] = new List<int>();
        }

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < edgeCount; i++) // 그래프 간선 생성
        {
            string[] inputs2 = Console.ReadLine().Split();
            int vertexStart = int.Parse(inputs2[0]);
            int vertexEnd = int.Parse(inputs2[1]);

            edge[vertexStart].Add(vertexEnd);
            edge[vertexEnd].Add(vertexStart);
        }

        for (int i = 0; i < edge.Length; i++) // 리스트 오름차순 정렬
        {
            edge[i].Sort();
        }

        queue.Enqueue(startVer);

        while (queue.Count > 0)
        {
            int visitVertex = queue.Dequeue();

            if (isVisited[visitVertex]) // 중복 방문할 경우 스킵
            {
                continue;
            }

            isVisited[visitVertex] = true;
            
            // 순서 기록
            order[visitVertex] = orderCount;
            orderCount++;

            for (int i = 0; i < edge[visitVertex].Count; i++)
            {
                int canVisit = edge[visitVertex][i];

                if (!isVisited[canVisit])
                {
                    queue.Enqueue(canVisit);
                }
            }
        }

        for(int i = 1; i < order.Length; i++)
        {
            sb.AppendLine(order[i].ToString());
        }

        Console.WriteLine(sb);
    }
}