using System;
using System.Collections.Generic;

class Num7576
{
    static int[,] Map;
    
    static void Main(string[] args)
    {
        // 사이즈 등록
        string[] Size_Str = Console.ReadLine().Split();
        Map = new int[int.Parse(Size_Str[1]),int.Parse(Size_Str[0])];
        int y = Map.GetLength(0);
        int x = Map.GetLength(1);
        
        List<(int, int)> list = new List<(int, int)>(); // 익은 토마토 위치
        
        // 맵 데이터 등록
        for(int i = 0; i < y; i++)
        {
            string[] y_data_Str = Console.ReadLine().Split();
            
            for(int o = 0; o < x; o++)
            {
                Map[i,o] = int.Parse(y_data_Str[o]);
                
                if(Map[i,o] == 1)
                {
                    list.Add((i, o));
                }
            }
        }
        
        // 탐색
        
        int[] dy = { -1, 1, 0, 0 };
        int[] dx = { 0, 0, -1, 1 };
        
        int head = 0;
        
        while(head < list.Count)
        {
            (int cy, int cx) = list[head];
            head++;

            for(int i = 0; i < 4; i++)
            {
                int ny = cy + dy[i];
                int nx = cx + dx[i];

                if (ny < 0 || nx < 0 || ny >= y || nx >= x)
                    continue;

                if (Map[ny, nx] == 0)
                {
                    Map[ny, nx] = Map[cy, cx] + 1;
                    list.Add((ny, nx));
                }
            }
        }
        
        // 결과
        int maxDays = 0;

        for (int i = 0; i < y; i++)
        {
            for (int o = 0; o < x; o++)
            {
                if (Map[i, o] == 0)
                {
                    Console.WriteLine(-1);
                    return;
                }
                
                if (maxDays < Map[i, o])
                {
                    maxDays = Map[i, o];
                }
            }
        }
        
        Console.WriteLine(maxDays - 1);
    }
} 