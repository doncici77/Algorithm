using System;
using System.Collections.Generic;
using System.Text;

class Num15649
{
    static int N, M;
    static bool[] visited;
    static int[] arr;
    static StringBuilder stringbuilder = new StringBuilder();
    
    static void Main(string[] args)
    {
        string[] input_str = Console.ReadLine().Split();
        
        N = int.Parse(input_str[0]);
        M = int.Parse(input_str[1]);
        arr = new int[M];
        visited = new bool[N + 1];
        
        BackTracking(0);
        
        Console.Write(stringbuilder);
    }
    
    static void BackTracking(int count)
    {
        if (count == M)
        {
            for (int i = 0; i < M; i++)
            {
                stringbuilder.Append(arr[i] + " ");
            }
            stringbuilder.AppendLine();
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            if (visited[i] == false)
            {
                visited[i] = true;
                arr[count] = i;
                
                BackTracking(count + 1);

                visited[i] = false;
            }
        }
    }
}