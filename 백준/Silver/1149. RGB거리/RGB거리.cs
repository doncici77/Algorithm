using System;

class Num1149
{
    static void Main(string[] args)
    {
        string N_str = Console.ReadLine();
        int N = int.Parse(N_str);
        
        int[] R = new int[1001];
        int[] G = new int[1001];
        int[] B = new int[1001];
        int[] answerR = new int[1001];
        int[] answerG = new int[1001];
        int[] answerB = new int[1001];
        
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            R[i] = int.Parse(input[0]);
            G[i] = int.Parse(input[1]);
            B[i] = int.Parse(input[2]);
        }
        
        answerR[0] = R[0];
        answerG[0] = G[0];
        answerB[0] = B[0];
        
        for(int i = 1; i < N; i++)
        {
            answerR[i] = Math.Min(answerG[i - 1], answerB[i - 1]) + R[i];
            answerG[i] = Math.Min(answerR[i - 1], answerB[i - 1]) + G[i];
            answerB[i] = Math.Min(answerG[i - 1], answerR[i - 1]) + B[i];
        }
        
        Console.Write(Math.Min(Math.Min(answerR[N - 1], answerG[N - 1]),Math.Min(answerR[N - 1], answerB[N - 1])));
    }
}