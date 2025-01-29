using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 시간 초과 // Console.WriteLine 메모리 조작 때문에 호출을 연속으로 하면 시간이 초과된다.
        //int num = int.Parse(Console.ReadLine());
        
        //for(int i = 1; i <= num; i++)
        //{
            //Console.WriteLine(i);
        //}
        
         int n = int.Parse(Console.ReadLine());
         StringBuilder allNum = new StringBuilder();

         for (int i=1; i<=n; i++)
         {
             allNum.AppendLine(i.ToString());
         }

         Console.WriteLine(allNum);
    }
}