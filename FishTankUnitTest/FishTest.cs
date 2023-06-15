using FishTank;

namespace FishTankUnitTest
{
    [TestClass]
    public class FishTest
    {
        GoldFish goldFish;
        BabelFish babelFish;
        AngelFish angelFish;

        [TestMethod]
        public void CreateFishNameAndIsStoredCorrectly()
        {
            goldFish = new GoldFish("TestNameGold");
            angelFish = new AngelFish("TestNameAngel");
            babelFish = new BabelFish("TestNameBabel");

            Assert.AreEqual("TestNameGold", goldFish.Name);
            Assert.AreEqual("TestNameAngel", angelFish.Name);
            Assert.AreEqual("TestNameBabel", babelFish.Name);
        }
    }
}