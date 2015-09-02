using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAI.Translator
{
    public class Hand
    {
        public int Timestamp;
        public int Dealer;
        public int HandId;
        public int PlayerCountDealt;
        public int PlayerCountFlop;
        public int PlayerCountTurn;
        public int PlayerCountRiver;
        public int PlayerCountShowdown;
        public int PotSizeFlop;
        public int PotSizeTurn;
        public int PotSizeRiver;
        public int PotSizeShowdown;
        public string Board;

        public Hand(string input)
        {
            var split = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Timestamp = Int32.Parse(split[0]);
            Dealer = Int32.Parse(split[1]);
            HandId = Int32.Parse(split[2]);
            PlayerCountDealt = Int32.Parse(split[3]);
            var flopSituation = split[4].Split('/');
            PlayerCountFlop = Int32.Parse(flopSituation[0]);
            PotSizeFlop = Int32.Parse(flopSituation[1]);
            var turnSituation = split[5].Split('/');
            PlayerCountTurn = Int32.Parse(turnSituation[0]);
            PotSizeTurn = Int32.Parse(turnSituation[1]);
            var riverSituation = split[6].Split('/');
            PlayerCountRiver = Int32.Parse(riverSituation[0]);
            PotSizeRiver = Int32.Parse(riverSituation[1]);
            var showdownSituation = split[7].Split('/');
            PlayerCountShowdown = Int32.Parse(showdownSituation[0]);
            PotSizeShowdown = Int32.Parse(showdownSituation[1]);
            for (int i = 8; i < split.Count(); i++)
            {
                Board += split[i];
            }
        }

        public override string ToString()
        {
            return $"Hand #{Timestamp} with {PlayerCountDealt} players";
        }

        public override int GetHashCode()
        {
            return Timestamp;
        }

        public override bool Equals(object obj)
        {
            var otherHand = obj as Hand;
            if (otherHand != null)
            {
                return Timestamp.Equals(otherHand.Timestamp);
            }
            return false;
        }
    }
}
