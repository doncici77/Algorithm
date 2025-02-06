using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 첫 번째 입력값 받기
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // 행의 크기
        int m = int.Parse(input[1]); // 열의 크기

        int[,] queue = new int[n, m]; // n x m 크기의 2D 배열 생성

        // 첫 번째 행렬 A 입력 받기
        for (int i = 0; i < n; i++) 
        {
            string[] input2 = Console.ReadLine().Split(); 
            for (int j = 0; j < m; j++)
            {
                int num = int.Parse(input2[j]); // 각 원소 입력
                queue[i, j] = num; // 행렬에 저장
            }
        }

        // 두 번째 행렬 B 입력 받아서 더하기
        for (int i = 0; i < n; i++) 
        {
            string[] input2 = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                int num = int.Parse(input2[j]);
                queue[i, j] += num; // 두 번째 행렬을 더함
            }
        }

        // 결과 출력
        StringBuilder output = new StringBuilder(); // StringBuilder를 사용하여 효율적으로 출력
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < m; j++)
            {
                output.Append(queue[i, j].ToString() + " "); // 각 원소를 추가
            }
            output.Append("\n"); // 각 행 끝에 줄 바꿈 추가
        }
        Console.WriteLine(output); // 출력
    }
}
