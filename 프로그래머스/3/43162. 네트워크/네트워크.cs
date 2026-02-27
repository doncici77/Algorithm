using System;
// 컴퓨터 개수 n
// 자신의 매개변수 computers[i][j]는 무조건 1
// 연결되어 있는 것끼리 1개의 네트워크
// 서로 연결되어 있지 않으면 네트워크 분할

public class Solution {
    public bool[] visitedCom;
    
    public int solution(int n, int[,] computers) {
        int answer = 0;
        visitedCom = new bool[n];
        
        for(int i = 0; i < n; i++)
        {
            if(visitedCom[i] == false)
            {
                visitedCom[i] = true;
                Check(n, computers, i);
                answer++;
            }
        }
        
        return answer;
    }
    
    public void Check(int n, int[,] computers, int currentCom)
    {
        for(int i = 0; i < n; i++)
        {
            if(i == currentCom)
            {
                continue;
            }
            
            if(computers[currentCom, i] == 1)
            {
                if(visitedCom[i] == true)
                {
                    continue;
                }
                
                visitedCom[i] = true;
                Check(n, computers, i);
            }
        }
    }
}