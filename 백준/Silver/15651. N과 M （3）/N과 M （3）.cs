using System;
using System.Collections.Generic;
using System.Text;

class Num15651
{
    static int N;
    static int M;
    static int[] arr;
    static StringBuilder sb;
    
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        arr = new int[M];
        sb = new StringBuilder();
        
        Gogogo(0);
        
        Console.WriteLine(sb);
    }
    
    static void Gogogo(int depth)
    {
        if(depth == M)
        {
            for(int i = 0; i < M; i++)
            {
                sb.Append(arr[i] + " ");
            }
            sb.AppendLine();
            
            return;
        }
        
        for(int i = 1; i <= N; i++)
        {
            arr[depth] = i;
            
            Gogogo(depth + 1);
        }
    }
}