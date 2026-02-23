using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 0;
        Dictionary<string, int> clothCounts = new Dictionary<string, int>();
        
        for(int i = 0; i < clothes.GetLength(0); i++)
        {
            string type = clothes[i, 1];
            
            if(clothCounts.ContainsKey(type))
            {
                clothCounts[type]++;
            }
            else
            {
                clothCounts[type] = 1;
            }
        }
        
        answer = 1;
        foreach(int count in clothCounts.Values)
        {
            answer *= (count + 1);
        }
        
        return answer - 1;
    }
}