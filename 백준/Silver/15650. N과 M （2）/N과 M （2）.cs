using System;
using System.Collections.Generic;
using System.Text;

class Num15650
{
    static int N;
    static int M;
    static bool[] visited;
    static int[] arr;
    static StringBuilder sb;
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        visited = new bool[N + 1];
        arr = new int[M];
        
        sb = new StringBuilder();
        BackTracking(0, 0);
        Console.Write(sb);
    }
    
    static void BackTracking(int count, int beforeSize)
    {
        if(count == M)
        {
            for (int i = 0; i < M; i++)
            {
                sb.Append(arr[i] + " ");
            }
            sb.AppendLine();
            
            return;
        }
        
        for(int i = 1; i <= N; i++)
        {
            if(beforeSize > i)
            {
                continue;
            }
            
            if(visited[i] == false)
            {
                visited[i] = true;
                arr[count] = i;
                
                BackTracking(count + 1, i);
                
                visited[i] = false;
            }
        }
    }
}