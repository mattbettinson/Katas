using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaParty
{
    [TestFixture]
    public class TestTeaPartyKata
    {
        [TestCase("Austen", true, false, "Hello Ms. Austen")]
        [TestCase("Orwell", false, false, "Hello Mr. Orwell")]
        [TestCase("Newton", false, true, "Hello Sir Newton")]
        public void TeaPartyKata_Welcome(string lastname, bool isWoman, bool isKnighted, string expected)
        {
            // Arrange
            var teaPartyKata = new TeaPartyKata();

            // Act
            var actual = teaPartyKata.Welcome(lastname, isWoman, isKnighted);
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
