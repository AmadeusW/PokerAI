using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;
using PokerAI.Translator;

namespace PokerAI.Translator.Test
{
    [TestClass]
    public class HandTranslatorTests
    {
        [TestMethod]
        public void CreateHandWithValidData()
        {
            var input = @"797210868   1   192  9  2/20    2/40    2/80     2/120    Qc Ks 8s Jh Tc";
            var hand = new Hand(input);

            hand.Timestamp.ShouldBe(797210868);
            hand.Dealer.ShouldBe(1);
            hand.HandId.ShouldBe(192);
            hand.PlayerCountDealt.ShouldBe(9);
            hand.PlayerCountFlop.ShouldBe(2);
            hand.PlayerCountTurn.ShouldBe(2);
            hand.PlayerCountRiver.ShouldBe(2);
            hand.PlayerCountShowdown.ShouldBe(2);
            hand.PotSizeFlop.ShouldBe(20);
            hand.PotSizeTurn.ShouldBe(40);
            hand.PotSizeRiver.ShouldBe(80);
            hand.PotSizeShowdown.ShouldBe(120);
            hand.Board.ShouldBe("QcKs8sJhTc");
        }
    }
}
