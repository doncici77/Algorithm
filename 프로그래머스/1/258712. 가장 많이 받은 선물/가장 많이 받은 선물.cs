using System;

public class Solution {
    public int solution(string[] friends, string[] gifts) {
        int answer = int.MinValue;
        // 총 선물 갯수
        int[] giftCounts = new int[friends.Length];
        // 서로 선물 갯수
        int[,] giftTradeDatas = new int[friends.Length, friends.Length];
        // 다음달 받는 갯수
        int[] takeGiftNextMonth = new int[friends.Length];
        
        // 이번달 선물 주고받은거 정리
        for(int i = 0; i < gifts.Length; i++)
        {
            string giftSend = gifts[i].Split()[0];
            string giftTake = gifts[i].Split()[1];
            
            int sendNum = 0;
            int takeNum = 0;
            
            for(int j = 0; j < friends.Length; j++)
            {
                if(giftSend == friends[j])
                {
                    sendNum = j;
                }
                
                if(giftTake == friends[j])
                {
                    takeNum = j;
                }
            }
            
            giftCounts[sendNum]++;
            giftCounts[takeNum]--;
            giftTradeDatas[sendNum, takeNum]++;
        }
        
        // 다음달 얼마나 주고 받은지 정리
        for(int i = 0; i < friends.Length; i++)
        {
            for(int j = 0; j < friends.Length; j++)
            {
                if(i == j)
                {
                    continue;
                }
                
                if(giftTradeDatas[i, j] > giftTradeDatas[j, i])
                {
                    takeGiftNextMonth[i]++;
                }
                else if(giftTradeDatas[i, j] == giftTradeDatas[j, i])
                {
                    if(giftCounts[i] > giftCounts[j])
                    {
                        takeGiftNextMonth[i]++;
                    }
                }
            }
        }
        
        for(int i = 0; i < friends.Length; i++)
        {
            if(answer < takeGiftNextMonth[i])
            {
                answer = takeGiftNextMonth[i];
            }
        }
        
        return answer;
    }
}