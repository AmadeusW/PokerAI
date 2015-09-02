using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerAI.Translator
{
    public class Roster
    {
        public int Timestamp;
        public int PlayerCountDealt;
        public string[] PlayerNames;

        public Roster(string input)
        {

        }

        public override string ToString()
        {
            return $"Roster #{Timestamp} with {PlayerCountDealt} players";
        }

        public override int GetHashCode()
        {
            return Timestamp;
        }

        public override bool Equals(object obj)
        {
            var otherRoster = obj as Roster;
            if (otherRoster != null)
            {
                return Timestamp.Equals(otherRoster.Timestamp);
            }
            return false;
        }
    }
}
