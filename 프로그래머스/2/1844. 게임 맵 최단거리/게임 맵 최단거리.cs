using System;
using System.Collections.Generic;

public struct MapData
{
    public int y;
    public int x;
    public int distance;
    
    public MapData(int y, int x, int distance)
    {
        this.y = y;
        this.x = x;
        this.distance = distance;
    }
}

class Solution {
    public int solution(int[,] maps) {
        int answer = 0;
        int n = maps.GetLength(0); // Y
        int m = maps.GetLength(1); // X
        Queue<MapData> queue = new Queue<MapData>();
        bool[,] visited = new bool[n, m];
        int[,] distanceDatas = new int[n, m];
        int[] moveY = new int[4]{1, -1, 0, 0};
        int[] moveX = new int[4]{0, 0, 1, -1};
        
        queue.Enqueue(new MapData(0, 0, 1));
        visited[0, 0] = true;
        distanceDatas[0, 0] = 1;
        while(queue.Count > 0)
        {
            MapData currentMap = queue.Dequeue();
            int newDist = currentMap.distance + 1;
            
            for(int i = 0; i < 4; i++)
            {
                int newY = currentMap.y + moveY[i];
                int newX = currentMap.x + moveX[i];
                
                if(newY < 0 || newX < 0 ||
                  newY >= n || newX >= m)
                {
                    continue;
                }
                
                if(maps[newY, newX] == 0)
                {
                    continue;
                }
                
                if(visited[newY, newX] == true)
                {
                    continue;
                }
                
                queue.Enqueue(new MapData(newY, newX, newDist));
                visited[newY, newX] = true;
                distanceDatas[newY, newX] = newDist;
            }
        }
        
        if(visited[n - 1, m - 1] == false)
        {
            answer = -1;
        }
        else
        {
            answer = distanceDatas[n-1, m-1];
        }
        
        return answer;
    }
}