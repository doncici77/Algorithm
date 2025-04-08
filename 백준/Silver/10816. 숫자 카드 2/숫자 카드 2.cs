using System.Text;

internal class BJ10816
{
    static StringBuilder stringBuilder = new StringBuilder();

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] inputN = Console.ReadLine().Split();
        int[] Ncards = new int[N];
        for (int i = 0; i < Ncards.Length; i++)
        {
            Ncards[i] = int.Parse(inputN[i]);
        }

        Array.Sort(Ncards);

        int M = int.Parse(Console.ReadLine());
        string[] inputM = Console.ReadLine().Split();
        int[] Mcards = new int[M];
        for (int i = 0; i < Mcards.Length; i++)
        {
            Mcards[i] = int.Parse(inputM[i]);
        }


        for (int i = 0; i < Mcards.Length; i++)
        {
            if(i == Mcards.Length - 1)
            {
                stringBuilder.Append(Upper(Ncards, Mcards[i]) - Lower(Ncards, Mcards[i]));
            }
            else
            {
                stringBuilder.Append(Upper(Ncards, Mcards[i]) - Lower(Ncards, Mcards[i]) + " ");
            }
        }

        Console.WriteLine(stringBuilder);
    }

    static int Upper(int[] arr, int key)
    {
        int s = 0;
        int e = arr.Length;

        while (s < e)
        {
            int middle = (e + s) / 2;

            if (key < arr[middle])
            {
                e = middle;
            }
            else
            {
                s = middle + 1;
            }
        }

        return s;
    }

    static int Lower(int[] arr, int key)
    {
        int s = 0;
        int e = arr.Length;

        while (s < e)
        {
            int middle = (e + s) / 2;

            if (key <= arr[middle])
            {
                e = middle;
            }
            else
            {
                s = middle + 1;
            }
        }
        return s;
    }
}