using System;
using System.Collections.Generic;
using System.Text;

namespace Lottery
{
    class Lottery
    {
        public LotteryTicket LotteryTicket { get; set; }
        public int[] randomNumber = new int[6];
        public Random rand = new Random();

        public void GenerateLotteryTicket()
        {
            for (int i = 0; i < 6; i++)
            {
                randomNumber[i] = rand.Next(0, 10);
            }
            LotteryTicket = new LotteryTicket(randomNumber);
        }

        public void ShowRightNumbers()
        {

            for (int i = 0; i < LotteryTicket.LotteryNumber.Length; i++)
            {
                Console.Write(LotteryTicket.LotteryNumber[i]);
            }

        }
        /// <summary>
        /// searches for same number on the right place in LotteryNumber Array
        /// </summary>
        /// <param name="userString"></param>
        /// <returns>hitCounter</returns>
        public int CheckForHits(string userString)
        {
            int numberToCheck = 0;
            bool success = false;
            int hitCounter = 0;

            for (int i = 0; i < LotteryTicket.LotteryNumber.Length; i++)
            {
                success = Int32.TryParse(userString.Substring(i, 1), out numberToCheck);

                if (!success)
                {
                    Console.WriteLine("Hast du wirklich nur Zahlen eingegeben?");
                }
                else
                {
                    if (numberToCheck == LotteryTicket.LotteryNumber[i])
                    {
                        hitCounter++;
                    }
                }
            }
            return hitCounter;
        }
    }

}

