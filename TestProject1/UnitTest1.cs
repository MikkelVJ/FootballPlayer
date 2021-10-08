using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FootballPlayer;
using FootballPlayer = FootballPlayer.FBPlayer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFPProperties()
        {
            FBPlayer fbp = new FBPlayer("Olsen", 15, 001, 100);

            fbp.Name = "Egon";
            Assert.AreEqual("Egon", fbp.Name);

            fbp.ShirtNumber = 2;
            Assert.AreEqual(2, fbp.ShirtNumber);

            fbp.Id = 33;
            Assert.AreEqual(33, fbp.Id);

            fbp.price = 150;
            Assert.AreEqual(150, fbp.price);
        }

        [TestMethod]
        public void TestFBPExceptions()
        {
            FBPlayer fbp = new FBPlayer("Anders and", 13, 13, 149);

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => fbp.Name = "a"));

            Assert.ThrowsException<ArgumentOutOfRangeException>((() => fbp.ShirtNumber = 150));

        }
    }
}
