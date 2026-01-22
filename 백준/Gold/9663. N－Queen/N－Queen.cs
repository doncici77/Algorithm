using System;

class Num9663
{
    static int N;
    static int[] board;
    static int resultCount = 0;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        board = new int[N];
        
        BackTracking(0);
        
        Console.WriteLine(resultCount);
    }
    
    static void BackTracking(int count)
    {
        if(count == N)
        {
            resultCount++;
            return;
        }
        
        for(int col = 0; col < N; col++)
        {
            if(IsSafe(count, col))
            {
                board[count] = col;
                
                BackTracking(count + 1);
            }
        }
    }
    
    static bool IsSafe(int count, int col)
    {
        for(int i = 0; i < count; i++)
        {
            // 1. 세로(열)가 겹치는지 
            if(board[i] == col) return false;
            
            // 2. 우상향 대각선(/)이 겹치는지 
            // 특징: (행 + 열) 값이 같음
            if(i + board[i] == count + col) return false;

            // 3. 우하향 대각선(\)이 겹치는지
            // 특징: (행 - 열) 값이 같음
            if(i - board[i] == count - col) return false;
        }
        
        return true;
    }
}