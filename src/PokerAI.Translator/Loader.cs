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
        public void LoadData()
        {
            var handPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hdb";
            var rosterPath = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\hroster";
            var playerDirectory = @"C:\Users\Amadeus\Documents\GitHub\PokerAI\data\holdem\199504\pdb";

            var handRaw = File.ReadAllLines(handPath);
            var rosterRaw = File.ReadAllLines(rosterPath);
        }
    }
}
