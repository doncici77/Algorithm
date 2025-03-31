class BJ10872
{
    static void Main(string[] args)
    {
        int getNum = int.Parse(Console.ReadLine());
        int val = 1;
        
        if(getNum == 0)
        {
            Console.WriteLine(val);
        }
        else
        {
            for(int i = 1; i <= getNum; i++)
            {
                val = val * i;
            }
            Console.WriteLine(val);
        }
    }
}