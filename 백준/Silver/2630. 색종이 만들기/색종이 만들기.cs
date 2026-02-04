using System;

class Num2630
{
    static int N;
    static int[,] map;
    static int oneCount;
    static int zeroCount;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        map = new int[N, N];
        oneCount = 0;
        zeroCount = 0;
        
        // 맵 제작
        for(int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            
            for(int j = 0; j < N; j++)
            {
                map[i, j] = int.Parse(inputs[j]);
            }
        }
        
        Box(0, 0, N);
        
        Console.WriteLine(zeroCount);
        Console.WriteLine(oneCount);
    }
    
    static void Box(int startY, int startX, int size)
    {
        if(Check(startY, startX, size))
        {
            if(map[startY, startX] == 1)
            {
                oneCount++;
                return;
            }
            else if(map[startY, startX] == 0)
            {
                zeroCount++;
                return;
            }
        }
        else
        {
            Box(startY, startX, size/2);
            Box(startY + size/2, startX, size/2);
            Box(startY, startX + size/2, size/2);
            Box(startY + size/2, startX + size/2, size/2);
        }
    }
    
    static bool Check(int startY, int startX, int size)
    {
        int startNum = 0;
        
        for(int y = startY; y < startY + size; y++)
        {
            for(int x = startX; x < startX + size; x++)
            {
                if(y == startY && x == startX)
                {
                    startNum = map[y, x];
                }
                else
                {
                    if(map[y, x] != startNum)
                    {
                        return false;
                    }
                }
            }
        }
        
        return true;
    }
}