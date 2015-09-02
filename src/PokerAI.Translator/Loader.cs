using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PokerAI.Translator
{
    public class Loader
    {
        public static void LoadData()
        {
            var handPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hdb";
            var rosterPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hroster";
            var playerDirectory = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\pdb";

            var rawHands = File.ReadAllLines(handPath);
            var rawRosters = File.ReadAllLines(rosterPath);

            List<Hand> hands = new List<Hand>();
            List<Roster> rosters = new List<Roster>();

            foreach (var rawHand in rawHands)
            {
                hands.Add(new Hand(rawHand));
            }
            foreach (var rawRoster in rawRosters)
            {
                rosters.Add(new Roster(rawRoster));
            }
        }
    }
}
