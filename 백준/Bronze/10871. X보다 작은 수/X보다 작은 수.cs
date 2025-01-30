using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(); // N과 X값 입력
        string[] inputNum = Console.ReadLine().Split(); // n개의 정수 입력
        StringBuilder output = new StringBuilder(); // 결과: 출력되는 값
        
        int n = int.Parse(input[0]), x = int.Parse(input[1]); // N과 X의 값
        int[] num = new int[n]; // n개의 입력된 정수
        
        for(int i = 0; i < n; i++)
        {
            num[i] = int.Parse(inputNum[i]);
            
            if(num[i] < x)
            {
                output.Append(num[i].ToString() + " ");
            }
        }
        Console.Write(output);
    }
}