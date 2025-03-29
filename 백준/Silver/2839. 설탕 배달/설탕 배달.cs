class BJ2839
{
    static void Main(string[] args)
    {
        int total = int.Parse(Console.ReadLine()); // 전체 용량
        
        int newValue = 0; // 새로운 봉투
        int lowerValue = -1; // 최소봉투
        int _5 = 0; // 5짜리 봉투 개수
        
        
        while(total >= 0)
        {
            if(total % 3 == 0)
            {
                newValue = _5 + (total / 3);
                if (lowerValue == -1 || newValue < lowerValue) // 가장 작은 봉투 개수 선택
                {
                    lowerValue = newValue;
                }
            }
            
            total -= 5;
            _5++;
        }
        
        Console.Write(lowerValue.ToString());
    }
}