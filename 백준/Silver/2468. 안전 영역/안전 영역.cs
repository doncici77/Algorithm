using System;
using System.Collections.Generic;

class Num2468
{
    static bool[,] visited;
    static int[,] array;
    static int N;
    
    static void Main(string[] args)
    {
        string N_str = Console.ReadLine();
        N = int.Parse(N_str);
        
        int maxHeight = 1;
        
        array = new int[N,N];
        for(int i = 0; i < N; i++)
        {
            string[] nums = Console.ReadLine().Split();
            
            for(int o = 0; o < N; o++)
            {
                array[i,o] = int.Parse(nums[o]);
                
                if(maxHeight < array[i,o])
                {
                    maxHeight = array[i,o];
                }
            }
        }
        
        int area = 0;
        int maxAreaCount = 1;
        
        for(int rainHeight = 1; rainHeight < maxHeight; rainHeight++)
        {
            // 비가 차오른다
            for(int i = 0; i < N; i++)
            {
                for(int o = 0; o < N; o++)
                {
                    if(array[i,o] == rainHeight)
                    {
                        array[i,o] = 0;
                    }
                }
            }
            
            // 영역 개수 탐색
            visited = new bool[N,N];
            area = 0;
            
            for(int i = 0; i < N; i++)
            {
                for(int o = 0; o < N; o++)
                {
                    if(array[i,o] != 0 && visited[i,o] == false)
                    {
                        visited[i,o] = true;
                        area++;
                        Find(i,o);
                    }
                }
            }
            
            if(maxAreaCount < area)
            {
                maxAreaCount = area;
            }
        }
        
        Console.WriteLine(maxAreaCount.ToString());
    }
    
    static void Find(int y, int x)
    {
        int[] dx = {1, -1, 0, 0};
        int[] dy = {0, 0, 1, -1};
        
        for(int i = 0; i < 4; i++)
        {
            int newY = y + dy[i];
            int newX = x + dx[i];
            
            if(newY >= 0 && newY < N && newX >= 0 && newX < N)
            {
                if(array[newY,newX] != 0 && visited[newY,newX] == false)
                 {
                      visited[newY,newX] = true;
                      Find(newY,newX);
                 }
            }
        }
    }
}