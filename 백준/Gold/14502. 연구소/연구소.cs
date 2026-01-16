using System;
using System.Collections.Generic;

class Num14502
{
    static int M; // 가로
    static int N; // 세로
    static int[,] map;
    static int maxSafeZone = 0;
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        
        // 맵 제작
        map = new int[N, M];
        for(int i = 0; i < N; i++)
        {
            string[] input2 = Console.ReadLine().Split();
            
            for(int o = 0; o < M; o++)
            {
                map[i, o] = int.Parse(input2[o]);
            }
        }
        
        Create_Wall(0);
        
        Console.WriteLine(maxSafeZone.ToString());
    }
    
    // 벽 세우기
    static void Create_Wall(int count)
    {
        if(count == 3)
        {
            Spread_Virus();
            return;
        }
        
        for(int i = 0; i < N; i++)
        {
            for(int o = 0; o < M; o++)
            {
                if(map[i, o] == 0)
                {
                    map[i, o] = 1;
                    Create_Wall(count + 1);
                    map[i, o] = 0;
                }
            }
        }
    }
    
    static void Spread_Virus()
    {
        int[,] tempMap = (int[,])map.Clone();
        List<(int, int)> virusList = new List<(int, int)>();
        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (tempMap[i, j] == 2)
               {
                    virusList.Add((i, j));
                }
            }
        }
        
        int[] dx = { 0, 0, 1, -1 };
        int[] dy = { 1, -1, 0, 0 };
        
        int index = 0;
        
        while (index < virusList.Count) 
        {
            var cur = virusList[index];
            index++;

            int y = cur.Item1;
            int x = cur.Item2;

            for (int i = 0; i < 4; i++)
            {
                int ny = y + dy[i];
                int nx = x + dx[i];

                if (ny >= 0 && ny < N && nx >= 0 && nx < M)
                {
                    if (tempMap[ny, nx] == 0)
                    {
                        tempMap[ny, nx] = 2;
                        virusList.Add((ny, nx)); 
                    }
                }
            }
        }
        
        int safeCount = 0;
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (tempMap[i, j] == 0)
                {
                    safeCount++;
                }
            }
        }
        
        if (maxSafeZone < safeCount)
        {
            maxSafeZone = safeCount;
        }
    }
}