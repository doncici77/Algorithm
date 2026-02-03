using System;
using System.Text;

class Num10815
{
    static int N, M;
    static int[] arrN;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        string[] inputN = Console.ReadLine().Split();
        arrN = new int[N];
        for(int i = 0; i < N; i++)
        {
            arrN[i] = int.Parse(inputN[i]);
        }

        Array.Sort(arrN);

        M = int.Parse(Console.ReadLine());
        string[] inputM = Console.ReadLine().Split();
        
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < M; i++)
        {
            int target = int.Parse(inputM[i]);

            int resultIndex = Array.BinarySearch(arrN, target);

            if(resultIndex >= 0)
            {
                sb.Append("1 ");
            }
            else
            {
                sb.Append("0 ");
            }
        }

        Console.Write(sb);
    }
}