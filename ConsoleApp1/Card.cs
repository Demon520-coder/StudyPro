using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 扑克牌
    /// </summary>
    public class Card
    {
        private readonly Rank _rank;

        private readonly Suik _suik;

        /// <summary>
        /// 创建一张扑克
        /// </summary>
        /// <param name="rank"></param>
        /// <param name="suik"></param>
        public Card(Rank rank, Suik suik)
        {
            this._rank = rank;
            this._suik = suik;
        }

        public override string ToString()
        {
            return $"花色:{_suik.ToString()}-大小:{_rank.GetHashCode().ToString()}";
        }
    }
}
