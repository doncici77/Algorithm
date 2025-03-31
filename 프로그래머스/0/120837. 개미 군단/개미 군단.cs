using System;

public class Solution {
    public int solution(int hp) {
        // 입력
        // hp : 사냥하려는 몬스터의 체력
        
        // 처리
        int bigAntCount = hp / 5;
        hp = hp % 5;
        
        int middleAntCount = hp / 3;
        hp = hp % 3;
        
        int smallAntCount = hp;
        
        // 출력
        
        int answer = 0;
        
        answer = smallAntCount + middleAntCount + bigAntCount;
        return answer;
    }
}