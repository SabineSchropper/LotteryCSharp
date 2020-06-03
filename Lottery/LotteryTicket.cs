using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery
{
    class LotteryTicket
    {
        /// <summary>
        /// lotteryArray
        /// </summary>
        public int[] LotteryNumber = new int[6];

        public LotteryTicket(int[] RandomArray)
        {
            this.LotteryNumber = RandomArray;
        }

        

    }
}
