using System.Text;

internal class BJ1920
{
    static StringBuilder stringBuilder = new StringBuilder();

    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] input2 = Console.ReadLine().Split();
        int[] arr1 = new int[N];

        for(int i = 0; i < N; i++)
        {
            arr1[i] = int.Parse(input2[i]);
        }

        Array.Sort(arr1);

        int M = int.Parse(Console.ReadLine());
        string[] input4 = Console.ReadLine().Split();
        int[] arr2 = new int[M];

        for (int i = 0; i < M; i++)
        {
            arr2[i] = int.Parse(input4[i]);
        }

        for(int i = 0; i < M; i++)
        {
            BinartSearch(arr1, arr2[i]);
        }

        Console.WriteLine(stringBuilder);
    }

    static void BinartSearch(int[] arr, int key)
    {
        int s = 0;
        int e = arr.Length;

        while (s < e)
        {
            int m = (s + e) / 2;

            if (arr[m] == key)
            {
                stringBuilder.AppendLine("1");
                return;
            }
            else if(arr[m] < key)
            {
                s = m + 1;
            }
            else if(arr[m] > key)
            {
                e = m;
            }
        }

        stringBuilder.AppendLine("0");
        return;
    }
}