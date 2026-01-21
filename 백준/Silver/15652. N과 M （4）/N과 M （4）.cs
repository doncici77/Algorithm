using System;
using System.Collections.Generic;
using System.Text;

class Num15652
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
        
        BackTracking(1, 0);
        
        Console.WriteLine(sb);
    }
    
    static void BackTracking(int start_index, int count)
    {
        if(count == M)
        {
            for(int i = 0; i < M; i++)
            {
                sb.Append(arr[i] + " ");
                
                if(i == M - 1)
                {
                    sb.AppendLine();
                }
            }
            
            return;
        }
        
        for(int i = start_index; i < N + 1; i++)
        {
            arr[count] = i;
            BackTracking(i, count + 1);
        }
    }
} 