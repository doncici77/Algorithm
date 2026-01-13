using System;
using System.Collections.Generic;

class Num11724
{
    static List<int>[] graph;
    static bool[] visited;
    
    static void Main(string[] args)
    {
        // 기본 값 입력
        string[] input1 = Console.ReadLine().Split();
        int N = int.Parse(input1[0]);
        int M = int.Parse(input1[1]);
        
        // 빈 그래프 생성
        graph = new List<int>[N + 1];
        for(int i = 1; i < N + 1; i++)
        {
            graph[i] = new List<int>();
        }
        
        // 그래프 값 추가
        for(int i = 0; i < M; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            int A = int.Parse(input2[0]);
            int B = int.Parse(input2[1]);
            
            graph[A].Add(B);
            graph[B].Add(A);
        }
        
        // 카운트
        visited = new bool[N + 1];
        int count = 0;
        
        for(int i = 1; i <= N; i++)
        {
            if (visited[i] == false)
            {
                count++;
                DFS(i); 
            }
        }

        Console.WriteLine(count);
    }
    
    // 탐색
    static void DFS(int node)
    {
        visited[node] = true;

        foreach (int next in graph[node])
        {
            if (visited[next] == false)
            {
                DFS(next);
            }
        }
    }
}