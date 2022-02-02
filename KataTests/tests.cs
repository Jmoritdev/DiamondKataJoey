using DiamondKataJoey;
using NUnit.Framework;

namespace KataTests {
    public class Tests {
        [SetUp]
        public void Setup() {
        }

        [Test]
        public void AReturnsSingleLetter() {
            Assert.AreEqual("A\n", DiamondCreator.CreateDiamond('A'));
        }

        [Test]
        public void BReturns3x3() {
            Assert.AreEqual(" A \nB B\n A \n", DiamondCreator.CreateDiamond('B'));
        }

        [Test]
        public void CReturns5x5() {
            Assert.AreEqual("  A  \n B B \nC   C\n B B \n  A  \n", DiamondCreator.CreateDiamond('C'));
        }
    }
}