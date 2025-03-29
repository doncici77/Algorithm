using System;

class BJ1546
{
    static void Main(string[] args)
    {
        int caseNum = int.Parse(Console.ReadLine()); // 과목 가짓수
        
        int[] realScore = new int[caseNum]; // 실제 점수
        float[] fakeScore = new float[caseNum]; // 가짜 점수
        int highstScore = 0; // 최고점수
        float total = 0; // 가짜 점수 총합
        float average; // 평균
        
        string[] realScoreStr = Console.ReadLine().Split(' ');
        for(int i = 0; i < caseNum; i++)
        {
            realScore[i] = int.Parse(realScoreStr[i]); // 실제 점수들 정수화
            
            if(highstScore < realScore[i]) // 최고 점수 세팅
            {
                highstScore = realScore[i];
            }
        }
        
        for(int i = 0; i < caseNum; i++) 
        {
            // 가짜 점수 계산
            // *실수형 계산에 정수형이 있으면 안된다.*
            fakeScore[i] = (realScore[i] / (float)highstScore) * 100;
            total += fakeScore[i]; // 가짜점수 총합 세팅
        }
        
        average = total / (float)caseNum;
        
        Console.Write(average.ToString());
    }
}