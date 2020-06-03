using System;
using System.Linq;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            Lottery lottery = new Lottery();

            int hitCounter = 0;
            bool wantToPlay = true;

            lottery.GenerateLotteryTicket();

            while (wantToPlay)
            {
                Console.WriteLine("Gib eine sechsstellige Zahl ein.");
                Console.WriteLine("Wenn du nicht mehr spielen möchtest gib x ein.");
                string userString = Console.ReadLine();
                if (userString.Equals("x"))
                {
                    lottery.ShowRightNumbers();
                    break;
                }
                else
                {
                    hitCounter = lottery.CheckForHits(userString);
                }

                Console.WriteLine("Du hast " + hitCounter + " Zahl(en) richtig erraten!");
                if (hitCounter == 6)
                {
                    Console.WriteLine("Lottosechser. Leider gibts hier kein Geld dafür.");
                    lottery.ShowRightNumbers();
                }
            }
        }
    }  
}
