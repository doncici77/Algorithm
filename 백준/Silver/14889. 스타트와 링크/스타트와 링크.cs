using System;

class Num14889
{
    static int N;
    static int[,] matrix;
    static bool[] hasTeam;
    static int gapMin;
    
    static void Main(string[] args)
    {
        N = int.Parse(Console.ReadLine());
        matrix = new int[N, N];
        hasTeam = new bool[N];
        gapMin = int.MaxValue;
        
        for(int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split();
            for(int j = 0; j < N; j++)
            {
                matrix[i, j] = int.Parse(inputs[j]);
            }
        }
        
        BackTracking(0, 0);
        
        Console.WriteLine(gapMin);
    }
    
    static void BackTracking(int index, int count)
    {
        if(count == N / 2)
        {
            CalculateDifference();
            return;
        }
        
        for(int i = index; i < N; i++)
        {
            if(!hasTeam[i])
            {
                hasTeam[i] = true;
                BackTracking(i + 1, count + 1);
                hasTeam[i] = false;
            }
        }
    }

    static void CalculateDifference()
    {
        int startScore = 0;
        int linkScore = 0;

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if(hasTeam[i] == true && hasTeam[j] == true)
                {
                    startScore += matrix[i, j];
                }
                else if(hasTeam[i] == false && hasTeam[j] == false)
                {
                    linkScore += matrix[i, j];
                }
            }
        }

        int diff = Math.Abs(startScore - linkScore);
        
        if(diff < gapMin)
        {
            gapMin = diff;
        }
    }
}