using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Randomizer
    {
        private static readonly Random getrandom = new Random();

        private static int GetRandomNumber(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        public static Card GetRandomCard()
        {
            int randomID = GetRandomNumber(0, 51);
            Card carta = CardModule.PickCardByID(randomID);
            return carta;
        }
    }
}
