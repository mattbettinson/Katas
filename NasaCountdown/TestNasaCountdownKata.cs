using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasaCountdown
{
    [TestFixture]
    public class TestNasaCountdownKata
    {
        [TestCase(-2, new int[] { })]
        [TestCase(-1, new int[] { })]
        [TestCase(0, new[] { 0 })]
        [TestCase(1, new[] { 1, 0})]
        [TestCase(2, new[] { 2, 1, 0 })]
        [TestCase(3, new[] { 3, 2, 1, 0 })]
        [TestCase(4, new[] { 4, 3, 2, 1, 0 })]
        [TestCase(5, new[] { 5, 4, 3, 2, 1, 0 })]
        [TestCase(6, new[] { 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(7, new[] { 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(8, new[] { 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(9, new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(10, new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(11, new[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        [TestCase(12, new[] { 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public void NasaCountdownKata_Countdown(int start, int[] expected)
        {
            // Arrange
            var nasaCountdownKata = new NasaCountdownKata();

            // Act
            var actual = nasaCountdownKata.Countdown(start);

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
