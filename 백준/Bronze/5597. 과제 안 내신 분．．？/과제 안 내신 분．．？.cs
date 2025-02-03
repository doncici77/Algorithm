class Program
{
    static void Main(string[] args)
    {
        int[] attendance = new int[30]; // 출석한 학생 번호
        int[] num = new int[30]; // 총 숫자들
        int[] badguy = new int[2]; // 출석 안한 학생 번호
        int ct = 0; // 출석 안한 학생 번호 배열 숫자
        int badguyNum = 0;
        
        for(int j = 0; j < 30; j++)
        {
            num[j] = j + 1;
        }
        
        for(int i = 0; i < 28; i++)
        {
            attendance[i] = int.Parse(Console.ReadLine());
        }
        
        for(int k = 0; k < 30; k++)
        {
            for(int p = 0; p < 30; p++)
            {
                if(num[k] == attendance[p])
                {
                    num[k] = 0;
                }
            }
        }
        
        for(int o = 0; o < 30; o++)
        {
            if(num[o] != 0)
            {
                badguy[ct] = num[o];
                ct++;
            }
        }
        
        if(badguy[0] > badguy[1])
        {
            badguyNum = badguy[0];
            badguy[0] = badguy[1];
            badguy[1] =  badguyNum;
            
        }
        
        Console.WriteLine(badguy[0]);
        Console.WriteLine(badguy[1]);
    }
}