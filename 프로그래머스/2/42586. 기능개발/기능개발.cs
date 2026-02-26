using System;

// progresses 배열의 크기 == speeds 배열의 크기
// progresses 작업 상태 %
// speeds 하루 작업 속도 %
// 첫번째 작업 일수 기준으로 이후 일수 체크 answer[0]
// 이후 작업에서 첫번째 작업 일수보다 일수가 길면 answer[1]

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] tasks = new int[progresses.Length];
        int dayBig = 0;
        int count = 0;
        
        for(int i = 0; i < progresses.Length; i++)
        {
            int days;
            int num = 100 - progresses[i];
            
            if((num % speeds[i]) == 0)
            {
                days = num / speeds[i];
            }
            else
            {
                days = (num / speeds[i]) + 1;
            }
            
            if(i == 0)
            {
                tasks[i]++;
                dayBig = days;
                continue;
            }
            
            if(dayBig < days)
            {
                count++;
                dayBig = days;
                tasks[count]++;
            }
            else
            {
                tasks[count]++;
            }
        }
        
        int[] answer = new int[count + 1];
        
        for(int i = 0; i < count + 1; i++)
        {
            answer[i] = tasks[i];
        }
        
        return answer;
    }
}