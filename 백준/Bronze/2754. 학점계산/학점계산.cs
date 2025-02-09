class Program
{
    static void Main(string[] args)
    {
        float total = 0f;
        string input = Console.ReadLine();
        
        switch(input[0])
        {
            case 'A':
                total += 4f;
                break;
            case 'B':
                total += 3f;
                break;
            case 'C':
                total += 2f;
                break;
            case 'D':
                total += 1f;
                break;
            case 'F':
                total = 0.0f;
                Console.WriteLine($"{total:F1}");
                return;
            default:
                break;
        }
        
        if (input.Length == 2)
        {
            switch(input[1])
            {
                case '+':
                    total += 0.3f;
                    break;
                case '-':
                    total -= 0.3f;
                    break;
                default:
                    break;
            }
        }
        
        Console.Write($"{total:F1}");
    }
}