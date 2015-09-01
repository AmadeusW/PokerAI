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
            var split = input.Split(' ');
        }
    }
}
