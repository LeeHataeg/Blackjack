using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJeck_Test01
{
    internal class CardPackage
    {
        public List<Card> deck;

        public List<Card> user;
        public List<Card> dealer;

        public CardPackage()
        {
            char[] _symbol = new char[4] { '♠', '♣', '♡', '◇' };
            string[] _num = new string[13] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            for(int i = 0; i < _num.Length; i++)
            {
                for(int j = 0; j < _symbol.Length; j++)
                {
                    Card card = new Card(_symbol[j], _num[i]);
                    deck.Add(card);
                }
            }

            //카드 셔플 | null로 개지랄하면 함수로 빼서 새로운 리스트를 만들자.(shuffeld deck)
            deck = deck.OrderBy(a => Guid.NewGuid()).ToList();
        }
        public void DrawCard(bool isDealerSuitable)
        {
            Card draw = deck.First();

            //스네이크 게임 217줄 적용 못해서 버그 날 수도

            //유저 카드 뽑기
            if (isDealerSuitable == true)
            {
                user.Add(draw);
            }
            //딜러 17점 아래. 딜러 카드 뽑기
            else
            {
                dealer.Add(draw);
            }
            deck.Remove(draw);
        }

        public int GetUsersScore()
        {
            int score = 0;
            foreach(Card c in user)
            {
                score += c.point;
            }
            return score;
        }
        public int GetDealersScore()
        {
            int score = 0;
            foreach (Card c in dealer)
            {
                score += c.point;
            }
            return score;
        }
    }
}
