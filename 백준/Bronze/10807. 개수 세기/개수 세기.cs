using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());  // N를 입력 받아 변수에 저장
       
        // N개의 숫자를 공백을 기준으로 문자열 배열에 저장
        string[] inputNum = Console.ReadLine().Split(); 
        
        int[] num = new int[n]; // N개의 숫자를 저장할 정수형 배열 준비
        
        int v = int.Parse(Console.ReadLine()); // v를 입력 받아 변수에 저장
        
        int count = 0; // v와 같은 수의 개수 저장
        
        for(int i = 0; i < n; i++)
        {
            num[i] = int.Parse(inputNum[i]);
            
            if(num[i] == v)
            {
                count++;
            }
        }
        Console.Write(count);
    }
}