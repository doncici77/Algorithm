using System;
using System.Text;

class Num1012
{
    static int[,] map; 
    
    static void Main(string[] args)
    {
        string T_str = Console.ReadLine();
        int T = int.Parse(T_str);
        
        int[] M = new int[T];
        int[] N = new int[T];
        int[] K = new int[T];
        int[] worm = new int[T];
        
        for(int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine().Split();
            M[i] = int.Parse(input[0]);
            N[i] = int.Parse(input[1]);
            K[i] = int.Parse(input[2]);
            
            map = new int[N[i], M[i]]; 
            
            // 배추 맵핑
            for(int o = 0; o < K[i]; o++)
            {
                string[] K_pos = Console.ReadLine().Split();
                int X = int.Parse(K_pos[0]);
                int Y = int.Parse(K_pos[1]);
                
                map[Y, X] = 1; 
            }
            
            worm[i] = 0;
            
            for(int y = 0; y < N[i]; y++)
            {
                for(int x = 0; x < M[i]; x++)
                {
                    if(map[y, x] == 1) 
                    {
                        worm[i]++;
                        Check_K(y, x, N[i], M[i]); 
                    }
                }
            }
        }
        
        for(int i = 0; i < T; i++)
        {
            Console.WriteLine(worm[i]);
        }
    }
    
    static void Check_K(int y, int x, int N, int M)
    {
        map[y, x] = 0; 
        
        // 위
        if(y - 1 >= 0 && map[y - 1, x] == 1) 
        {
            Check_K(y - 1, x, N, M);
        }
        
        // 아래
        if(y + 1 < N && map[y + 1, x] == 1) 
        {
            Check_K(y + 1, x, N, M);
        }
        
        // 왼쪽
        if(x - 1 >= 0 && map[y, x - 1] == 1) 
        {
            Check_K(y, x - 1, N, M);
        }
        
        // 오른쪽
        if(x + 1 < M && map[y, x + 1] == 1) 
        {
            Check_K(y, x + 1, N, M);
        }
    }
}