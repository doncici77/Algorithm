using System;

class Num11399
{
    static void Main(string[] args)
    {
        string N_str = Console.ReadLine();
        int N = int.Parse(N_str);
        string[] P_str = Console.ReadLine().Split();
        int[] P = new int[1002];
        
        for(int i = 0; i < N; i++)
        {
            P[i] = int.Parse(P_str[i]);
        }
        
        // 오름차순 정렬
        for(int i = 0; i < N; i++)
        {
            for(int o = 0; o < N - 1; o++)
            {
                if(P[o] > P[o + 1])
                {
                    int temp = P[o + 1];
                    P[o + 1] = P[o];
                    P[o] = temp;
                }
            } 
        }
        
        int frontTime = 0;
        int total = 0;
        
        // 합계산
        for(int i = 0; i < N; i++)
        {
            frontTime += P[i];
            total += frontTime;
        }
        
        Console.WriteLine(total.ToString());
    }
}