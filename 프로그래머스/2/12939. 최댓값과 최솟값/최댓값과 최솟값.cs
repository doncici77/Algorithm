public class Solution {
    public string solution(string s) {
        int Max = int.MinValue;
        int Min = int.MaxValue;
        string answer = "";
        
        string[] items = s.Split();
        
        foreach(string item in items)
        {
            int num = int.Parse(item);
            
            if(num < Min)
            {
                Min = num;
            }
            
            if(num > Max)
            {
                Max = num;
            }
        }
        
        answer = Min + " " + Max;
        
        return answer;
    }
}