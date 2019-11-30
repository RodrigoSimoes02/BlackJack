using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    class Mechanics
    {

        public static void Busted()
        {
            if (PlayerModule.GetTotalPoints() > 21)
            {
                MainWindow.BUSTED = true;
            }
        }



        public static Card PlayCard()
        {
            Card CardToPlay = CardController.GetCard();
            CorrectAceCardValue();
            return CardToPlay;
        }



        public static void CorrectAceCardValue()
        {
            if (PlayerModule.GetTotalPoints() > 21)
            {
                int index = PlayerModule.GetAceIndex();
                if (index >= 0)
                {
                    PlayerModule.Player_CardsPlayed.RemoveAt(index);
                    PlayerModule.Player_CardsPlayed.Add(new Card { CardName = "Ás", CardValue = 1 });
                    MainWindow.BUSTED = false;
                    Mechanics.Busted();
                }
                else
                {
                    Mechanics.Busted();
                }
            }
        }
    }
}
