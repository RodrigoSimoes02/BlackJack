using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{
    public class Card : IEquatable<Card>
    {
        public string CardName { get; set; }

        public string CardSuit { get; set; }

        public int CardId { get; set; }

        public int CardValue { get; set; }

        public override string ToString()
        {
            return "ID: " + CardId + "   Name: " + CardName + "  CardSuit: " + CardSuit + "  Value: " + CardValue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Card objAsPart = obj as Card;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }

        public override int GetHashCode()
        {
            return CardId;
        }

        public bool Equals(Card other)
        {
            if (other == null) return false;
            return (this.CardId.Equals(other.CardId));
        }
    }

    public class CardModule
    {
        private static List<Card> CardLibrary()
        {
            List<Card> card = new List<Card>();

            card.Add(new Card { CardName = "Ás", CardSuit = "Paus", CardId = 0, CardValue = 1 });
            card.Add(new Card { CardName = "Duque", CardSuit = "Paus", CardId = 1, CardValue = 2 });
            card.Add(new Card { CardName = "Terno", CardSuit = "Paus", CardId = 2, CardValue = 3 });
            card.Add(new Card { CardName = "Quadra", CardSuit = "Paus", CardId = 3, CardValue = 4 });
            card.Add(new Card { CardName = "Quinto", CardSuit = "Paus", CardId = 4, CardValue = 5 });
            card.Add(new Card { CardName = "Sexto", CardSuit = "Paus", CardId = 5, CardValue = 6 });
            card.Add(new Card { CardName = "Sétimo", CardSuit = "Paus", CardId = 6, CardValue = 7 });
            card.Add(new Card { CardName = "Oitavo", CardSuit = "Paus", CardId = 7, CardValue = 8 });
            card.Add(new Card { CardName = "Nono", CardSuit = "Paus", CardId = 8, CardValue = 9 });
            card.Add(new Card { CardName = "Décimo", CardSuit = "Paus", CardId = 9, CardValue = 10 });
            card.Add(new Card { CardName = "Dama", CardSuit = "Paus", CardId = 10, CardValue = 10 });
            card.Add(new Card { CardName = "Valete", CardSuit = "Paus", CardId = 11, CardValue = 10 });
            card.Add(new Card { CardName = "Rei", CardSuit = "Paus", CardId = 12, CardValue = 10 });

            card.Add(new Card { CardName = "Ás", CardSuit = "Espadas", CardId = 13, CardValue = 1 });
            card.Add(new Card { CardName = "Duque", CardSuit = "Espadas", CardId = 14, CardValue = 2 });
            card.Add(new Card { CardName = "Terno", CardSuit = "Espadas", CardId = 15, CardValue = 3 });
            card.Add(new Card { CardName = "Quadra", CardSuit = "Espadas", CardId = 16, CardValue = 4 });
            card.Add(new Card { CardName = "Quinto", CardSuit = "Espadas", CardId = 17, CardValue = 5 });
            card.Add(new Card { CardName = "Sexto", CardSuit = "Espadas", CardId = 18, CardValue = 6 });
            card.Add(new Card { CardName = "Sétimo", CardSuit = "Espadas", CardId = 19, CardValue = 7 });
            card.Add(new Card { CardName = "Oitavo", CardSuit = "Espadas", CardId = 20, CardValue = 8 });
            card.Add(new Card { CardName = "Nono", CardSuit = "Espadas", CardId = 21, CardValue = 9 });
            card.Add(new Card { CardName = "Décimo", CardSuit = "Espadas", CardId = 22, CardValue = 10 });
            card.Add(new Card { CardName = "Dama", CardSuit = "Espadas", CardId = 23, CardValue = 10 });
            card.Add(new Card { CardName = "Valete", CardSuit = "Espadas", CardId = 24, CardValue = 10 });
            card.Add(new Card { CardName = "Rei", CardSuit = "Espadas", CardId = 25, CardValue = 10 });

            card.Add(new Card { CardName = "Ás", CardSuit = "Copas", CardId = 26, CardValue = 1 });
            card.Add(new Card { CardName = "Duque", CardSuit = "Copas", CardId = 27, CardValue = 2 });
            card.Add(new Card { CardName = "Terno", CardSuit = "Copas", CardId = 28, CardValue = 3 });
            card.Add(new Card { CardName = "Quadra", CardSuit = "Copas", CardId = 29, CardValue = 4 });
            card.Add(new Card { CardName = "Quinto", CardSuit = "Copas", CardId = 30, CardValue = 5 });
            card.Add(new Card { CardName = "Sexto", CardSuit = "Copas", CardId = 31, CardValue = 6 });
            card.Add(new Card { CardName = "Sétimo", CardSuit = "Copas", CardId = 32, CardValue = 7 });
            card.Add(new Card { CardName = "Oitavo", CardSuit = "Copas", CardId = 33, CardValue = 8 });
            card.Add(new Card { CardName = "Nono", CardSuit = "Copas", CardId = 34, CardValue = 9 });
            card.Add(new Card { CardName = "Décimo", CardSuit = "Copas", CardId = 35, CardValue = 10 });
            card.Add(new Card { CardName = "Dama", CardSuit = "Copas", CardId = 36, CardValue = 10 });
            card.Add(new Card { CardName = "Valete", CardSuit = "Copas", CardId = 37, CardValue = 10 });
            card.Add(new Card { CardName = "Rei", CardSuit = "Copas", CardId = 38, CardValue = 10 });

            card.Add(new Card { CardName = "Ás", CardSuit = "Ouros", CardId = 39, CardValue = 1 });
            card.Add(new Card { CardName = "Duque", CardSuit = "Ouros", CardId = 40, CardValue = 2 });
            card.Add(new Card { CardName = "Terno", CardSuit = "Ouros", CardId = 41, CardValue = 3 });
            card.Add(new Card { CardName = "Quadra", CardSuit = "Ouros", CardId = 42, CardValue = 4 });
            card.Add(new Card { CardName = "Quinto", CardSuit = "Ouros", CardId = 43, CardValue = 5 });
            card.Add(new Card { CardName = "Sexto", CardSuit = "Ouros", CardId = 44, CardValue = 6 });
            card.Add(new Card { CardName = "Sétimo", CardSuit = "Ouros", CardId = 45, CardValue = 7 });
            card.Add(new Card { CardName = "Oitavo", CardSuit = "Ouros", CardId = 46, CardValue = 8 });
            card.Add(new Card { CardName = "Nono", CardSuit = "Ouros", CardId = 47, CardValue = 9 });
            card.Add(new Card { CardName = "Décimo", CardSuit = "Ouros", CardId = 48, CardValue = 10 });
            card.Add(new Card { CardName = "Dama", CardSuit = "Ouros", CardId = 49, CardValue = 10 });
            card.Add(new Card { CardName = "Valete", CardSuit = "Ouros", CardId = 50, CardValue = 10 });
            card.Add(new Card { CardName = "Rei", CardSuit = "Ouros", CardId = 51, CardValue = 10 });

            return card;
        }

        public static Card PickCardByID(int id)
        {
            return CardLibrary()[id];
        }
    }
    public class CardController
    {

        private static bool IsAnAce(Card TheCard)
        {
            bool a = TheCard.CardId == 0;
            bool b = TheCard.CardId == 13;
            bool c = TheCard.CardId == 26;
            bool d = TheCard.CardId == 39;
            bool final = a || b || c || d;
            return final;
        }



        public static Card GetCard()
        {
            Card Carta = Randomizer.GetRandomCard();

            int CurrentPoints = PlayerModule.GetTotalPoints();

            int Ace11 = 11;

            int Plus11 = CurrentPoints + Ace11;

            if (IsAnAce(Carta))
            {
                if (Plus11 <= 21)
                {
                    PlayerModule.Player_CardsPlayed.Add(ChangeCardValue(Carta, 11));
                    return ChangeCardValue(Carta, 11);
                }
                else
                {
                    PlayerModule.Player_CardsPlayed.Add(Carta);

                    if (PlayerModule.GetAceIndex() >= 0 && PlayerModule.Player_CardsPlayed.Count <= 1)
                    {
                        MainWindow.BUSTED = true;
                    }
                    return Carta;
                }
            }
            else
            {
                PlayerModule.Player_CardsPlayed.Add(Carta);
                return Carta;
            }
        }



        private static Card ChangeCardValue(Card TheCard, int value)
        {
            Card CardToPlay = TheCard;
            CardToPlay.CardValue = value;
            return CardToPlay;
        }
    }
}
