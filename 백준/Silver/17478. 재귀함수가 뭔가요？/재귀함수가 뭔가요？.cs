class BJ17478
{
    public static void Main(string[] args)
    {
        int val = int.Parse(Console.ReadLine());
        int i = 0;

        Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");

        Question(i, val);
        Console.WriteLine("라고 답변하였지.");
    }

    static void Question(int i, int answerNum)
    {
        _Setting(i);
        Console.WriteLine("\"재귀함수가 뭔가요?\"");

        if (answerNum <= i)
        {
            _Setting(i);
            Console.WriteLine("\"재귀함수는 자기 자신을 호출하는 함수라네\"");
            return;
        }

        _Setting(i);
        Console.WriteLine("\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.");

        _Setting(i);
        Console.WriteLine("마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.");

        _Setting(i);
        Console.WriteLine("그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"");

        Question(i + 1, answerNum);
        _Setting(i + 1);
        Console.WriteLine("라고 답변하였지.");
    }

    static void _Setting(int i)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("____");
        }
    }
}