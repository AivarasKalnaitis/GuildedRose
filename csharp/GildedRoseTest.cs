﻿using csharp.Items;
using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Test]
        public void BasicItem_Quality_Decrements_Correctly()
        {
            var item = new BasicItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 10 };

            item.UpdateQuality();

            Assert.AreEqual(9, item.Quality);
        }

        [Test]
        public void BasicItem_Quality_Never_Bellow_Zero()
        {
            var item = new BasicItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 0 };

            item.UpdateQuality();

            Assert.IsTrue(item.Quality >= 0);
        }

        [Test]
        public void BasicItem_SellIn_Decrements_Correctly()
        {
            var item = new BasicItem { Name = "+5 Dexterity Vest", SellIn = 10, Quality = 10 };

            item.UpdateQuality();

            Assert.AreEqual(9, item.SellIn);
        }

        [Test]
        public void BasicItem_SellIn_Never_Bellow_Zero()
        {
            var item = new BasicItem { Name = "+5 Dexterity Vest", SellIn = 0, Quality = 10 };

            item.UpdateQuality();

            Assert.IsTrue(item.SellIn >= 0);
        }

        [Test]
        public void ConjuredItem_Quality_Decrements_Correctly()
        {
            var item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };

            item.UpdateQuality();

            Assert.AreEqual(4, item.Quality);
        }

        [Test]
        public void ConjuredItem_Quality_Decrements_Correctly_After_SellIn_Date_Passed()
        {
            var item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 };

            item.UpdateQuality();

            Assert.AreEqual(2, item.Quality);
        }

        [Test]
        public void ConjuredItem_Quality_Never_Bellow_Zero()
        {
            var item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 0 };

            item.UpdateQuality();

            Assert.IsTrue(item.Quality >= 0);
        }

        [Test]
        public void ConjuredItem_SellIn_Decrements_Correctly()
        {
            var item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 3, Quality = 6 };

            item.UpdateQuality();

            Assert.AreEqual(2, item.SellIn);
        }

        [Test]
        public void ConjuredItem_SellIn_Never_Bellow_Zero()
        {
            var item = new ConjuredItem { Name = "Conjured Mana Cake", SellIn = 0, Quality = 6 };

            item.UpdateQuality();

            Assert.IsTrue(item.SellIn >= 0);
        }
    }
}
