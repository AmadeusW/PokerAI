using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using PokerAI.Translator;

namespace PokerAI.Translator.Test
{
    [TestClass]
    public class RosterTranslatorTests
    {
        [TestMethod]
        public void CreateRosterWithValidData()
        {
            var input = @"797210868  9 Quick Winner777 derek greg gunner jims johnr sagerbot shinner";
            var roster = new Roster(input);

            roster.Timestamp.ShouldBe(797210868);
            roster.PlayerCountDealt.ShouldBe(9);
            roster.PlayerNames.ShouldContain("Quick");
            roster.PlayerNames.ShouldContain("Winner777");
            roster.PlayerNames.ShouldContain("derek");
            roster.PlayerNames.ShouldContain("greg");
            roster.PlayerNames.ShouldContain("gunner");
            roster.PlayerNames.ShouldContain("jims");
            roster.PlayerNames.ShouldContain("johnr");
            roster.PlayerNames.ShouldContain("sagerbot");
            roster.PlayerNames.ShouldContain("shinner");
        }
    }
}
