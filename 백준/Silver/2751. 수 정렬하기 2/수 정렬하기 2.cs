using System.Text;

public class BJ2751
{
    static void Main(string[] args)
    {
        int N;
        N = int.Parse(Console.ReadLine());

        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.Length; i++)
        {
            sb.AppendLine(array[i].ToString());
        }

        Console.WriteLine(sb.ToString());
    }
}