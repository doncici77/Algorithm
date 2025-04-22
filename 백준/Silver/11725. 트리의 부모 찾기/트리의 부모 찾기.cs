using System.Text;

class BJ11725
{
    static int[] parent = new int[100_007];

    static List<int>[] tree = new List<int>[100_007];

    static Queue<int> queue = new Queue<int>();

    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        int N = int.Parse(Console.ReadLine());

        for(int i = 0; i < N + 1; i++)
        {
            tree[i] = new List<int>();
        }

        for(int i = 0; i < N - 1; i++)
        {
            string[] input = Console.ReadLine().Split();

            int node1 = int.Parse(input[0]);
            int node2 = int.Parse(input[1]);

            tree[node1].Add(node2);
            tree[node2].Add(node1);
        }

        queue.Enqueue(1);

        while(queue.Count > 0)
        {
            int currentNode = queue.Dequeue();

            foreach(int i in tree[currentNode])
            {
                if (parent[i] == 0)
                {
                    parent[i] = currentNode;
                    queue.Enqueue(i);
                }
            }
        }

        for(int i = 2; i < N + 1; i++)
        {
            sb.AppendLine(parent[i].ToString());
        }

        Console.WriteLine(sb);
    }
}