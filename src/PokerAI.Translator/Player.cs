using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAI.Translator
{
    public class Player
    {
        public string Nickname;
        public int Timestamp; // of hand
        public int PlayerCountDealt;
        public int PlayerPosition;
        public char BetAtStart;
        public char BetAtFlot;
        public char BetAtTurn;
        public char BetAtRiver;
        public int MoneyIn;
        public string Action; // dunno
        public int MoneyWon;
        public string Cards; // optional

        public Player(string input)
        {

        }
    }
}
