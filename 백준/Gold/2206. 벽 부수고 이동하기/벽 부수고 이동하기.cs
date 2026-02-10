using System;
using System.Collections.Generic;
using System.Text;

class Num2206
{
    static int N;
    static int M;
    static int[,] map;
    static bool[,,] visited;
    
    static int[] dy = {1, -1, 0 ,0};
    static int[] dx = {0, 0, 1, -1};
    
    class State
    {
        public int y, x, dist, broken;
        public State(int y, int x, int dist, int broken)
        {
            this.y = y;
            this.x = x;
            this.dist = dist;
            this.broken = broken;
        }
    }
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        
        visited = new bool[N, M, 2];
        map = new int[N, M];
        
        // 맵 제작
        for(int i = 0; i < N; i++)
        {
            string line = Console.ReadLine();
            
            for(int j = 0; j < M; j++)
            {
                map[i, j] = line[j] - '0';
            }
        }
        
        Console.Write(BFS());
    }
    
    static int BFS()
    {
        Queue<State> q = new Queue<State>();
        
        q.Enqueue(new State(0, 0, 1, 0));
        visited[0, 0, 0] = true;
        
        while(q.Count > 0)
        {
            State current = q.Dequeue();
            
            if (current.y == N - 1 && current.x == M - 1)
            {
                return current.dist;
            }
            
            for(int i = 0; i < 4; i++)
            {
                int ny = current.y + dy[i];
                int nx = current.x + dx[i];
                
                if (ny < 0 || nx < 0 || ny >= N || nx >= M) continue;
                
                if(map[ny, nx] == 1)
                {
                    if(current.broken == 0 && visited[ny, nx, 1] == false)
                    {
                        visited[ny, nx, 1] = true;
                        q.Enqueue(new State(ny, nx, current.dist + 1, 1));
                    }
                }
                else
                {
                    if(visited[ny, nx, current.broken] == false)
                    {
                        visited[ny, nx, current.broken] = true;
                        q.Enqueue(new State(ny, nx, current.dist + 1, current.broken));
                    }
                }
            }
        }
        
        return -1;
    }
}