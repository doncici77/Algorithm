using System;
using System.Collections.Generic;
using System.Text;

class Num11403
{
    static int N;
    static List<int>[] graph;
    static int[,] array_answer;
    static bool[] visited;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        
        // 간선 그래프 생성
        graph = new List<int>[N + 1];
        array_answer = new int[N, N];
        for(int i = 0; i < N + 1; i++)
        {
            graph[i] = new List<int>();
            
            if(i < 1)
            {
                continue;
            }
            
            string[] nums_str = Console.ReadLine().Split();
            
            for(int o = 0; o < N; o++)
            {
                int can_Go = int.Parse(nums_str[o]);
                
                if(can_Go == 1)
                {
                    graph[i].Add(o + 1);
                }
            }
        }
        
        // 탐색
        visited = new bool[N + 1];
        for(int start = 1; start < N + 1; start++)
        {
            for(int goal = 1; goal < N + 1; goal++)
            {
                visited = new bool[N + 1];
                Search(start, start, goal);
            }
        }
        
        StringBuilder wr_answer = new StringBuilder();
        
        for(int start = 1; start < N + 1; start++)
        {
            for(int goal = 1; goal < N + 1; goal++)
            {
                if(goal == N)
                {
                    wr_answer.AppendLine(array_answer[start - 1,goal - 1].ToString());
                }
                else
                {
                    wr_answer.Append(array_answer[start - 1,goal - 1] + " ");
                }
            }
        }
        
        Console.WriteLine(wr_answer);
    }
    
    static void Search(int start,int player, int goal)
    {
        if(visited[player] == true)
        {
            return;
        }
        
        visited[player] = true;
        
        if(graph[player].Count <= 0)
        {
            return;
        }
        
        foreach(int item in graph[player])
        {
            if(goal == item)
            {
                array_answer[start - 1, goal - 1] = 1;
                return;
            }
            
            Search(start, item, goal);
        }
    }
}