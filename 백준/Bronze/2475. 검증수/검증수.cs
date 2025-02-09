class Program
{
    static void Main(string[] args)
    {
        string[] inputNum = Console.ReadLine().Split();
        int[] num = new int[inputNum.Length];
        int total = 0;
        
        for(int i = 0; i < inputNum.Length; i++)
        {
            num[i] = int.Parse(inputNum[i]);
        }
        
        total = Calculate(num);
        
        Console.Write(total);
    }
    
    static int Calculate(int[] num)
    {
        for(int i = 0; i < num.Length; i++)
        {
            num[i] = num[i] * num[i];
        }
        
        return (num[0] + num[1] + num[2] + num[3] + num[4]) % 10;
    }
}