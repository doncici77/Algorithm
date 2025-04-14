namespace BJ2164
{
    public class Deck
    {
        public int cardNum;
        public Deck UnderCard;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Deck firstCard = new Deck { cardNum = 1 };
            Deck lastCard = firstCard;

            for (int i = 2; i <= input; i++)
            {
                Deck newCard = new Deck { cardNum = i };
                lastCard.UnderCard = newCard;
                lastCard = newCard;
            }

            int count = 0;
            while (firstCard.UnderCard != null)
            {
                if (count % 2 == 0)
                {
                    firstCard = firstCard.UnderCard;
                }
                else
                {
                    Deck temp = firstCard;
                    firstCard = firstCard.UnderCard;

                    temp.UnderCard = null;
                    lastCard.UnderCard = temp;
                    lastCard = temp;
                }
                count++;
            }

            Console.WriteLine(lastCard.cardNum);
        }
    }
}