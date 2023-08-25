using System.Collections.Generic;
using System.Net;

namespace BlackJack
{
    internal class Program
    {
        public static List<Card> deck { get; set; }
        public static List<Card> userHand { get; set; }
        public static List<Card> dealerHand { get; set; }

        static void Main(string[] args)
        {
            GameSetting();


            PrintHand(userHand);

            PrintHand(dealerHand);


            string input = Console.ReadLine();
        }
        public static void GameSetting()
        {
            int count = 0;
            deck = new List<Card>();
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 13; j++)
                {
                    if(i == 0)
                    {
                        //spade
                        
                        if(j == 0)
                        {
                            Card card = new Card('▲', "A");
                            deck.Add(card);
                        }
                        else if(j == 10)
                        {
                            Card card = new Card('▲', "J");
                            deck.Add(card);
                        }
                        else if (j == 11)
                        {
                            Card card = new Card('▲', "Q");
                            deck.Add(card);
                        }
                        else if(i == 12)
                        {
                            Card card = new Card('▲', "K");
                            deck.Add(card);
                        }
                        else
                        {
                            Card card = new Card('▲', $"{j+2}");
                            deck.Add(card);
                        }
                    }
                    else if(i == 1)
                    {
                        //clover ●
                        if (j == 0)
                        {
                            Card card = new Card('●', "A");
                            deck.Add(card);
                        }
                        else if (j == 10)
                        {
                            Card card = new Card('●', "J");
                            deck.Add(card);
                        }
                        else if (j == 11)
                        {
                            Card card = new Card('●', "Q");
                            deck.Add(card);
                        }
                        else if (i == 12)
                        {
                            Card card = new Card('●', "K");
                            deck.Add(card);
                        }
                        else
                        {
                            Card card = new Card('●', $"{j + 2}");
                            deck.Add(card);
                        }
                    }
                    else if(i == 2)
                    {
                        //heart▽
                        if (j == 0)
                        {
                            Card card = new Card('▽', "A");
                            deck.Add(card);
                        }
                        else if (j == 10)
                        {
                            Card card = new Card('▽', "J");
                            deck.Add(card);
                        }
                        else if (j == 11)
                        {
                            Card card = new Card('▽', "Q");
                            deck.Add(card);
                        }
                        else if (i == 12)
                        {
                            Card card = new Card('▽', "K");
                            deck.Add(card);
                        }
                        else
                        {
                            Card card = new Card('▽', $"{j + 2}");
                            deck.Add(card);
                        }
                    }
                    else
                    {
                        //diamond◇
                        if (j == 0)
                        {
                            Card card = new Card('◇', "A");
                            deck.Add(card);
                        }
                        else if (j == 10)
                        {
                            Card card = new Card('◇', "J");
                            deck.Add(card);
                        }
                        else if (j == 11)
                        {
                            Card card = new Card('◇', "Q");
                            deck.Add(card);
                        }
                        else if (i == 12)
                        {
                            Card card = new Card('◇', "K");
                            deck.Add(card);
                        }
                        else
                        {
                            Card card = new Card('◇', $"{j + 2}");
                            deck.Add(card);
                        }
                    }
                    count++;
                }
            }
            SettingCard();
        }
        public static void SettingCard()
        {
            //two card provide
            userHand.Add(PlusCard());
            userHand.Add(PlusCard());
            dealerHand.Add(PlusCard());
            dealerHand.Add(PlusCard());
        }
        public static Card PlusCard()
        {
            Random random = new Random();
            int index = random.Next(0, 52);

            return deck[index];
        }
        public static void PrintHand(List<Card> cards)
        {
            int length = cards.Count();
            bool lessThanNIne;
            int score = 0;
            int cardNum;

            Console.Write("현재 소지한 카드 패 : ");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{cards[i].sym} {cards[i].num}");
                lessThanNIne = int.TryParse(cards[i].num, out cardNum);
                if( lessThanNIne ==  true)
                {
                    score += Convert.ToInt32(cards[i].num);
                }
                else
                {
                    if(cards[i].num == "A")
                    {
                        score += 11;
                    }
                    else
                    {
                        score += 10;
                    }
                }
            }
            Console.WriteLine();

            Console.Write($"현재 총점 : {score}");
        }
    }
}