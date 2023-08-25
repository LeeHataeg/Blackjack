using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJeck_Test01
{
    internal class Card
    {
        //♠️♣♡◇
        public char symbol;
        public string num;
        public int point;

        public Card(char _symbol, string _num)
        {
            symbol = _symbol;
            num = _num;

            //point 계산
            if (num == "A")
            {
                point = 11;
            }
            else if ((num == "J") || (num == "Q") || (num == "K"))
            {
                point = 10;
            }
            else
            {
                point = Convert.ToInt32(num);
            }
        }

        public void PrintCard()
        {
            Console.Write($"{symbol} {num}");
        }
    }
}
