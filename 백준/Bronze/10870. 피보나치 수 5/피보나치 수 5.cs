class BJ10870
{
    static int[] num = new int[50];
    
    static void Main(string[] args)
    {
        int numRead = int.Parse(Console.ReadLine());
        
        num[1] = 1;
        num[2] = 1;
        
        Console.Write(Fibo(numRead));
    }
    
    static int Fibo(int numTake)
    {
        if(numTake == 0)
        {
            return 0;
        }
        
        if(num[numTake] != 0)
        {
            return num[numTake];
        }
        
        return num[numTake] = Fibo(numTake - 1) + Fibo(numTake - 2);
    }
}