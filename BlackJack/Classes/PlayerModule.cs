using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Classes
{

    public class Player : IEquatable<Player>
    {
        public int ID { get; set; }
        public string PlayerName { get; set; }
        public int PlayerMoney { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + "   PlayerMoney: " + PlayerMoney + "   PlayerName: " + PlayerName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Player objAsPart = obj as Player;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public bool Equals(Player other)
        {
            if (other == null) return false;
            return (this.ID.Equals(other.ID));
        }
    }


    public class PlayerModule
    {
        public static List<Card> Player_CardsPlayed = new List<Card>();

        public static Player PlayerProfile = new Player();

        public static List<int> AcesPlayed = new List<int>();
        public static void GeneratePlayer(int PlayerID)
        {
            List<Player> jogadores = new List<Player>();

            jogadores.Add(new Player { ID = 0, PlayerMoney = 0, PlayerName = "House" });
            jogadores.Add(new Player { ID = 1, PlayerMoney = 1000, PlayerName = "Rodrigo Simões" });
            jogadores.Add(new Player { ID = 2, PlayerMoney = 1000, PlayerName = "João Videira" });

            PlayerProfile = jogadores[PlayerID];
        }

        public static int GetTotalPoints()
        {
            int TotalValue = 0;
            foreach (Card aCard in Player_CardsPlayed)
            {
                TotalValue += aCard.CardValue;
            }
            return TotalValue;
        }

        public static void ResetTotalPointsValues()
        {
            Player_CardsPlayed.Clear();
            AcesPlayed.Clear();
        }

        public static Player GetPlayerGenerated()
        {
            return PlayerProfile;
        }
        public static int GetAceIndex()
        {
            int index = Player_CardsPlayed.FindIndex(x => x.CardName == "Ás");
            return index;
        }
    }
}
