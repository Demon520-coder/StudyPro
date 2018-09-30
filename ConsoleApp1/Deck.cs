using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Deck
    {
        //0.初始化扑克
        //1.洗牌
        //2.发牌      
        private Card[] _cards;

        public Deck()
        {
            List<Card> list = new List<Card>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    list.Add(new Card((Rank)(j+1), (Suik)i));
                }
            }
            _cards = list.ToArray();         
        }

        /// <summary>
        /// 获取扑克
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public Card GetCard(int num)
        {
            if (num >= 1 && num <= 52)
            {
                return _cards[num];
            }
            else
            {
                throw new Exception("没有对应的扑克");
            }

        }

        /// <summary>
        /// 洗牌
        /// </summary>
        public void Refresh()
        {
            //打乱扑克牌顺序
            Random rd = new Random();
            List<Card> list = new List<Card>();
            for (int i = 0; i < _cards.Length; i++)
            {
                list.Add(_cards[rd.Next(_cards.Length)]);
            }

            _cards = list.ToArray();
        }

    }
}
