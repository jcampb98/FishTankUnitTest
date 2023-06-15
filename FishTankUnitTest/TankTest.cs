using FishTank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTankUnitTest
{
    [TestClass]
    public class TankTest
    {
        GoldFish goldFish;
        BabelFish babelFish;
        AngelFish angelFish;

        public TankTest()
        {
            goldFish = new GoldFish("John");
            babelFish = new BabelFish("Test1");
            angelFish = new AngelFish("Catfish");
        }

        [TestMethod]
        public void CanAddFishToTank()
        {
            var tank = new Tank();

            tank.Add(angelFish);

            Assert.AreEqual(1, tank.Fish.Count);
        }

        [TestMethod]
        public void CanAddMultipleFishToTank()
        {
            var tank = new Tank();

            tank.Add(angelFish);
            tank.Add(goldFish);
            tank.Add(babelFish);

            Assert.AreEqual(2, tank.Fish.Count);
        }

        [TestMethod]
        public void TankFeedReturnsCorrectValue()
        {
            var tank = new Tank();

            tank.Add(angelFish);
            tank.Add(goldFish);
            tank.Add(babelFish);

            var feed = tank.Feed();
            double expectedResult = 0.1 + 0.2 + 0.3;
            Assert.AreEqual(expectedResult, feed);
        }
    }
}
